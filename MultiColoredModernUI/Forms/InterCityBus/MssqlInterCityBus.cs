using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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

        public void DeleteTable(string query)
        {


            Connect();

            query = "delete " + query;

            cmd = new SqlCommand(query, sqlConnect);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            sqlConnect.Close();


        }

        public void InsertNInterCityBus(string query)
        {

            Connect();

            cmd = new SqlCommand(query, sqlConnect);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            sqlConnect.Close();

        }

        public void exceptBusSchedule()
        {
            Connect();

            string query = "";


            query = "update NTBbus set StationSequence=StationSequence-1";
            cmd = new SqlCommand(query, sqlConnect);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            query = "update NTBBus set DepartureTime = AID_TOOL.dbo.GetRegExReplace(departureTime,'[^0-9]','') where departureTime like '%[^0-9]%'";
            cmd = new SqlCommand(query, sqlConnect);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            sqlConnect.Close();
        }

        public void exceptBusRoute()
        {
            Connect();

            string query = "";



            sqlConnect.Close();
        }

        public List<List<string>> CheckBusSchedule()
        {

            Connect();

            List<string> sch = new List<string>();

            List<List<string>> totalSch = new List<List<string>>();

            string query = "";

            int i = 0;

            query = "select * from FN_NTBBus(0)";

            cmd = new SqlCommand(query, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
                i = Convert.ToInt16(reader["Error"].ToString()) + 1;


            reader.Close();

            for (int j = 1; j < i; j++)
            {
                try
                {
                    query = "select * from FN_NTBBus(" + j + ")";

                    cmd = new SqlCommand(query, sqlConnect);

                    reader = cmd.ExecuteReader();


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

                    reader.Close();

                    if(totalSch.Count > 0)
                        break;
                }
                catch
                {
                    MessageBox.Show(i + "번째 프로시저 실행 도중 에러 발생");
                    break;
                }
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

            string query = "exec sp_NBusScheduleUpdate";

            cmd = new SqlCommand(query, sqlConnect);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            sqlConnect.Close();
        }

        public void UpdateNInterCityBus(string query)
        {
            Connect();

            cmd = new SqlCommand(query, sqlConnect);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            sqlConnect.Close();
        }

        public List<List<string>> SelectBusRoute()
        {
            Connect();

            List<string> sch = new List<string>();

            List<List<string>> totalSch = new List<List<string>>();

            string query = "select * from NTOOL_DATA_NEW.dbo.[07_1_tb_route_stops_Aro_Ex_Add] order by 1,2,3,4,5";

            cmd = new SqlCommand(query, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                sch.Add(reader["route_id"].ToString());
                sch.Add(reader["lane_no"].ToString());
                sch.Add(reader["stop_sequence"].ToString());
                sch.Add(reader["up_down"].ToString());
                sch.Add(reader["stop_id"].ToString());
                sch.Add(reader["stop_name"].ToString());

                totalSch.Add(sch.ToList());
                sch.Clear();

            }

            reader.Close();
            sqlConnect.Close();

            return totalSch;
        }

        public void InsertBusRouteAll()
        {
            Connect();

            List<string> sch = new List<string>();

            List<List<string>> totalSch = new List<List<string>>();

            string query = "delete NTOOL_DATA_NEW.dbo.[07_1_tb_route_stops_Aro_Ex_all] " +
                "from NTOOL_DATA_NEW.dbo.[07_1_tb_route_stops_Aro_Ex_all]  as a " +
                ",NTOOL_DATA_NEW.dbo.[07_1_tb_route_stops_Aro_Ex_add] as b " +
                "where a.laneid = b.route_id";

            cmd = new SqlCommand(query, sqlConnect);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            query = "insert into NTOOL_DATA_NEW.dbo.[07_1_tb_route_stops_Aro_Ex_all] " +
                "select a.route_id,b.LaneNo,a.stop_sequence,a.up_down,a.stop_id,a.stop_name,getdate() from " +
                " NTOOL_DATA_NEW.dbo.[07_1_tb_route_stops_Aro_Ex_add] as a " +
                "join NTOOL_DATA_NEW.dbo.[90_tb_route_stops_mapping] as b on a.route_id = b.NToolID";

            cmd = new SqlCommand(query, sqlConnect);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();


            sqlConnect.Close();

            
        }

        public List<List<string>> CheckBusRoute()
        {

            Connect();

            List<string> sch = new List<string>();

            List<List<string>> totalSch = new List<List<string>>();

            string query = "";

            query = "select * from FN_NBusRoute(0)";

            cmd = new SqlCommand(query, sqlConnect);

            int i = 0;

            SqlDataReader reader = cmd.ExecuteReader();

            if(reader.Read())
                i = Convert.ToInt16(reader["Error"].ToString())+1;

            reader.Close();

            for (int j = 1; j < i ; j++)
            {
                try
                {
                    query = "select * from FN_NBusRoute(" + j + ")";

                    cmd = new SqlCommand(query, sqlConnect);

                    reader = cmd.ExecuteReader();


                    while (reader.Read())
                    {
                        sch.Add(reader["LaneID"].ToString());
                        sch.Add(reader["LaneNo"].ToString());
                        sch.Add(reader["StationSequence"].ToString());
                        sch.Add(reader["Direction"].ToString());
                        sch.Add(reader["StationID"].ToString());
                        sch.Add(reader["NameKor"].ToString());
                        sch.Add(reader["Error"].ToString());

                        totalSch.Add(sch.ToList());
                        sch.Clear();

                    }

                    reader.Close();

                    if (totalSch.Count > 0)
                        break;
                }
                catch
                {
                    MessageBox.Show(i + "번째 프로시저 실행 도중 에러 발생");
                    break;
                }
            }

            sqlConnect.Close();

            return totalSch;


        }

        public List<List<string>> SelectNBusSchedule(string Laneid, string ServiceDayId, string OperationOrder, string StationSequence, string StationId)
        {
            Connect();

            List<string> sch = new List<string>();

            List<List<string>> totalSch = new List<List<string>>();

            if (Laneid == "")
                Laneid = "513";

            string query = "select * from [naverpubtrans_aro].[dbo].[NBusSchedule_NTool] where Laneid = " + Laneid;

            if (ServiceDayId != "")
                query += "and ServiceDayId = " + ServiceDayId;
            if (OperationOrder != "")
                query += "and OperationOrder = " + OperationOrder;
            if (StationSequence != "")
                query += "and StationSequence = " + StationSequence;
            if (StationId != "")
                query += "and StationId = " + StationId;

            query += " order by 1,2,3,4,5";


            cmd = new SqlCommand(query, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                sch.Add(reader["Laneid"].ToString());
                sch.Add(reader["ServiceDayId"].ToString());
                sch.Add(reader["OperationOrder"].ToString());
                sch.Add(reader["StationSequence"].ToString());
                sch.Add(reader["StationId"].ToString());
                sch.Add(reader["ArrivalTime"].ToString());
                sch.Add(reader["DepartureTime"].ToString());
                sch.Add(reader["ModifiedAt"].ToString());

                totalSch.Add(sch.ToList());
                sch.Clear();

            }

            reader.Close();
            sqlConnect.Close();

            return totalSch;
        }


        public List<List<string>> SelectRouteList(string search,string aroid,string ntoolid)
        {
            Connect();

            List<string> route = new List<string>();

            List<List<string>> totalroute = new List<List<string>>();

            string query = "select * from NTOOL_DATA_NEW.dbo.[90_tb_route_stops_mapping] ";

            if (search != "")
                query += "where laneno like '%" + search + "%' or aroid like '%" + search + "%' or ntoolid like '%" + search + "%'";

            if (aroid != "")
                query += "where  aroid = " + aroid;

            else if (ntoolid != "")
                query += "where  ntoolid = " + ntoolid;

            cmd = new SqlCommand(query, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                route.Add(reader["LaneNo"].ToString());
                route.Add(reader["AroID"].ToString());
                route.Add(reader["NtoolID"].ToString());

                totalroute.Add(route.ToList());
                route.Clear();

            }

            reader.Close();
            sqlConnect.Close();

            return totalroute;
        }

        public void InsertRouteList(string LaneNo,string Aroid, string Ntoolid)
        {
            Connect();

            if (Aroid == "")
                Aroid = "0";
            else if(Ntoolid == "")
                Ntoolid = "0";



            string query = string.Format("insert into NTOOL_DATA_NEW.dbo.[90_tb_route_stops_mapping] values " +
                "('{0}',{1},{2})", LaneNo, Aroid, Ntoolid);

            cmd = new SqlCommand(query, sqlConnect);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            sqlConnect.Close();
        }


        public void DeleteRouteList(string LaneNo, string Aroid, string Ntoolid)
        {
            Connect();

            string query = string.Format("delete NTOOL_DATA_NEW.dbo.[90_tb_route_stops_mapping] where  " +
                "LaneNo = '{0}'and Aroid = {1} or Ntoolid = {2}", LaneNo, Aroid, Ntoolid);

            cmd = new SqlCommand(query, sqlConnect);
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();

            sqlConnect.Close();
        }



    }
}