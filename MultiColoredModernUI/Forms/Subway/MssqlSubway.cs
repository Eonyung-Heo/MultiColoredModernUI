using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



namespace MultiColoredModernUI.Forms.Subway
{
    class MssqlSubway
    {
        SqlConnection sqlConnect;
        SqlCommand cmd;
        SubwayStation sSf;


        public void Connect()
        {
            sqlConnect = new SqlConnection("Server=218.234.32.245,5242; Database=AID_TOOL; uid=sa; pwd=yasdo12!@");

            sqlConnect.Open();

        }

        public void GetRegion()
        {
            Connect();

            string strSql = "";

            strSql = string.Format("select * from Naverodsay.dbo.TBCityCode where CityCode in (select distinct CityCode from Naverodsay.dbo.TBSubwayLane) order by CityCode");

            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            StaticSubway.regions.Clear();
            StaticSubway.region.Clear();

            while (reader.Read())
            {

              

                StaticSubway.region.Add(reader["CityCode"].ToString());
                StaticSubway.region.Add(reader["CityName"].ToString());

                StaticSubway.regions.Add(StaticSubway.region.ToList());
                StaticSubway.region.Clear();

            }

            //연결종료
            reader.Close();
            sqlConnect.Close();
        }


        public void GetStationName(int cityCode, int laneType)
        {
            Connect();

            string strSql = "";

            strSql = string.Format("select distinct Namekor,StationID from Naverodsay.dbo.TBSubwayLane where cityCode = {0}", cityCode);

            if(laneType > 0)                                                                                                                                                             
                strSql = strSql + string.Format("and Type = {0}",laneType);

            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            StaticSubway.stationName.Clear();
            StaticSubway.stationNames.Clear();

            sSf = new SubwayStation();

            while (reader.Read())
            {              
                StaticSubway.stationName.Add(reader["StationID"].ToString());
                StaticSubway.stationName.Add("");
                StaticSubway.stationName.Add(reader["Namekor"].ToString());
                

                StaticSubway.stationNames.Add(StaticSubway.stationName.ToList());
                StaticSubway.stationName.Clear();

            }


            //연결종료
            reader.Close();
            sqlConnect.Close();
        }

        public void GetStationSearch(int cityCode, string search)
        {
            Connect();

            string strSql = "";

            strSql = string.Format("select distinct a.StationID,b.LaneName,a.NameKor from(" +
                " select Type, Stationid, namekor from Naverodsay.dbo.TBSubwayLane where CityCode = {0} and NameKor like '%{1}%' ) as a" +
                " join(select * from naverodsay.dbo.TBSubwayType ) as b " +
                "on a.Type = b.Type",cityCode,search);

            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            StaticSubway.stationName.Clear();
            StaticSubway.stationNames.Clear();

            while (reader.Read())
            {
                
                StaticSubway.stationName.Add(reader["StationID"].ToString());
                StaticSubway.stationName.Add(reader["LaneName"].ToString());
                StaticSubway.stationName.Add(reader["Namekor"].ToString());

                StaticSubway.stationNames.Add(StaticSubway.stationName.ToList());
                StaticSubway.stationName.Clear();

            }


            //연결종료
            reader.Close();
            sqlConnect.Close();
        }
        public void GetExchangeStationSearch(int cityCode, string search)
        {
            Connect();

            string strSql = "";

            strSql = string.Format("select distinct ssid1,LaneName,namekor from " +
                "(select slid1,namekor,ssid1 from naverpubtrans_aro.dbo.TBSubwayExchange  where " +
                "namekor like '%{1}%' and namekor != '신도림' and ssid1 in(select stationid from naverodsay.dbo.TBSubwayLane where citycode={0})) as a " +
                "join naverodsay.dbo.TBSubwayType as b on a.slid1 = b.LaneId", cityCode, search);
           
                cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            StaticSubway.stationName.Clear();
            StaticSubway.stationNames.Clear();

            while (reader.Read())
            {

                StaticSubway.stationName.Add(reader["ssid1"].ToString());
                StaticSubway.stationName.Add(reader["LaneName"].ToString());
                StaticSubway.stationName.Add(reader["Namekor"].ToString());

                StaticSubway.stationNames.Add(StaticSubway.stationName.ToList());
                StaticSubway.stationName.Clear();

            }


            //연결종료
            reader.Close();
            sqlConnect.Close();
        }


