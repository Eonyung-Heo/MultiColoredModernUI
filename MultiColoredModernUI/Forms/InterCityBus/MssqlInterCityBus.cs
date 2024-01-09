using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace MultiColoredModernUI.Forms.InterCityBus
{
    class MssqlInterCityBus
    {
        SqlConnection sqlConnect;
        SqlCommand cmd;

        public void Connect()
        {
            sqlConnect = new SqlConnection("Server=218.234.32.245,5242; Database=AID_TOOL; uid=sa; pwd=yasdo12!@");

            sqlConnect.Open();

        }

        public void DeleteBusSchedule()
        {

            string query = "delete NTBBus";

            Connect();

            cmd = new SqlCommand(query, sqlConnect);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            sqlConnect.Close();


        }

        public void InsertBusSchedule(string query)
        {

            Connect();

            cmd = new SqlCommand(query, sqlConnect);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();


            sqlConnect.Close();


        }

        public List<List<string>> CheckBusSchedule()
        {

            Connect();

            List<string> sch = new List<string>();

            List<List<string>> totalSch = new List<List<string>>();

            string query = "";

            query = "update NTBbus set StationSequence=StationSequence-1";
            cmd = new SqlCommand(query, sqlConnect);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();


            for (int i = 1; i < 4; i++)
            {
                query = "select * from FN_NTBbus(" + i + ")";

                cmd = new SqlCommand(query, sqlConnect);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    while (reader.Read())
                    {
                        sch.Add(reader["LaneID"].ToString());
                        sch.Add(reader["LaneNo"].ToString());
                        sch.Add(reader["ServiceDayID"].ToString());
                        sch.Add(reader["OperationOrder"].ToString());
                        sch.Add(reader["StationSequence"].ToString());
                        sch.Add(reader["StationID"].ToString());
                        sch.Add(reader["NameKor"].ToString());
                        sch.Add(reader["DepartureTime"].ToString());
                        sch.Add(reader["Error"].ToString());

                        totalSch.Add(sch.ToList());
                        sch.Clear();

                    }

                    break;
                }

                reader.Close();
            }

            sqlConnect.Close();

            return totalSch;


        }

        public List<List<string>> SelectBusSchedule()
        {
            Connect();

            List<string> sch = new List<string>();

            List<List<string>> totalSch = new List<List<string>>();

            string query = "select * from NTBBus order by 1,2,3,4,5";

            cmd = new SqlCommand(query, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                sch.Add(reader["LaneID"].ToString());
                sch.Add(reader["LaneNo"].ToString());
                sch.Add(reader["ServiceDayID"].ToString());
                sch.Add(reader["OperationOrder"].ToString());
                sch.Add(reader["StationSequence"].ToString());
                sch.Add(reader["StationID"].ToString());
                sch.Add(reader["NameKor"].ToString());
                sch.Add(reader["DepartureTime"].ToString());

                totalSch.Add(sch.ToList());
                sch.Clear();

            }

            reader.Close();
            sqlConnect.Close();

            return totalSch;
        }

        public void ScheduleUpdate()
        {
            Connect();

            string query = "exec sp_Make_NBusScheduleUpdate";

            cmd = new SqlCommand(query, sqlConnect);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            sqlConnect.Close();
        }

    }
}