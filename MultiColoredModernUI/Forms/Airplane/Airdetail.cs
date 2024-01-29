using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.IO;

namespace MultiColoredModernUI.Forms.Airplane
{
    public partial class AirDetail : Form
    {
        public int i;
        string fileName;

        //db 관련함수
        SqlDataReader dr;
        SqlConnection sqlConnect;
        SqlCommand cmd;
        public AirDetail()
        {
            InitializeComponent();
            selectAirPlane();
            selectAirCompanyDifferenceData();
            selectAirRouteDifferenceData();
            selectNewData();
            selectDeleteData();
        }
        private void Connect()
        {
            // db접속정보
            sqlConnect = new SqlConnection("Server = 218.234.32.245,5242; Database = NaverOdsay_Dev_Sub; uid = sa; pwd = yasdo12!@; MultipleActiveResultSets = True");

            sqlConnect.Open();
        }

        public void selectAirPlane()
        {
            Connect();

            string strsql = "select * from NaverOdsay.dbo.TBInterCity_Airplane order by idx asc";

            cmd = new SqlCommand(strsql, sqlConnect);

            SqlDataReader dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                Air_AirplaneData_DG.Rows.Add(dt[0], dt[2], dt[3], dt[5], dt[6], dt[7], dt[9], dt[10], dt[12], dt[13], dt[15], dt[16]);
            }
            sqlConnect.Close();
        }

        public void selectAirCompanyDifferenceData()
        {
            Connect();

            string strsql = "select * from NaverOdsay_Dev_Sub.dbo.TBInterCity_Airplane_CompanyCountDifference order by Company asc";

            cmd = new SqlCommand(strsql, sqlConnect);

            SqlDataReader dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                Air_CompanyDifferenceData_DG.Rows.Add(dt[0], dt[1], dt[2], dt[3]);
            }
            sqlConnect.Close();
        }

        public void selectAirRouteDifferenceData()
        {
            Connect();

            string strsql = "select * from NaverOdsay_Dev_Sub.dbo.TBInterCity_Airplane_RouteCountDifference order by OriginID,DestinationID asc";

            cmd = new SqlCommand(strsql, sqlConnect);

            SqlDataReader dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                Air_RouteDifferenceData_DG.Rows.Add(dt[0], dt[2], dt[3], dt[5], dt[6], dt[7], dt[8]);
            }
            sqlConnect.Close();
        }

        public void selectNewData()
        {
            Connect();

            string strsql = "select * from NaverOdsay_Dev_Sub.dbo.TBInterCity_Airplane_Newedata";

            cmd = new SqlCommand(strsql, sqlConnect);

            SqlDataReader dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                Air_NewData_DG.Rows.Add(dt[0], dt[2], dt[3], dt[5], dt[6], dt[7], dt[9], dt[10], dt[12], dt[13], dt[15], dt[16]);
            }
            sqlConnect.Close();
        }

        public void selectDeleteData()
        {
            Connect();

            string strsql = "select * from NaverOdsay_Dev_Sub.dbo.TBInterCity_Airplane_Deletedata";

            cmd = new SqlCommand(strsql, sqlConnect);

            SqlDataReader dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                Air_DeleteData_DG.Rows.Add(dt[0], dt[2], dt[3], dt[5], dt[6], dt[7], dt[9], dt[10], dt[12], dt[13], dt[15], dt[16]);
            }
            sqlConnect.Close();
        }

        //프로시저 재실행
        private void Air_DataReFresh_BT_Click(object sender, EventArgs e)
        {
            EnabledFlase();
            Air_AirplaneData_DG.Rows.Clear();
            Air_CompanyDifferenceData_DG.Rows.Clear();
            Air_RouteDifferenceData_DG.Rows.Clear();
            Air_NewData_DG.Rows.Clear();
            Air_DeleteData_DG.Rows.Clear();
            
            Connect();
            string strsql = "exec NaverOdsay_Dev_Sub.dbo.sp_TBInterCity_Airplane_Difference";
            cmd = new SqlCommand(strsql, sqlConnect);
            cmd.CommandType = CommandType.Text;
            int rowsAffected = cmd.ExecuteNonQuery();
            sqlConnect.Close();

            selectAirPlane();
            selectAirCompanyDifferenceData();
            selectAirRouteDifferenceData();
            selectNewData();
            selectDeleteData();
            EnabledTrue();
        }

        private void Air_DataDownload_BT_Click(object sender, EventArgs e)
        {
            Air_SaveFileOpenFile();
            using (StreamWriter writer = new StreamWriter(fileName, false, Encoding.GetEncoding("utf-8")))
            {
                // 헤더를 CSV 파일에 추가
                List<string> headerList = new List<string>();
                foreach (DataGridViewColumn column in Air_AirplaneData_DG.Columns)
                {
                    headerList.Add(column.HeaderText);
                }
                writer.WriteLine(string.Join(",", headerList));

                int rowCount = Air_AirplaneData_DG.Rows.Count;

                if (Air_AirplaneData_DG.AllowUserToAddRows == true)
                {
                    rowCount = rowCount - 1;
                }

                for (int i = 0; i < rowCount; i++)
                {
                    //리스트 초기화
                    List<string> strList = new List<string>();

                    for (int j = 0; j < Air_AirplaneData_DG.Columns.Count; j++)
                    {
                        string value = Air_AirplaneData_DG[j, i].Value.ToString();
                        value = value.Replace(",", "");
                        strList.Add(value);
                    }
                    String[] strArray = strList.ToArray(); //배열로 변환
                    //CSV 형식으로 변환
                    String strCsvData = String.Join(",", strArray);
                    writer.WriteLine(strCsvData);
                }
                MessageBox.Show("저장완료 ");
                writer.Close();
            }
        }

        public void Air_SaveFileOpenFile()
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            // 다이얼 로그가 오픈되었을 때 최초의 경로 설정
            saveFile.InitialDirectory = @"C:";

            // 다이얼 로그의 제목
            saveFile.Title = "CSV 저장 위치 지정";

            // 기본 확장자
            saveFile.DefaultExt = "csv";

            // 파일 목록 필터링
            saveFile.Filter = "CSV files(*.csv) | *.csv";

            // ok버튼을 눌럿을대의 동작
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                // 경로와 파일명을 filename에 저장
                fileName = saveFile.FileName.ToString();
            }
        }

        public void EnabledTrue()
        {
            this.Invoke((MethodInvoker)delegate
            {
                Air_DataReFresh_BT.Enabled = true;
                Air_DataDownload_BT.Enabled = true;
            });
        }

        public void EnabledFlase()
        {
            this.Invoke((MethodInvoker)delegate
            {
                Air_DataReFresh_BT.Enabled = false;
                Air_DataDownload_BT.Enabled = false;
            });
        }
    }
}