        public void GetExChangeStationName(int cityCode, int laneType)
        {
            Connect();

            string strSql = "";

            strSql = string.Format("select distinct namekor,ssid1 from naverpubtrans_aro.dbo.TBSubwayExchange  " +
                "                       where " +
                "                           slid1 in (select LaneID from Naverodsay.[dbo].[TBSubwayType] where Type = {0} ) and " +
                "                           slid2 not in(select LaneID from Naverodsay.[dbo].[TBSubwayType] where Type = {0}) and namekor != '신도림'", laneType);



            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            StaticSubway.stationName.Clear();
            StaticSubway.stationNames.Clear();

            while (reader.Read())
            {
                StaticSubway.stationName.Add(reader["ssid1"].ToString());
                StaticSubway.stationName.Add("");
                StaticSubway.stationName.Add(reader["Namekor"].ToString());
                

                StaticSubway.stationNames.Add(StaticSubway.stationName.ToList());
                StaticSubway.stationName.Clear();

            }


            //연결종료
            reader.Close();
            sqlConnect.Close();
        }

        public void GetStation(long stationID)
        {
            Connect();

            string strSql = "";

            strSql = string.Format("select * from Naverodsay.dbo.TBSubwayStation where SSID = {0}", stationID);

            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            StaticSubway.station.Clear();
            StaticSubway.stations.Clear();

            while (reader.Read())
            {

                StaticSubway.station.Add(reader["SSID"].ToString());
                StaticSubway.station.Add(reader["Namekor"].ToString());
                StaticSubway.station.Add(reader["Aliaskor"].ToString());
                StaticSubway.station.Add(reader["SX"].ToString());
                StaticSubway.station.Add(reader["SY"].ToString());

                /*
                StaticSubway.station.Add(reader["NextSsID1"].ToString());
                StaticSubway.station.Add(reader["NextNameKor1"].ToString());
                StaticSubway.station.Add(reader["NextSX1"].ToString());
                StaticSubway.station.Add(reader["NextSY1"].ToString());

                StaticSubway.station.Add(reader["NextSsID2"].ToString());
                StaticSubway.station.Add(reader["NextNameKor2"].ToString());
                StaticSubway.station.Add(reader["NextSX2"].ToString());
                StaticSubway.station.Add(reader["NextSY2"].ToString());

                StaticSubway.station.Add(reader["PrevSsID1"].ToString());
                StaticSubway.station.Add(reader["PrevNameKor1"].ToString());
                StaticSubway.station.Add(reader["PrevSX1"].ToString());
                StaticSubway.station.Add(reader["PrevSY1"].ToString());

                StaticSubway.station.Add(reader["PrevSsID2"].ToString());
                StaticSubway.station.Add(reader["PrevNameKor2"].ToString());
                StaticSubway.station.Add(reader["PrevSX2"].ToString());
                StaticSubway.station.Add(reader["PrevSY2"].ToString());
              

                StaticSubway.station.Add(reader["LaneNo"].ToString());
                StaticSubway.station.Add(reader["Class"].ToString());
                StaticSubway.station.Add(reader["Type"].ToString());
                */

           
                StaticSubway.station.Add(reader["Platform"].ToString());             //6//6
                StaticSubway.station.Add(reader["RestRoom"].ToString());             //7
                StaticSubway.station.Add(reader["CrossOver"].ToString());            //8
                StaticSubway.station.Add(reader["MeetingPlace"].ToString());         //9
                StaticSubway.station.Add(reader["PublicOffice"].ToString());
                StaticSubway.station.Add(reader["OffDoor"].ToString());   //10
                StaticSubway.station.Add(reader["Bicycle"].ToString());              //11
                StaticSubway.station.Add(reader["Tel"].ToString());                  //13
                StaticSubway.station.Add(reader["AddressKor"].ToString());           //14
                StaticSubway.station.Add(reader["RoadAddress"].ToString());          //15

                StaticSubway.stations.Add(StaticSubway.station.ToList());
                StaticSubway.station.Clear();


            }


            //연결종료
            reader.Close();
            sqlConnect.Close();
        }

        public void GetLaneType(int cityCode)
        {
            Connect();

            string strSql = "";

            strSql = string.Format("select distinct LaneName,Type from Naverodsay.dbo.TBSubwayType where cityCode = {0} and Exclass <> '급행'", cityCode);

            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            StaticSubway.laneType.Clear();
            StaticSubway.laneTypes.Clear();

            while (reader.Read())
            {

                StaticSubway.laneType.Add(reader["LaneName"].ToString());
                //StaticSubway.laneType.Add(reader["LaneID"].ToString());
                StaticSubway.laneType.Add(reader["Type"].ToString());

                StaticSubway.laneTypes.Add(StaticSubway.laneType.ToList());
                StaticSubway.laneType.Clear();

            }

            //연결종료
            reader.Close();
            sqlConnect.Close();
        }

