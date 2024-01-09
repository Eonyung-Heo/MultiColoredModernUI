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
using System.Diagnostics;

namespace MultiColoredModernUI.Forms.Ship
{
    public partial class ShipAdd : Form
    {
        public ShipAdd()
        {
            InitializeComponent();
            Ship_HarborSE_CB();
        }

        //db 관련함수
        SqlDataReader dr;
        SqlConnection sqlConnect;
        SqlCommand cmd;

        //SQL접속
        public void Connect()
        {
            // db접속정보
            sqlConnect = new SqlConnection("Server = 218.234.32.194,5242; Database = NEW_SHIP; uid = sa; pwd = yasdo12!@; MultipleActiveResultSets = True");
            //sqlConnect = new SqlConnection("Server = 218.234.32.245,5242; Database = TEST_Choi; uid = aro_choi; pwd = 1q2w3e4r!; MultipleActiveResultSets = True");

            sqlConnect.Open();
        }

        //텍스트박스 초기화 코드
        private void Ship_Clear_BT_Clear()
        {
            if (Ship_Add_TabControl.SelectedTab == Ship_Harbor_page)
            {
                Ship_OdsayID_TB.Text = string.Empty;
                Ship_PortID_TB.Text = string.Empty;
                Ship_CityCode_TB.Text = string.Empty;
                Ship_Harbor1_TB.Text = string.Empty;
                Ship_Harbor2_TB.Text = string.Empty;
                Ship_Harbor3_TB.Text = string.Empty;
                Ship_Area_TB.Text = string.Empty;
                Ship_X_TB.Text = string.Empty;
                Ship_Y_TB.Text = string.Empty;
                Ship_WGS84_X_TB.Text = string.Empty;
                Ship_WGS84_Y_TB.Text = string.Empty;
                Ship_Addr_TB.Text = string.Empty;
            }
            else if (Ship_Add_TabControl.SelectedTab == Ship_ShipCompany_page)
            {
                Ship_BusinessNum_TB.Text = string.Empty;
                Ship_ShipCompanyName_TB.Text = string.Empty;
                Ship_ShipCompanyNum_TB.Text = string.Empty;
                Ship_ShipName_TB.Text = string.Empty;
                Ship_ShipType_TB.Text = string.Empty;
                Ship_ShipCapacity_TB.Text = string.Empty;
                Ship_ShipCar_CB.SelectedItem = null;
                Ship_ShipCarNum_TB.Text = string.Empty;
                Ship_ShipRoute_TB.Text = string.Empty;
                Ship_ShipKnot_TB.Text = string.Empty;
                Ship_ShipCompanyDate_TB.Text = string.Empty;
                Ship_ShipCompanyID_TB.Text = string.Empty;
                Ship_ShipURL_TB.Text = string.Empty;
                Ship_ShipAddress_TB.Text = string.Empty;
            }
            else if (Ship_Add_TabControl.SelectedTab == Ship_Route_page)
            {
                Ship_RouteID_TB.Text = string.Empty;
                Ship_HarborSE_TB.Text = string.Empty;
                Ship_Sortation_CB.SelectedItem = null;
                Ship_HarborSID_TB.Text = string.Empty;
                Ship_HarborEID_TB.Text = string.Empty;
                Ship_HarborS_TB.Text = string.Empty;
                Ship_HarborE_TB.Text = string.Empty;
                Ship_ShipSortation_TB.Text = string.Empty;
                Ship_ShipRouteOdsayIDS_TB.Text = string.Empty;
                Ship_ShipRouteOdsayIDE_TB.Text = string.Empty;
                Ship_DetailedHarborName_S_TB.Text = string.Empty;
                Ship_DetailedHarborName_E_TB.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("탭 선택 오류입니다.");
            }
        }

        private void Ship_Clear_BT_Click(object sender, EventArgs e)
        {
            Ship_Clear_BT_Clear();
        }

        private void Ship_XYMap_Bt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tablog.neocities.org/keywordposition");
        }

        public void Ship_HarborSE_CB()
        {
            Connect();
            //string strSql_Lane = "select * from NEW_SHIP.dbo.TBShipLane order by ODSayLaneID asc";
            string strSql_Harbor = "select * from NEW_SHIP.dbo.TBHarbor order by ODSayHarborID asc";
            SqlCommand cmd_Harbor = new SqlCommand(strSql_Harbor, sqlConnect);
            SqlDataReader sdt = cmd_Harbor.ExecuteReader();
            while (sdt.Read())
            {
                Ship_RouteAdd_DG.Rows.Add(sdt[0], sdt[1], sdt[3], sdt[4], sdt[5], sdt[10]);
            }

            sqlConnect.Close();
        }

