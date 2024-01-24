using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiColoredModernUI.Forms.Etc
{
    class MssqlEtc
    {
        SqlConnection sqlConnect;
        SqlCommand cmd;

        public void Connect()
        {
            sqlConnect = new SqlConnection("Server=218.234.32.194,5242; Database=NEW_SHIP; uid=sa; pwd=yasdo12!@");

            sqlConnect.Open();

        }

        public List<List<string>> SelectBusPrice(string citycode, string cityname, string busclass, string busclassname)
        {
            Connect();

            List<string> price = new List<string>();
            List<List<string>> totalprices = new List<List<string>>();

            string query = "";

            int i = 0;

            query = "select * from TBBusFare_Ex2";


            if (citycode != "" || cityname != "" || busclass != "" || busclassname != "")
            {
                query += " where";

                int iCount = 0;

                if (citycode != "")
                {
                    iCount++;
                    query += string.Format(" citycode = {0}", citycode);
                }

                if (cityname != "")
                {
                    iCount++;

                    if (iCount > 1)
                        query += " and ";

                    query += string.Format(" cityname like '%{0}%'", cityname);
                }
                if (busclass != "")
                {
                    iCount++;

                    if (iCount > 1)
                        query += " and ";

                    query += string.Format(" busclass = {0}", busclass);
                }
                if (busclassname != "")
                {
                    iCount++;

                    if (iCount > 1)
                        query += " and ";

                    query += string.Format(" busclassname like '%{0}%'", busclassname);
                }
            }

            query += " order by 3,1,2,4";



            cmd = new SqlCommand(query, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                price.Add(reader["CityCode"].ToString());
                price.Add(reader["CityName"].ToString());
                price.Add(reader["BusClass"].ToString());
                price.Add(reader["BusClassName"].ToString());
                price.Add(reader["BusCash"].ToString());
                price.Add(reader["BusCard"].ToString());

                totalprices.Add(price.ToList());
                price.Clear();

            }

            reader.Close();
            sqlConnect.Close();

            return totalprices;
        }

        public void UpdateBusPrice(string citycode, string busclass, string buscash, string buscard )
        {
            Connect();

            string query = string.Format("update TBBusFare_Ex2 set buscash = {2}, buscard = {3} where citycode = {0} and busclass = {1}",citycode,busclass,buscash,buscard);
    

            cmd = new SqlCommand(query, sqlConnect);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            sqlConnect.Close();
        }
    }
}