        public void SetStation(string stationID, string namekor, string aliaskor, string sx, string sy, string platform, string restRoom, string crossOver, string meetPlace,
            string publicOffice, string offDoor, string bicycle, string tel, string address, string roadAddress, string log  )
        {
            
            Connect();

            string strSql = "";

            strSql = string.Format("update  Naverodsay.dbo.TBSubwayStation set  ");
            strSql += string.Format("aliaskor = '{0}' ", aliaskor);
            strSql += string.Format(",sx = {0} ", sx);
            strSql += string.Format(",sy = {0} ", sy);
            strSql += string.Format(",platform = {0} ", platform);
            strSql += string.Format(",restRoom = {0} ", restRoom);
            strSql += string.Format(",crossOver = {0} ", crossOver);
            strSql += string.Format(",MeetingPlace = {0} ", meetPlace);
            strSql += string.Format(",publicOffice = {0} ", publicOffice);
            strSql += string.Format(",bicycle = {0} ", bicycle);
            strSql += string.Format(",offDoor = {0} ", offDoor);
            strSql += string.Format(",tel = '{0}' ", tel);
            strSql += string.Format(",addressKor = '{0}' ", address);
            strSql += string.Format(",roadAddress = '{0}' ", roadAddress);
            strSql += string.Format("where ssid = '{0}' ", stationID);

            string[] arrRoadAddress = roadAddress.Split(' ');

            string roadName = "";
            string bonbun = "";
            string boobun = "";

            Regex rx1 = new Regex(@"[가-힣]+로");
            Regex rx2 = new Regex(@"([0-9,]+)?[가-힣]+길");
            Regex rx3 = new Regex(@"[0-9,]+-+[0-9,]");
            Regex rx4 = new Regex(@"[0-9,]");

            for (int i = 0; i < arrRoadAddress.Length; i++)
            {
                if (rx1.IsMatch(arrRoadAddress[i]))
                {
                    roadName = arrRoadAddress[i];
                }
                else if (rx2.IsMatch(arrRoadAddress[i]))
                {
                    if (roadName != "")
                        roadName += " " + arrRoadAddress[i];
                    else
                        roadName = arrRoadAddress[i];
                }
                else if (rx3.IsMatch(arrRoadAddress[i]))
                {
                    string[] arrT2 = arrRoadAddress[i].Split('-');

                    bonbun = arrT2[0];
                    boobun = arrT2[1];
                }
                else if (rx4.IsMatch(arrRoadAddress[i]))
                    bonbun = arrRoadAddress[i];
            }

            cmd = new SqlCommand(strSql, sqlConnect);
            cmd.CommandText = strSql;
            cmd.ExecuteNonQuery();

            strSql = string.Format("update naverodsay.dbo.TBStation");
            strSql += string.Format(" set roadName = '{0}',bonbun = '{1}', boobun = '{2}',roadAddress = '{3}'", roadName, bonbun, boobun, roadAddress);
            strSql += string.Format(" where stationID = {0}", stationID);

            cmd = new SqlCommand(strSql, sqlConnect);
            cmd.CommandText = strSql;
            cmd.ExecuteNonQuery();

            strSql = string.Format("insert AID_TOOL.dbo.[TBSubway_History]   ");
            strSql += string.Format("values('{0}','TBSubwayStation',{1},'{2}','',getdate(),'{3}')", StaticMain.userName,stationID, namekor,log);

            cmd = new SqlCommand(strSql, sqlConnect);
            cmd.CommandText = strSql;
            cmd.ExecuteNonQuery();

            //연결종료
            sqlConnect.Close();
        }

