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

            query = string.Format("select * from TBBusFare_Ex2 where cityname like '%{0}%'", cityname);

            if (citycode != "")
                query += string.Format(" and citycode = {0}", citycode);
            
            if (busclass != "")           
               query += string.Format(" and busclass = {0}", busclass);
            
            if (busclassname != "")
                query += string.Format(" and busclassname like '%{0}%'", busclassname);
            
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

        public List<List<string>> SelectInterCityBusPrice(string laneid, string laneno, string fare, string citycode)
        {
            Connect();

            List<string> price = new List<string>();
            List<List<string>> totalprices = new List<List<string>>();

            string query = "";

            query = string.Format("select * from [245].NTOOL_DATA_NEW.dbo.[90_tb_AirBusfare] where route_name like '%{0}%'", laneno);

            if (laneid != "")
                query += string.Format(" and route_id = {0}", laneid);

            if (fare != "")
                query += string.Format(" and fare = {0}", fare);

            if (citycode != "")
                query += string.Format(" and city_code = {0}", citycode);

            query += " order by 3,1,2,4";

            cmd = new SqlCommand(query, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                price.Add(reader["route_id"].ToString());
                price.Add(reader["route_name"].ToString());
                price.Add(reader["fare_id"].ToString());
                price.Add(reader["fare"].ToString());
                price.Add(reader["city_code"].ToString());

                totalprices.Add(price.ToList());
                price.Clear();

            }

            reader.Close();
            sqlConnect.Close();

            return totalprices;
        }

        public void UpdateInterCityBusPrice(string laneid, string fareid,string fare)
        {
            Connect();

            string query = string.Format("update [245].NTOOL_DATA_NEW.dbo.[90_tb_AirBusfare] set fare = {2} where route_id = {0} and fare_id = {1}", laneid, fareid,fare);


            cmd = new SqlCommand(query, sqlConnect);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            sqlConnect.Close();
        }
    }
}
