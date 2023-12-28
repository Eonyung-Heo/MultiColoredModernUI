using MultiColoredModernUI.Forms.Master;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiColoredModernUI
{
    class Mssql
    {

        SqlConnection sqlConnect;
        SqlCommand cmd;

        StaticMaster sta = new StaticMaster();

        public void Connect()
        {
            sqlConnect = new SqlConnection("Server=218.234.32.245,5242; Database=AID_TOOL; uid=sa; pwd=yasdo12!@");

            sqlConnect.Open();

        }

        public bool Login(string username , string mac)
        {
            bool check = false;

            Connect();

            string strSql = "";

            strSql = string.Format("select * from TBMembers  where username = '{0}' and macaddress = '{1}'", username, mac);

            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            check = reader.Read();

            //연결종료
            reader.Close();
            sqlConnect.Close();

            return check;

        }

        public string getName(string mac)
        {
            string name = "UserName";

            Connect();

            string strSql = "";

            strSql = string.Format("select UserName from TBMembers  where macaddress = '{0}'", mac);

            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
                name = reader["UserName"].ToString();

            //연결종료
            reader.Close();
            sqlConnect.Close();

            return name;

        }

        public void Members()
        {
            Connect();

            string strSql = "";

            strSql = string.Format("select * from TBMembers");

            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader reader = cmd.ExecuteReader();

            StaticMaster.members.Clear();
            StaticMaster.member.Clear();

            while (reader.Read())
            {
  
                StaticMaster.member.Add(reader["UserName"].ToString());
                StaticMaster.member.Add(reader["UserPwd"].ToString());
                StaticMaster.member.Add(reader["UserLevel"].ToString());
                StaticMaster.member.Add(reader["MacAddress"].ToString());
                StaticMaster.member.Add(reader["UseYN"].ToString());

                StaticMaster.members.Add(StaticMaster.member.ToList());
                StaticMaster.member.Clear();

            }

                //연결종료
            reader.Close();
            sqlConnect.Close();
        }

        public void MemberAdd()
        {

        }

        public void MemberAlter(string userName, string userPwd, int userLevel, string macAddress, string useYN)
        {
            string strSql = "";

            Connect();

            strSql = string.Format("update TBMembers set UserPwd = '{0}', UserLevel = {1}, MacAddress = '{2}', UseYN = '{3}' where UserName = '{4}'",userPwd,userLevel,macAddress,useYN,userName);

            cmd = new SqlCommand(strSql, sqlConnect);
            cmd.CommandText = strSql;
            cmd.ExecuteNonQuery();
            
            //연결종료
            sqlConnect.Close();
        }

        public void Log(string userName, string userMac, string log)
        {
            Connect();

            string strSql = "";

            strSql = string.Format("insert into TBToolLog values('{0}','{1}','{2}',getdate())", userName,userMac,log);
            cmd = new SqlCommand(strSql, sqlConnect);
            cmd.CommandText = strSql;
            cmd.ExecuteNonQuery();

            //연결종료
            sqlConnect.Close();
        }
    }
}