        public bool CheckStation(long stationID, string namekor, string aliaskor, double sx, double sy, int platform, int restRoom, int crossOver, int meetPlace,
        int publicOffice, int bicycle, int offDoor, string tel, string address, string roadAddress)
        {

            bool result = false;

            Connect();

            string strSql = "";


            strSql = string.Format("select * from Naverodsay.dbo.TBSubwayStation where ");
            strSql += string.Format("ssid = '{0}' ", stationID);
            strSql += string.Format("and aliaskor = '{0}' ", aliaskor);
            strSql += string.Format("and sx = {0} ", sx);
            strSql += string.Format("and sy = {0} ", sy);
            strSql += string.Format("and platform = {0} ", platform);
            strSql += string.Format("and restRoom = {0} ", restRoom);
            strSql += string.Format("and crossOver = {0} ", crossOver);
            strSql += string.Format("and publicOffice = {0} ", publicOffice);
            strSql += string.Format("and bicycle = {0} ", bicycle);
            strSql += string.Format("and offDoor = {0} ", offDoor);
            strSql += string.Format("and tel = '{0}' ", tel);
            strSql += string.Format("and addressKor = '{0}' ", address);
            strSql += string.Format("and roadAddress = '{0}' ", roadAddress);


            cmd = new SqlCommand(strSql, sqlConnect);
            SqlDataReader reader = cmd.ExecuteReader();

            result = reader.Read();

            //연결종료
            reader.Close();
            sqlConnect.Close();

            return result;
        }

        public void GetFacility(long stationID)
        {
            Connect();

            string strSql = "";

            strSql = string.Format("select * from Naverodsay.dbo.TBSubwayFacility where StationID = {0}", stationID);

            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            StaticSubway.station.Clear();
            StaticSubway.stations.Clear();

            while (reader.Read())
            {

                StaticSubway.station.Add(reader["StationID"].ToString());
                StaticSubway.station.Add(reader["StationName"].ToString());
                StaticSubway.station.Add(reader["LostCenter"].ToString());
                StaticSubway.station.Add(reader["BicycleRack"].ToString());
                StaticSubway.station.Add(reader["TransferParking"].ToString());
                StaticSubway.station.Add(reader["StationOffice"].ToString());             //6//6
                StaticSubway.station.Add(reader["PublicOffice"].ToString());             //7
                StaticSubway.station.Add(reader["Ticket"].ToString());            //8
                StaticSubway.station.Add(reader["DisabledToilet"].ToString());         //9
                StaticSubway.station.Add(reader["Elevator"].ToString());
                StaticSubway.station.Add(reader["WheelChairLift"].ToString());   //10
                StaticSubway.station.Add(reader["VisitorCenter"].ToString());              //11
                StaticSubway.station.Add(reader["AutomaticDispenser"].ToString());                  //13
                StaticSubway.station.Add(reader["LactationRoom"].ToString());           //14
                StaticSubway.station.Add(reader["Locker"].ToString());
                StaticSubway.station.Add(reader["lostcenter_tel"].ToString());                  //13
                StaticSubway.station.Add(reader["lostcenter_url"].ToString());           //14

                StaticSubway.stations.Add(StaticSubway.station.ToList());
                StaticSubway.station.Clear();


            }


            //연결종료
            reader.Close();
            sqlConnect.Close();
        }

        public void SetFacility(string stationID, string namekor, string lostCenter, string bicycleRack, string transferParking, string stationOffice, string publicOffice,
            string ticket, string disabledToilet, string elevator, string wheelChairLift, string visitorCenter, string automaticDispenser, string lactationRoom, string locker, string lostCenter_Tel, string lostCenter_Url, string log)
        {

            Connect();

            string strSql = "";


            strSql = string.Format("update  Naverodsay.dbo.TBSubwayFacility set  ");
            strSql += string.Format("lostCenter = {0} ", lostCenter);
            strSql += string.Format(",bicycleRack = {0} ", bicycleRack);
            strSql += string.Format(",transferParking = {0} ", transferParking);
            strSql += string.Format(",stationOffice = {0} ", stationOffice);
            strSql += string.Format(",publicOffice = {0} ", publicOffice);
            strSql += string.Format(",ticket = {0} ", ticket);
            strSql += string.Format(",disabledToilet = {0} ", disabledToilet);
            strSql += string.Format(",elevator = {0} ", elevator);
            strSql += string.Format(",wheelChairLift = {0} ", wheelChairLift);
            strSql += string.Format(",visitorCenter = {0} ", visitorCenter);
            strSql += string.Format(",automaticDispenser = {0} ", automaticDispenser);
            strSql += string.Format(",lactationRoom = {0} ", lactationRoom);
            strSql += string.Format(",locker = {0} ", locker);
            strSql += string.Format(",lostCenter_Tel = '{0}' ", lostCenter_Tel);
            strSql += string.Format(",lostCenter_Url = '{0}' ", lostCenter_Url);
            strSql += string.Format("where stationID = '{0}' ", stationID);


            cmd = new SqlCommand(strSql, sqlConnect);
            cmd.CommandText = strSql;
            cmd.ExecuteNonQuery();

            strSql = string.Format("insert AID_TOOL.dbo.[TBSubway_History]   ");
            strSql += string.Format("values('{0}','TBSubwayFacility',{1},'{2}','',getdate(),'{3}')", StaticMain.userName,stationID, namekor, log);
           
            cmd = new SqlCommand(strSql, sqlConnect);
            cmd.CommandText = strSql;
            cmd.ExecuteNonQuery();

            //연결종료
            sqlConnect.Close();
        }