        private void Ship_RouteAdd_DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // 출발지/도착지 선택 여부 확인
            DialogResult result = MessageBox.Show("출발지로 선택하시겠습니까?", "선택", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // 사용자의 선택에 따라 동작
            if (result == DialogResult.Yes)
            {
                Ship_HarborS_TB.Clear();
                Ship_HarborSID_TB.Clear();
                Ship_ShipRouteOdsayIDS_TB.Clear();
                Ship_DetailedHarborName_S_TB.Clear();

                int index = 0;
                index = e.RowIndex;

                Ship_HarborS_TB.Text = Ship_RouteAdd_DG.Rows[index].Cells[2].Value.ToString();
                Ship_HarborSID_TB.Text = Ship_RouteAdd_DG.Rows[index].Cells[1].Value.ToString();
                Ship_ShipRouteOdsayIDS_TB.Text = Ship_RouteAdd_DG.Rows[index].Cells[0].Value.ToString();
                Ship_DetailedHarborName_S_TB.Text = Ship_RouteAdd_DG.Rows[index].Cells[5].Value.ToString();

                MessageBox.Show("출발지를 선택했습니다.");
            }
            else
            {
                Ship_HarborE_TB.Clear();
                Ship_HarborEID_TB.Clear();
                Ship_ShipRouteOdsayIDE_TB.Clear();
                Ship_DetailedHarborName_E_TB.Clear();

                int index = 0;
                index = e.RowIndex;

                Ship_HarborE_TB.Text = Ship_RouteAdd_DG.Rows[index].Cells[2].Value.ToString();
                Ship_HarborEID_TB.Text = Ship_RouteAdd_DG.Rows[index].Cells[1].Value.ToString();
                Ship_ShipRouteOdsayIDE_TB.Text = Ship_RouteAdd_DG.Rows[index].Cells[0].Value.ToString();
                Ship_DetailedHarborName_E_TB.Text = Ship_RouteAdd_DG.Rows[index].Cells[5].Value.ToString();

                MessageBox.Show("도착지를 선택했습니다.");
            }
            /*
            Ship_CompanyName_TB.Clear();
            Ship_ShipName2_TB.Clear();
            Ship_StartTime_TB.Clear();
            Ship_Timerequired_TB.Clear();
            Ship_Rank2_TB.Clear();
            Ship_AdultFee_TB.Clear();
            Ship_YouthFee_TB.Clear();
            Ship_SeniorFee_TB.Clear();
            Ship_ChildFee_TB.Clear();

            int index = 0;
            index = e.RowIndex;

            Ship_CompanyName_TB.Text = Ship_DataGridViewData_Fee_DG.Rows[index].Cells[0].Value.ToString();
            Ship_ShipName2_TB.Text = Ship_DataGridViewData_Fee_DG.Rows[index].Cells[1].Value.ToString();
            Ship_StartTime_TB.Text = Ship_DataGridViewData_Fee_DG.Rows[index].Cells[2].Value.ToString();
            Ship_Timerequired_TB.Text = Ship_DataGridViewData_Fee_DG.Rows[index].Cells[3].Value.ToString();
            Ship_Rank2_TB.Text = Ship_DataGridViewData_Fee_DG.Rows[index].Cells[4].Value.ToString();
            Ship_AdultFee_TB.Text = Ship_DataGridViewData_Fee_DG.Rows[index].Cells[5].Value.ToString();
            Ship_YouthFee_TB.Text = Ship_DataGridViewData_Fee_DG.Rows[index].Cells[6].Value.ToString();
            Ship_SeniorFee_TB.Text = Ship_DataGridViewData_Fee_DG.Rows[index].Cells[7].Value.ToString();
            Ship_ChildFee_TB.Text = Ship_DataGridViewData_Fee_DG.Rows[index].Cells[8].Value.ToString();
            */
        }