        public bool CheckFacility(long stationID, string namekor, int lostCenter, int bicycleRack, int transferParking, int stationOffice, int publicOffice,
            int ticket, int disabledToilet, int elevator, int wheelChairLift, int visitorCenter, int automaticDispenser, int lactationRoom, int locker, string lostCenter_Tel, string lostCenter_Url)
        {

            bool result = false;

            Connect();

            string strSql = "";


            strSql = string.Format("select * from Naverodsay.dbo.TBSubwayFacility where ");
            strSql += string.Format("stationID = '{0}' ", stationID);
            strSql += string.Format("and lostCenter = {0} ", lostCenter);
            strSql += string.Format("and bicycleRack = {0} ", bicycleRack);
            strSql += string.Format("and transferParking = {0} ", transferParking);
            strSql += string.Format("and stationOffice = {0} ", stationOffice);
            strSql += string.Format("and publicOffice = {0} ", publicOffice);
            strSql += string.Format("and ticket = {0} ", ticket);
            strSql += string.Format("and disabledToilet = {0} ", disabledToilet);
            strSql += string.Format("and elevator = {0} ", elevator);
            strSql += string.Format("and wheelChairLift = {0} ", wheelChairLift);
            strSql += string.Format("and visitorCenter = {0} ", visitorCenter);
            strSql += string.Format("and automaticDispenser = {0} ", automaticDispenser);
            strSql += string.Format("and lactationRoom = {0} ", lactationRoom);
            strSql += string.Format("and locker = {0} ", locker);
            strSql += string.Format("and lostCenter_Tel = '{0}' ", lostCenter_Tel);
            strSql += string.Format("and lostCenter_Url = '{0}' ", lostCenter_Url);
            


            cmd = new SqlCommand(strSql, sqlConnect);
            SqlDataReader reader = cmd.ExecuteReader();

            result = reader.Read();

            //연결종료
            reader.Close();
            sqlConnect.Close();

            return result;
        }



        public void GetGateLink(long stationID, string gateNo)
        {
            Connect();

            string strSql = "";

            if (gateNo == "")
            {
                strSql = string.Format("delete TBSubwayGateLink_Sub");

                cmd = new SqlCommand(strSql, sqlConnect);
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();

                strSql = string.Format("insert into [TBSubwayGateLink_Sub]" +
                    " select * from Naverodsay.dbo.TBSubwayGateLink " +
                    "     where (ssid in (    " +
                    "       select b.SsID  from naverodsay.dbo.TBSubwayGate as a   " +
                    "           join naverodsay.dbo.TBSubwayGate as b  " +
                    "           on a.X = b.X and a.Y = b.Y and a.SsID <> b.SsID and a.SsID = {0} " +
                    "               union select {0} ) )", stationID);

                cmd = new SqlCommand(strSql, sqlConnect);
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();
            }


            strSql = string.Format("select * from TBSubwayGateLink_Sub where ssid = {0} ", stationID);

            if(gateNo != "" && gateNo != "전체")
                strSql += string.Format(" and GateNo = '{0}' ", gateNo);

            strSql += string.Format(" order by ssid,Convert(int,case when CHARINDEX('-',gateno) > 0 then SUBSTRING(gateno,0,CHARINDEX('-',gateno)) else GateNo end)");

            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            StaticSubway.gateLink.Clear();
            StaticSubway.gateLinks.Clear();

            while (reader.Read())
            {

                StaticSubway.gateLink.Add(reader["SSID"].ToString());
                StaticSubway.gateLink.Add(reader["GateNo"].ToString());
                StaticSubway.gateLink.Add(reader["Idx"].ToString());
                StaticSubway.gateLink.Add(reader["CityCode"].ToString());
                StaticSubway.gateLink.Add(reader["LinkKor"].ToString());
                StaticSubway.gateLink.Add(reader["NameKor"].ToString());
 

                StaticSubway.gateLinks.Add(StaticSubway.gateLink.ToList());
                StaticSubway.gateLink.Clear();


            }

            //연결종료
            reader.Close();
            sqlConnect.Close();
        }

        public bool setGateLinkAdd(long stationID, string gateNo, string linkKor)
        {
            bool result = false;

            Connect();

            string strSql = "";

            strSql = string.Format("select * from TBSubwayGateLink_Sub where ssid = {0} and gateNo = '{1}' and linkkor = '{2}'", stationID, gateNo, linkKor);


            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
                return result;

            reader.Close();

            strSql = string.Format("insert into TBSubwayGateLink_Sub " +
                "select distinct SSID,'{1}',(select count(idx) from TBSubwayGateLink_Sub where ssid = {0} and GateNo = '{1}' ) as idx," +
                "CityCode,'{2}',NameKor from TBSubwayGateLink_Sub ", stationID, gateNo, linkKor);


            cmd = new SqlCommand(strSql, sqlConnect);
            cmd.CommandText = strSql;
            cmd.ExecuteNonQuery();

            sqlConnect.Close();

            return result = true;

        }

        public bool CheckGateLink()
        {
            bool result = false;

            Connect();

            string strSql = "";

            strSql = string.Format("select * from TBSubwayGateLink_Sub as a " +
                                    " full join " +
                                    "     (select* from Naverodsay.dbo.TBSubwayGateLink where ssid in (select ssid from TBSubwayGateLink_Sub)) as b " +
                                    " on a.SsID = b.SsID and a.GateNo = b.GateNo and a.Idx = b.Idx " +
                                    " where(a.SsID = b.SsID and a.GateNo = b.GateNo and a.Idx = b.Idx and a.LinkKor <> b.LinkKor) " +
                                    " or(b.Idx is null) or(a.Idx is null) ");

            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();


            result = reader.Read();

            reader.Close();

            sqlConnect.Close();

            return result;
        }

        public void setGateLinkAlter(long stationID, string gateNo ,int idx, string linkKor, string nameKor)
        {
            Connect();

            string strSql = "";

            strSql = string.Format("update TBSubwayGateLink_Sub set linkkor = '{3}' where gateNo = '{1}' and idx = {2} ", stationID, gateNo, idx, linkKor);

            cmd = new SqlCommand(strSql, sqlConnect);
            cmd.CommandText = strSql;
            cmd.ExecuteNonQuery();


            sqlConnect.Close();

        }

        public bool delGateLink(long stationID, string gateNo, int idx)
        {

            Connect();

            bool result = false;
            string strSql = "";
            int index = -1;

            if (idx == -1)
            {
                strSql = string.Format("delete TBSubwayGateLink_Sub where GateNo = '{1}' and idx <> 0", stationID, gateNo);

                cmd = new SqlCommand(strSql, sqlConnect);
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();

                result = true;
            }
            else
            {
                strSql = string.Format("select count(idx) as idx from TBSubwayGateLink_Sub where ssid = {0} and GateNo = '{1}'", stationID, gateNo);
                cmd = new SqlCommand(strSql, sqlConnect);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    index = Convert.ToInt16(reader["idx"].ToString());
                    reader.Close();
                }

                if (index > 1)
                {
                    strSql = string.Format("delete TBSubwayGateLink_Sub where GateNo = '{1}' and idx = {2}", stationID, gateNo,idx);

                    cmd = new SqlCommand(strSql, sqlConnect);
                    cmd.CommandText = strSql;
                    cmd.ExecuteNonQuery();

                    strSql = string.Format("update TBSubwayGateLink_Sub set idx = idx-1  where  gateNo = '{1}' and idx > {2}", stationID,gateNo,idx);

                    cmd = new SqlCommand(strSql, sqlConnect);
                    cmd.CommandText = strSql;
                    cmd.ExecuteNonQuery();

                    result = true;
                }

            }
               
            sqlConnect.Close();

            return result;
        }