        // 저장 버튼 클릭시 보여지는 패널에 맞게 코드를 활성화하며
        // 저장이 시작됨에 따라 ID를 부여하여 값을 입력넣는다.
        private void Ship_Update_BT_Click(object sender, EventArgs e)
        {
            Connect();
            string textquery = string.Empty;

            // 항구 파트 이면 저장하기는 이걸 실행한다.
            if (Ship_Add_TabControl.SelectedTab == Ship_Harbor_page)
            {
                string strSql_NEWodsayID1 = "select next VALUE for TBHarborODSAYID";
                string strSql_NEWID1 = "select next VALUE for TBHarborID";
                //string queryInsert = "INSERT INTO TEST_Choi.dbo.";
                string queryInsert = "INSERT INTO NEW_SHIP.dbo.";
                //textquery = "CHOI_HARBOR VALUES (@ODSayHarborID, @ID, @Area, @HarborName, @HarborName2, @HarborName3, @X, @Y, @WGS84_X, @WGS84_Y, @Addr, @CityCode, getdate(), getdate())";
                textquery = "TBHarbor VALUES (@ODSayHarborID, @ID, @Area, @HarborName, @HarborName2, @HarborName3, @X, @Y, @WGS84_X, @WGS84_Y, @Addr, @CityCode, getdate(), getdate())";
                string queryString = queryInsert + textquery;

                SqlCommand cmd_NEWID1 = new SqlCommand(strSql_NEWodsayID1, sqlConnect);
                SqlCommand cmd_NEWID2 = new SqlCommand(strSql_NEWID1, sqlConnect);
                SqlDataReader dt1 = cmd_NEWID1.ExecuteReader();
                SqlDataReader dt2 = cmd_NEWID2.ExecuteReader();
                SqlCommand cmd_command = new SqlCommand(queryString, sqlConnect);

                // 노선에서 경로ID추출
                if (dt1.Read())
                {
                    Ship_PortID_TB.Text = dt1[0].ToString();
                }
                if (dt2.Read())
                {
                    Ship_OdsayID_TB.Text = "A" + dt2[0].ToString().PadLeft(4, '0');
                }
                try
                {
                    cmd_command.Parameters.Clear();
                    cmd_command.Parameters.AddWithValue("@ODSayHarborID", Ship_OdsayID_TB.Text);
                    cmd_command.Parameters.AddWithValue("@ID", Ship_PortID_TB.Text);
                    cmd_command.Parameters.AddWithValue("@Area", Ship_Area_TB.Text);
                    cmd_command.Parameters.AddWithValue("@HarborName", Ship_Harbor1_TB.Text);
                    cmd_command.Parameters.AddWithValue("@HarborName2", Ship_Harbor2_TB.Text);
                    cmd_command.Parameters.AddWithValue("@HarborName3", Ship_Harbor3_TB.Text);
                    cmd_command.Parameters.AddWithValue("@X", Ship_X_TB.Text);
                    cmd_command.Parameters.AddWithValue("@Y", Ship_Y_TB.Text);
                    cmd_command.Parameters.AddWithValue("@WGS84_X", Ship_WGS84_X_TB.Text);
                    cmd_command.Parameters.AddWithValue("@WGS84_Y", Ship_WGS84_Y_TB.Text);
                    cmd_command.Parameters.AddWithValue("@Addr", Ship_Addr_TB.Text);
                    cmd_command.Parameters.AddWithValue("@CityCode", Ship_CityCode_TB.Text); // ?

                    //string TT = queryString;

                    int rowsAffected = cmd_command.ExecuteNonQuery();
                    MessageBox.Show("저장 완료되었습니다");
                }
                catch (Exception exc)
                {
                    Trace.WriteLine(exc.Message);
                }
                finally
                {
                    sqlConnect.Close();
                }
            }
            // 해운 파트 이면 저장하기는 이걸 실행한다.
            else if (Ship_Add_TabControl.SelectedTab == Ship_ShipCompany_page)
            {
                string strSql_NEWID2 = "select next VALUE for TBShipCompanyID";
                //string queryInsert = "INSERT INTO TEST_Choi.dbo.";
                string queryInsert = "INSERT INTO NEW_SHIP.dbo.";
                //textquery = "CHOI_ShipCompany VALUES (@ODSayShipCompanyID, @ShipCompanyNo, @ShipCompanyName, @Tel, @ShipName, @ShipType, @Addr ,@Personnel, @ShipVehiclesYN, @ShipVehiclesCnt, @OperationRange, @Speed, @ShipCompanyDate, @URL, @DelYN, getdate(), getdate())";
                textquery = "TBShipCompany VALUES (@ODSayShipCompanyID, @ShipCompanyNo, @ShipCompanyName, @Tel, @ShipName, @ShipType, @Addr ,@Personnel, @ShipVehiclesYN, @ShipVehiclesCnt, @OperationRange, @Speed, @ShipCompanyDate, @URL, @DelYN, getdate(), getdate())";
                string queryString = queryInsert + textquery;

                SqlCommand cmd_NEWID2 = new SqlCommand(strSql_NEWID2, sqlConnect);
                SqlDataReader dt = cmd_NEWID2.ExecuteReader();
                SqlCommand cmd_command = new SqlCommand(queryString, sqlConnect);

                // 노선에서 경로ID추출
                if (dt.Read())
                {
                    Ship_ShipCompanyID_TB.Text = dt[0].ToString();
                }
                try
                {
                    cmd_command.Parameters.Clear();
                    cmd_command.Parameters.AddWithValue("@ODSayShipCompanyID", Ship_ShipCompanyID_TB.Text);
                    cmd_command.Parameters.AddWithValue("@ShipCompanyNo", Ship_BusinessNum_TB.Text);
                    cmd_command.Parameters.AddWithValue("@ShipCompanyName", Ship_ShipCompanyName_TB.Text);
                    cmd_command.Parameters.AddWithValue("@Tel", Ship_ShipCompanyNum_TB.Text);
                    cmd_command.Parameters.AddWithValue("@ShipName", Ship_ShipName_TB.Text);
                    cmd_command.Parameters.AddWithValue("@ShipType", Ship_ShipType_TB.Text);
                    cmd_command.Parameters.AddWithValue("@Addr", Ship_ShipAddress_TB.Text);
                    cmd_command.Parameters.AddWithValue("@Personnel", Ship_ShipCapacity_TB.Text);
                    cmd_command.Parameters.AddWithValue("@ShipVehiclesYN", Ship_ShipCar_CB.Text); // 콤보박스 변환
                    cmd_command.Parameters.AddWithValue("@ShipVehiclesCnt", Ship_ShipCarNum_TB.Text);
                    cmd_command.Parameters.AddWithValue("@OperationRange", Ship_ShipRoute_TB.Text);
                    cmd_command.Parameters.AddWithValue("@Speed", Ship_ShipKnot_TB.Text);
                    cmd_command.Parameters.AddWithValue("@ShipCompanyDate", Ship_ShipCompanyDate_TB.Text);
                    cmd_command.Parameters.AddWithValue("@URL", Ship_ShipURL_TB.Text);
                    cmd_command.Parameters.AddWithValue("@DelYN", "N");

                    string TT = queryString;

                    int rowsAffected = cmd_command.ExecuteNonQuery();
                    MessageBox.Show("저장 완료되었습니다");
                }
                catch (Exception exc)
                {
                    Trace.WriteLine(exc.Message);
                }
                finally
                {
                    sqlConnect.Close();
                }
            }
            // 노선 파트 이면 저장하기는 이걸 실행한다.
            else if (Ship_Add_TabControl.SelectedTab == Ship_Route_page)
            {
                string strSql_NEWID3 = "select next VALUE for shiplaneID";
                string queryInsert = "INSERT INTO NEW_SHIP.dbo.";
                textquery = "TBShipLane VALUES (@ODSayLaneID, @IndexedSearch, @IndexedSearch2, @SelectedInfo, @ODSayHarborID_S, @ODSayHarborID_E, @Harbor_ID_S, @Harbor_ID_E, @Harbor_Name_S, @Harbor_Name_E, @Harbor_Name_SE, @DelYN, @ImportantYN, getdate(), getdate())";
                string queryString = queryInsert + textquery;

                SqlCommand cmd_NEWID3 = new SqlCommand(strSql_NEWID3, sqlConnect);
                SqlDataReader dt = cmd_NEWID3.ExecuteReader();
                SqlCommand cmd_command = new SqlCommand(queryString, sqlConnect);

                // 노선에서 경로ID추출
                if (dt.Read())
                {
                    Ship_RouteID_TB.Text = dt[0].ToString();
                }
                try
                {
                    cmd_command.Parameters.Clear();
                    cmd_command.Parameters.AddWithValue("@ODSayLaneID", Ship_RouteID_TB.Text);
                    cmd_command.Parameters.AddWithValue("@IndexedSearch", Ship_Sortation_CB.Text);
                    cmd_command.Parameters.AddWithValue("@IndexedSearch2", Ship_ShipSortation_TB.Text);
                    cmd_command.Parameters.AddWithValue("@SelectedInfo", null); // 얘는 뭐지?
                    cmd_command.Parameters.AddWithValue("@ODSayHarborID_S", Ship_ShipRouteOdsayIDS_TB.Text);
                    cmd_command.Parameters.AddWithValue("@ODSayHarborID_E", Ship_ShipRouteOdsayIDE_TB.Text);
                    cmd_command.Parameters.AddWithValue("@Harbor_ID_S", Ship_HarborSID_TB.Text);
                    cmd_command.Parameters.AddWithValue("@Harbor_ID_E", Ship_HarborEID_TB.Text);
                    cmd_command.Parameters.AddWithValue("@Harbor_Name_S", Ship_HarborS_TB.Text);
                    cmd_command.Parameters.AddWithValue("@Harbor_Name_E", Ship_HarborE_TB.Text);
                    cmd_command.Parameters.AddWithValue("@Harbor_Name_SE", Ship_HarborSE_TB.Text);
                    cmd_command.Parameters.AddWithValue("@DelYN", "N");
                    cmd_command.Parameters.AddWithValue("@ImportantYN", "N");

                    int rowsAffected = cmd_command.ExecuteNonQuery();
                    MessageBox.Show("저장 완료되었습니다");
                }
                catch (Exception exc)
                {
                    Trace.WriteLine(exc.Message);
                }
                finally
                {
                    sqlConnect.Close();
                }

            }
            else
            {
                MessageBox.Show("쿼리가 확실하지 않습니다");
            }

            sqlConnect.Close();

        }

    }
}