        public void applyGateLink(List<List<string>> strLog)
        {

            Connect();


            string strSql = "";

            strSql = string.Format("delete Naverodsay.dbo.TBSubwayGateLink where ssid in(select distinct ssid from TBSubwayGateLink_Sub)");

            cmd = new SqlCommand(strSql, sqlConnect);
            cmd.CommandText = strSql;
            cmd.ExecuteNonQuery();


            strSql = string.Format("insert into Naverodsay.dbo.TBSubwayGateLink select * from TBSubwayGateLink_Sub");

            cmd = new SqlCommand(strSql, sqlConnect);
            cmd.CommandText = strSql;
            cmd.ExecuteNonQuery();

            for(int i = 0; i < strLog.Count; i++)
            {
                strSql = string.Format("insert AID_TOOL.dbo.[TBSubway_History]   ");
                strSql += string.Format("values('{0}','TBSubwayGateLink',{1},'{2}','{3}',getdate(),'{4}')", StaticMain.userName,strLog[i][0], strLog[i][1], strLog[i][2], strLog[i][3]);
                

                cmd = new SqlCommand(strSql, sqlConnect);
                cmd.CommandText = strSql;
                cmd.ExecuteNonQuery();

            }

            sqlConnect.Close();


        }

        public void TransferLaneType(long stationID)
        {
            Connect();

            string strSql = "";

            strSql = string.Format("select distinct case when Direction is null then LaneName else LaneName+'('+Direction+')' end as LaneName ,LaneID from Naverodsay.dbo.TBSubwayType where LaneId in ( " +
                "                   select distinct slid2 from naverpubtrans_aro.dbo.TBSubwayExchange  where ssid1 = {0})", stationID);

            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            StaticSubway.laneType2.Clear();
            StaticSubway.laneTypes2.Clear();

            while (reader.Read())
            {

                StaticSubway.laneType2.Add(reader["LaneName"].ToString());
                StaticSubway.laneType2.Add(reader["LaneID"].ToString());

                StaticSubway.laneTypes2.Add(StaticSubway.laneType2.ToList());
                StaticSubway.laneType2.Clear();

            }

            //연결종료
            reader.Close();
            sqlConnect.Close();
        }

        public void GetSubwayExchange(long stationID)
        {
            Connect();

            string strSql = "";


            strSql = string.Format("select distinct ssid1,b.LaneName as LaneName1  ,namekor,ssid2,c.LaneName as LaneName2 , namekor2,isnull(exchangeTime1,0) as exchangeTime1,isnull(exchangeTime2,0) as exchangeTime2,isnull(exchangeTime3,0) as exchangeTime3,isnull(exchangeTime4,0) as exchangeTime4," +
                "fastextrain1,fastexdoor1, fastextrain2,fastexdoor2,fastextrain3,fastexdoor3,fastextrain4,fastexdoor4" +
                " from ( " +
                "       select * from naverpubtrans_aro.dbo.TBSubwayExchange  " +
                "       where " +
                "           ssid1 in ( select ssid1 from naverpubtrans_aro.dbo.TBSubwayExchange  where ssid1  = {0} or ssid2 = {0})) as a " +
                "       join ( select * from Naverodsay.dbo.TBSubwayType ) as b" +
                "     	on a.slid1 = b.LaneId" +
                "       join (select * from Naverodsay.dbo.TBsubwayType ) as c" +
                "       on a.slid2 = c.LaneId", stationID);
            



            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            StaticSubway.station.Clear();
            StaticSubway.stations.Clear();

            while (reader.Read())
            {

                //StaticSubway.station.Add(reader["slid1"].ToString());
                StaticSubway.station.Add(reader["ssid1"].ToString());
                StaticSubway.station.Add(reader["namekor"].ToString());
                StaticSubway.station.Add(reader["LaneName1"].ToString());

                //StaticSubway.station.Add(reader["slid2"].ToString());
                StaticSubway.station.Add(reader["ssid2"].ToString());
                StaticSubway.station.Add(reader["namekor2"].ToString());
                StaticSubway.station.Add(reader["LaneName2"].ToString());

                StaticSubway.station.Add(reader["exchangetime1"].ToString());
                StaticSubway.station.Add(reader["exchangetime2"].ToString());
                StaticSubway.station.Add(reader["exchangetime3"].ToString());
                StaticSubway.station.Add(reader["exchangetime4"].ToString());

                StaticSubway.station.Add(reader["fastextrain1"].ToString());
                StaticSubway.station.Add(reader["fastexdoor1"].ToString());
                StaticSubway.station.Add(reader["fastextrain2"].ToString());
                StaticSubway.station.Add(reader["fastexdoor2"].ToString());
                StaticSubway.station.Add(reader["fastextrain3"].ToString());
                StaticSubway.station.Add(reader["fastexdoor3"].ToString());
                StaticSubway.station.Add(reader["fastextrain4"].ToString());
                StaticSubway.station.Add(reader["fastexdoor4"].ToString());


                StaticSubway.stations.Add(StaticSubway.station.ToList());
                StaticSubway.station.Clear();

            }

            //연결종료
            reader.Close();
            sqlConnect.Close();
        }

        public void setSubwayExchange(string stationID1, string stationID2, string namekor,string exchangeTime1, string exchangeTime2, string exchangeTime3, string exchangeTime4,
            string fastextrain1, string fastexdoor1, string fastextrain2, string fastexdoor2, string fastextrain3,
            string fastexdoor3, string fastextrain4, string fastexdoor4, string log, string exchangeTime)
        {
            Connect();

            string strSql = "";

            strSql = string.Format("exec table_backup.dbo.usp_C003_01_SubwayExchange_BackUp");


            cmd = new SqlCommand(strSql, sqlConnect);
            cmd.CommandText = strSql;
            cmd.ExecuteNonQuery();

            strSql = string.Format("update naverpubtrans_aro.dbo.TBSubwayExchange set " +
                    "exchangeTime1 = {2}" +
                    ",exchangeTime2 = {3}" +
                    ",exchangeTime3 = {4}" +
                    ",exchangeTime4 = {5}" +
                    ",fastextrain1 = {6} " +
                    ",fastexdoor1= {7} " +
                    ",fastextrain2 = {8}	" +
                    ",fastexdoor2 = {9}" +
                    ",fastextrain3= {10}" +
                    ",fastexdoor3 = {11}" +
                    ",fastextrain4= {12}" +
                    ",fastexdoor4= {13}" +
                    ",exchangeTime = {14} " +
                    "where ssid1 = {0} and ssid2 = {1}", stationID1, stationID2, exchangeTime1, exchangeTime2, exchangeTime3, exchangeTime4, fastextrain1, fastexdoor1, fastextrain2, fastexdoor2, fastextrain3, fastexdoor3, fastextrain4, fastexdoor4, exchangeTime);
            

            cmd = new SqlCommand(strSql, sqlConnect);
            cmd.CommandText = strSql;
            cmd.ExecuteNonQuery();


            strSql = string.Format("exec naverpubtrans_aro.dbo.usp_B003_01_SubwayExchange_Modify ");

            cmd = new SqlCommand(strSql, sqlConnect);
            cmd.CommandText = strSql;
            cmd.ExecuteNonQuery();


            strSql = string.Format("insert AID_TOOL.dbo.[TBSubway_History]   ");
            strSql += string.Format("values('{0}','TBSubwayExchange',{1},'{2}','',getdate(),'{3}')", StaticMain.userName, stationID1, namekor, log);



            cmd = new SqlCommand(strSql, sqlConnect);
            cmd.CommandText = strSql;
            cmd.ExecuteNonQuery();


            sqlConnect.Close();
        }

        public void GetSubwayExitLink(long stationID)
        {
            Connect();

            string strSql = "";


            strSql = string.Format("select distinct StationId,Direction,Duration,ExitNo,train,door,train2,door2 from" +
                " naverpubtrans_aro.[dbo].[NSubwayExitLink] where stationid = {0} order by Direction,ExitNo", stationID);

            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();


            StaticSubway.exitLink.Clear();
            StaticSubway.exitLinks.Clear();

            while (reader.Read())
            {

                //StaticSubway.exitLink.Add(reader["SubwayLaneid"].ToString());
                StaticSubway.exitLink.Add(reader["Stationid"].ToString());

                if (reader["Direction"].ToString() == "0")
                    StaticSubway.exitLink.Add("하행");
                else
                    StaticSubway.exitLink.Add("상행");

                StaticSubway.exitLink.Add(reader["Duration"].ToString());
                StaticSubway.exitLink.Add(reader["ExitNo"].ToString());
                StaticSubway.exitLink.Add(reader["train"].ToString());
                StaticSubway.exitLink.Add(reader["door"].ToString());
                StaticSubway.exitLink.Add(reader["train2"].ToString());
                StaticSubway.exitLink.Add(reader["door2"].ToString());

                StaticSubway.exitLinks.Add(StaticSubway.exitLink.ToList());
                StaticSubway.exitLink.Clear();
            }

            //연결종료
            reader.Close();
            sqlConnect.Close();
        }

    }
}
