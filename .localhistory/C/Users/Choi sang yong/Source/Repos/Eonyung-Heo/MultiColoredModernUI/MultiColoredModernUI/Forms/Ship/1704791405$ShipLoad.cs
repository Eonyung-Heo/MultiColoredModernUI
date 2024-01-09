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

namespace MultiColoredModernUI.Forms.Ship
{
    public partial class ShipLoad : Form
    {
        
        public int i;

        //db 관련함수
        SqlDataReader dr;
        SqlConnection sqlConnect;
        SqlCommand cmd;

        public ShipLoad()
        {
            InitializeComponent();
            selectODSayLaneID();
            selectODSayShipCompanyID();
            selectODSayShipStation();
            Ship_Sortation_CB.SelectedIndex = 0;// 구분 콤보박스 기본값 전체(index 0)로 설정
        }

        //SQL접속
        public void Connect()
        {
            // db접속정보
            sqlConnect = new SqlConnection("Server = 218.234.32.194,5242; Database = NEW_SHIP; uid = sa; pwd = yasdo12!@; MultipleActiveResultSets = True");

            sqlConnect.Open();
        }


        //ODSayLane 호출
        public void selectODSayLaneID()
        {
            Connect();

            string strSql = "select * from NEW_SHIP.dbo.TBShipLane";
            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                Ship_DataGridViewData_Route_DG.Rows.Add(dt[8], dt[9], dt[6], dt[7], dt[13], dt[14]);
            }

            sqlConnect.Close();


            //데이터를 불러오는 공간에 해당 코드를 넣으면 정렬화를 비활성화 가능(행헤더를 클릭시 오류나는거 방지)
            foreach (DataGridViewColumn column in Ship_DataGridViewData_Route_DG.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            Ship_DataGridViewData_Route_DG.CurrentCell = null;

        }

        //초기화 버튼
        private void Ship_Clear_BT_Click(object sender, EventArgs e)
        {
            Ship_Clear_BT_Clear();
        }


        //데이터 삭제 버튼
        private void Ship_Delete_BT_Delete()
        {
            Connect();


            if (Ship_Load_TabControl.SelectedTab == Ship_ShipCompany_page)
            {
                //string strSql = "select * from NEW_SHIP.dbo.TBShipLane";
                MessageBox.Show("삭제할 데이터가 없습니다.");
            }
            else if (Ship_Load_TabControl.SelectedTab == Ship_Route_page)
            {
                //string strSql = "select * from NEW_SHIP.dbo.TBShipLane";
                MessageBox.Show("삭제할 데이터가 없습니다.");
            }
            else if (Ship_Load_TabControl.SelectedTab == Ship_Station_page)
            {
                string DeleteSql = "delete NEW_SHIP.[dbo].[TBStation_Ship] where StationID = @StationID";
                cmd = new SqlCommand(DeleteSql, sqlConnect);
                cmd.Parameters.AddWithValue("@StationID", Ship_StationID_TB.Text);
                cmd.CommandText = DeleteSql;
                cmd.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("선택 오류입니다.");
            }

            sqlConnect.Close();
        }

        private void Ship_Clear_BT_Fee()
        {
            Ship_CompanyName_TB.Text = string.Empty;
            Ship_ShipName2_TB.Text = string.Empty;
            Ship_StartTime_TB.Text = string.Empty;
            Ship_Timerequired_TB.Text = string.Empty;
            Ship_Rank2_TB.Text = string.Empty;
            Ship_AdultFee_TB.Text = string.Empty;
            Ship_YouthFee_TB.Text = string.Empty;
            Ship_SeniorFee_TB.Text = string.Empty;
            Ship_ChildFee_TB.Text = string.Empty;
            Ship_DataGridViewData_Fee_DG.Rows.Clear();
        }
        //텍스트박스 초기화 코드
        private void Ship_Clear_BT_Clear()
        {
            if (Ship_Load_TabControl.SelectedTab == Ship_ShipCompany_page)
            {
                Ship_BusinessNum_TB.Text = string.Empty;
                Ship_ShipCompanyName_TB.Text = string.Empty;
                Ship_ShipCompanyNum_TB.Text = string.Empty;
                Ship_ShipName_TB.Text = string.Empty;
                Ship_ShipType_TB.Text = string.Empty;
                Ship_ShipCapacity_TB.Text = string.Empty;
                //Ship_ShipCar_CB.SelectedItem = null;
                Ship_ShipCarNum_TB.Text = string.Empty;
                Ship_ShipRoute_TB.Text = string.Empty;
                Ship_ShipKnot_TB.Text = string.Empty;
                Ship_ShipCompanyDate_TB.Text = string.Empty;
                Ship_ShipCompanyID_TB.Text = string.Empty;
                Ship_ShipURL_TB.Text = string.Empty;
                Ship_ShipAddress_TB.Text = string.Empty;
                Ship_ShipCreateDate_TB2.Text = string.Empty;
                Ship_ShipUpDate_TB2.Text = string.Empty;
                Ship_DataGridViewData_Company_DG.CurrentCell = null;
            }
            else if (Ship_Load_TabControl.SelectedTab == Ship_Route_page)
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
                Ship_ShipCreateDate_TB1.Text = string.Empty;
                Ship_ShipUpDate_TB1.Text = string.Empty;
                Ship_DataGridViewData_Route_DG.CurrentCell = null;

                Ship_Clear_BT_Fee();
            }
            else if (Ship_Load_TabControl.SelectedTab == Ship_Station_page)
            {
                Ship_StationID_TB.Text = string.Empty;
                Ship_X_TB.Text = string.Empty;
                Ship_Y_TB.Text = string.Empty;
                Ship_StationName_TB.Text = string.Empty;
                Ship_CityCode_TB.Text = string.Empty;
                Ship_District_TB.Text = string.Empty;
                Ship_DataGridViewData_Station_DG.CurrentCell = null;
            }
            else
            {
                MessageBox.Show("탭 선택 오류입니다.");
            }
        }

        //-----------------------------------------------노선정보------------------------------------------------------------
        //구분 클릭시 그리드뷰 초기화하고 해당데이터 불러오기(ex:가나다라마바사...별도관리)
        private void Ship_DataGridViewData_Route_DG_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Ship_Sortation_CB_select = "";
            var SelectedItem = Ship_Sortation_CB.SelectedItem;

            if (SelectedItem != null)
            {
                Ship_Sortation_CB_select = SelectedItem.ToString();

                if (Ship_Sortation_CB_select == "전체")
                {
                    Ship_DataGridViewData_Route_DG.Rows.Clear();
                    selectODSayLaneID();
                }
                else
                {
                    Connect();

                    string strSql = "select * from NEW_SHIP.dbo.TBShipLane";


                    cmd = new SqlCommand(strSql, sqlConnect);

                    SqlDataReader dt = cmd.ExecuteReader();

                    Ship_DataGridViewData_Route_DG.Rows.Clear();

                    while (dt.Read())
                    {
                        if (Ship_Sortation_CB_select == dt[1].ToString())
                        {
                            Ship_DataGridViewData_Route_DG.Rows.Add(dt[8], dt[9], dt[6], dt[7], dt[13], dt[14]);
                        }
                    }
                }
            }
            else
            {

            }

            sqlConnect.Close();
        }

        //셀 클릭시 해당 데이터 불러오기.
        private void Ship_DataGridViewData_Route_DG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Ship_Clear_BT_Fee();
                Connect();

                string strSql_Lane = "select * from NEW_SHIP.dbo.TBShipLane";
                string strSql_Harbor = "select * from NEW_SHIP.dbo.TBHarbor";
                string strSql_TBShipLaneInfo = "select * from NEW_SHIP.dbo.TBShipLaneInfo order by ODSayLaneID,StartTime asc";

                SqlCommand cmd_Lane = new SqlCommand(strSql_Lane, sqlConnect);
                SqlCommand cmd_Harbor = new SqlCommand(strSql_Harbor, sqlConnect);
                SqlCommand cmd_TBShipLaneInfo = new SqlCommand(strSql_TBShipLaneInfo, sqlConnect);

                SqlDataReader dt = cmd_Lane.ExecuteReader();
                SqlDataReader sdt = cmd_Harbor.ExecuteReader();
                SqlDataReader gdt = cmd_TBShipLaneInfo.ExecuteReader();

                int index = 0;
                index = e.RowIndex;
                Ship_DataGridViewData_Fee_DG.Rows.Clear();
                while (dt.Read())
                {
                    if (Ship_DataGridViewData_Route_DG.Rows[index].Cells[0].Value.ToString() == dt[8].ToString() &&
                        Ship_DataGridViewData_Route_DG.Rows[index].Cells[1].Value.ToString() == dt[9].ToString() &&
                        Ship_DataGridViewData_Route_DG.Rows[index].Cells[2].Value.ToString() == dt[6].ToString() &&
                        Ship_DataGridViewData_Route_DG.Rows[index].Cells[3].Value.ToString() == dt[7].ToString() &&
                        Ship_DataGridViewData_Route_DG.Rows[index].Cells[4].Value.ToString() == dt[13].ToString() &&
                        Ship_DataGridViewData_Route_DG.Rows[index].Cells[5].Value.ToString() == dt[14].ToString())
                    {
                        Ship_RouteID_TB.Text = dt[0].ToString(); //아로경로ID
                        Ship_ShipSortation_TB.Text = dt[2].ToString(); //구분항구 
                        Ship_ShipRouteOdsayIDS_TB.Text = dt[4].ToString(); //출발항구ODSayID
                        Ship_ShipRouteOdsayIDE_TB.Text = dt[5].ToString(); //도착항구ODSayID
                    }
                }
                Ship_DetailedHarborName_S_TB.Text = string.Empty;
                Ship_DetailedHarborName_E_TB.Text = string.Empty;

                // 출도착지 상세주소 대입
                while (sdt.Read())
                {
                    if (Ship_DataGridViewData_Route_DG.Rows[index].Cells[2].Value.ToString() == sdt[1].ToString())
                    {
                        Ship_DetailedHarborName_S_TB.Text = sdt[10].ToString(); //출발지 상세주소
                    }

                    if (Ship_DataGridViewData_Route_DG.Rows[index].Cells[3].Value.ToString() == sdt[1].ToString())
                    {
                        Ship_DetailedHarborName_E_TB.Text = sdt[10].ToString(); //도착지 상세주소
                    }
                }

                Ship_HarborS_TB.Text = Ship_DataGridViewData_Route_DG.Rows[index].Cells[0].Value.ToString(); //출발항
                Ship_HarborE_TB.Text = Ship_DataGridViewData_Route_DG.Rows[index].Cells[1].Value.ToString(); //도착항
                Ship_HarborSID_TB.Text = Ship_DataGridViewData_Route_DG.Rows[index].Cells[2].Value.ToString(); //출발항구ID
                Ship_HarborEID_TB.Text = Ship_DataGridViewData_Route_DG.Rows[index].Cells[3].Value.ToString(); //도착항구ID
                Ship_ShipCreateDate_TB1.Text = Ship_DataGridViewData_Route_DG.Rows[index].Cells[4].Value.ToString(); //작성날짜
                Ship_ShipUpDate_TB1.Text = Ship_DataGridViewData_Route_DG.Rows[index].Cells[5].Value.ToString(); //수정날짜
                while (gdt.Read())
                {
                    if (Ship_RouteID_TB.Text == gdt[0].ToString())
                    {
                        Ship_DataGridViewData_Fee_DG.Rows.Add(gdt[3], gdt[5], gdt[7], gdt[8], gdt[9], gdt[10], gdt[11], gdt[12], gdt[13]);
                    }
                }
                sdt.Close();
                dt.Close();
                sqlConnect.Close();
            }
        }

        // 상세 내역 변경
        private void Ship_Fee_TB_TextChanged()
        {
            Connect();

            string strSql_TBShipLaneInfo = "select * from NEW_SHIP.dbo.TBShipLaneInfo";
            SqlCommand cmd_TBShipLaneInfo = new SqlCommand(strSql_TBShipLaneInfo, sqlConnect);
            SqlDataReader gdt = cmd_TBShipLaneInfo.ExecuteReader();

            string TimeAdd = Ship_StartTime_TB.Text;
            string TimerequiredAdd = Ship_Timerequired_TB.Text;
            string Rank2Add = Ship_Rank2_TB.Text;
            string AdultFeeAdd = Ship_AdultFee_TB.Text;
            string YouthFeeAdd = Ship_YouthFee_TB.Text;
            string SeniorFeeAdd = Ship_SeniorFee_TB.Text;
            string ChildFeeAdd = Ship_ChildFee_TB.Text;

            string strSql = "UPDATE NEW_SHIP.dbo.TBShipLaneInfo SET StartTime = @TimeAdd, Rank = @Rank2Add, TimeRequired = @TimerequiredAdd, AdultFee = @AdultFeeAdd, YouthFee = @YouthFeeAdd, SeniorFee = @SeniorFeeAdd, ChildFee = @ChildFeeAdd where ODSayLaneID = @ODSayLaneID and StartTime = @TimeAdd and ShipName = @Ship_ShipName2_TB";
            SqlCommand cmd = new SqlCommand(strSql, sqlConnect);
            try
            {
                cmd.Parameters.AddWithValue("@TimeAdd", TimeAdd);
                cmd.Parameters.AddWithValue("@TimerequiredAdd", Ship_Timerequired_TB.Text);
                cmd.Parameters.AddWithValue("@Rank2Add", Ship_Rank2_TB.Text);
                cmd.Parameters.AddWithValue("@AdultFeeAdd", Ship_AdultFee_TB.Text);
                cmd.Parameters.AddWithValue("@YouthFeeAdd", Ship_YouthFee_TB.Text);
                cmd.Parameters.AddWithValue("@RSeniorFeeAddank2Add", Ship_SeniorFee_TB.Text);
                cmd.Parameters.AddWithValue("@ChildFeeAdd", Ship_ChildFee_TB.Text);
                cmd.Parameters.AddWithValue("@ODSayLaneID", Ship_RouteID_TB.Text);
                cmd.ExecuteNonQuery();

                //몇 개의 데이터가 바뀌었는지 알수있음.
                int rowsAffected = cmd.ExecuteNonQuery();
                MessageBox.Show("상세 내역 " + rowsAffected + "개의 행이 변경되었습니다.");
            }
            catch
            {
                MessageBox.Show("상세 내역 오류입니다.");
            }

            sqlConnect.Close();
        }

        // 출발지 상세주소지 변경
        private void Ship_DetailedHarborName_S_TB_TextChanged()
        {
            Connect();

            string strSql_Lane = "select * from NEW_SHIP.dbo.TBShipLane";
            string strSql_Harbor = "select * from NEW_SHIP.dbo.TBHarbor";

            SqlCommand cmd_Lane = new SqlCommand(strSql_Lane, sqlConnect);
            SqlCommand cmd_Harbor = new SqlCommand(strSql_Harbor, sqlConnect);

            SqlDataReader dt = cmd_Lane.ExecuteReader();
            SqlDataReader sdt = cmd_Harbor.ExecuteReader();


            string newAdd = Ship_DetailedHarborName_S_TB.Text;

            string strSql = "UPDATE NEW_SHIP.dbo.TBHarbor SET Addr = @newAdd where ODSayHarborID = @ODSayHarborID and ID = @ID";
            SqlCommand cmd = new SqlCommand(strSql, sqlConnect);
            try
            {
                cmd.Parameters.AddWithValue("@newAdd", newAdd);
                cmd.Parameters.AddWithValue("@ODSayHarborID", Ship_ShipRouteOdsayIDS_TB.Text);
                cmd.Parameters.AddWithValue("@ID", Ship_HarborSID_TB.Text);
                cmd.ExecuteNonQuery();

                //몇 개의 데이터가 바뀌었는지 알수있음.
                int rowsAffected = cmd.ExecuteNonQuery();
                MessageBox.Show("출발지 Addr " + rowsAffected + "개의 행이 변경되었습니다.");
            }
            catch
            {
                MessageBox.Show("출발지 오류입니다.");
            }

            sqlConnect.Close();
        }

        // 도착지 상세주소지 변경
        private void Ship_DetailedHarborName_E_TB_TextChanged()
        {
            Connect();

            string strSql_Lane = "select * from NEW_SHIP.dbo.TBShipLane";
            string strSql_Harbor = "select * from NEW_SHIP.dbo.TBHarbor";

            SqlCommand cmd_Lane = new SqlCommand(strSql_Lane, sqlConnect);
            SqlCommand cmd_Harbor = new SqlCommand(strSql_Harbor, sqlConnect);

            SqlDataReader dt = cmd_Lane.ExecuteReader();
            SqlDataReader sdt = cmd_Harbor.ExecuteReader();


            string newAdd = Ship_DetailedHarborName_E_TB.Text;

            string strSql = "UPDATE NEW_SHIP.dbo.TBHarbor SET Addr = @newAdd where ODSayHarborID = @ODSayHarborID and ID = @ID";
            SqlCommand cmd = new SqlCommand(strSql, sqlConnect);
            try
            {
                cmd.Parameters.AddWithValue("@newAdd", newAdd);
                cmd.Parameters.AddWithValue("@ODSayHarborID", Ship_ShipRouteOdsayIDE_TB.Text);
                cmd.Parameters.AddWithValue("@ID", Ship_HarborEID_TB.Text);
                cmd.ExecuteNonQuery();

                //몇 개의 데이터가 바뀌었는지 알수있음.
                int rowsAffected = cmd.ExecuteNonQuery();
                MessageBox.Show("도착지 Addr " + rowsAffected + "개의 행이 변경되었습니다.");
            }
            catch
            {
                MessageBox.Show("도착지 오류입니다.");
            }
            sqlConnect.Close();
        }

        //저장시 자동으로 수정날짜 바꾸기
        private void Ship_UpdateDate_TB_TextChanged()
        {
            //select* from[NEW_SHIP].[dbo].TBHarbor where ID ='88888'

            // 현재 시간과 날짜를 가져오기
            string currentTime = DateTime.Now.ToString("HH:mm:ss.fff");
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

            // 텍스트박스에 현재 시간과 날짜 넣기
            string current = currentDate + " " + currentTime;
            Ship_ShipUpDate_TB1.Text = current;

            Connect();

            string strSql = "UPDATE NEW_SHIP.dbo.TBShipLane SET UpdateDate = @UpdateDate Where ODSayLaneID = @ODSayLaneID and Harbor_ID_S = @StartID and Harbor_ID_E = @EndID and IndexedSearch2='테스트 섬'";
            SqlCommand cmd = new SqlCommand(strSql, sqlConnect);
            try
            {
                cmd.Parameters.AddWithValue("@UpdateDate", current);
                cmd.Parameters.AddWithValue("@ODSayLaneID", Ship_RouteID_TB.Text);
                cmd.Parameters.AddWithValue("@StartID", Ship_HarborSID_TB.Text);
                cmd.Parameters.AddWithValue("@EndID", Ship_HarborEID_TB.Text);
                cmd.ExecuteNonQuery();
                //몇 개의 데이터가 바뀌었는지 알수있음.
                int rowsAffected = cmd.ExecuteNonQuery();
                MessageBox.Show("UpdateDate " + rowsAffected + "개의 행이 변경되었습니다.");
            }
            catch
            {
                MessageBox.Show("시간 오류입니다.");
            }
            sqlConnect.Close();

        }

        //저장하기 누를시 코드
        private void Ship_Update_BT_Click(object sender, EventArgs e)
        {
            Ship_Fee_TB_TextChanged(); // 상세내역 변경
            Ship_DetailedHarborName_S_TB_TextChanged();//출발지 상세주소 변경
            Ship_DetailedHarborName_E_TB_TextChanged();//도착지 상세주소 변경
            Ship_UpdateDate_TB_TextChanged();//시간변경
            Ship_DataGridViewData_Route_DG.Rows.Clear();
            selectODSayLaneID();
            MessageBox.Show("저장되었습니다.");
        }

        private void Ship_DataGridViewData_Fee_DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
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
        }
        //-----------------------------------------------노선정보------------------------------------------------------------

            

        //-----------------------------------------------해운정보------------------------------------------------------------
        public void selectODSayShipCompanyID()
        {

            Connect();

            string strSql = "select * from NEW_SHIP.dbo.TBShipCompany";

            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader dt = cmd.ExecuteReader();

            while (dt.Read())
            {
                Ship_DataGridViewData_Company_DG.Rows.Add(dt[0], dt[2], dt[4], dt[5], dt[10]);
            }

            sqlConnect.Close();

            foreach (DataGridViewColumn column in Ship_DataGridViewData_Company_DG.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            Ship_DataGridViewData_Company_DG.CurrentCell = null;

        }

        //셀 클릭시 해당 데이터 불러오기.
        private void Ship_DataGridViewData_Company_DG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Connect();

            string strSql = "select * from NEW_SHIP.dbo.TBShipCompany";

            SqlCommand cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                if (e.RowIndex == -1)
                {
                    continue;
                }
                else if (Ship_DataGridViewData_Company_DG.Rows[e.RowIndex].Cells[0].Value.ToString() == dt[0].ToString())
                {
                    Ship_ShipCompanyID_TB.Text = dt[0].ToString(); //아로선사ID
                    Ship_BusinessNum_TB.Text = dt[1].ToString(); //선사번호(사업자)
                    Ship_ShipCompanyName_TB.Text = dt[2].ToString(); //선사명
                    //Ship_ShipCompanyNum_TB.Text = dt[3].ToString(); //선사연락처
                    Ship_ShipName_TB.Text = dt[4].ToString(); //선박명
                    Ship_ShipType_TB.Text = dt[5].ToString(); //선박종류
                    Ship_ShipAddress_TB.Text = dt[6].ToString(); //주소
                    Ship_ShipCapacity_TB.Text = dt[7].ToString(); //정원
                    //dt[8]은 선착 유무인데 불필요
                    Ship_ShipCarNum_TB.Text = dt[9].ToString(); //차량선적대수
                    Ship_ShipRoute_TB.Text = dt[10].ToString(); //운행구간
                    Ship_ShipKnot_TB.Text = dt[11].ToString(); //속력(노트)
                    Ship_ShipCompanyDate_TB.Text = dt[12].ToString(); //전수년월
                    Ship_ShipURL_TB.Text = dt[13].ToString(); //홈페이지
                    //dt[14]은 불필요
                    Ship_ShipCreateDate_TB2.Text = dt[15].ToString(); //작성날짜
                    Ship_ShipUpDate_TB2.Text = dt[16].ToString(); //수정날짜
                }
            }
            sqlConnect.Close();
        }

        //텍스트박스 수정 후 DB저장
        private void Ship_textBox_TextChanged1()
        {
            Connect();

            string strSql = "select * from NEW_SHIP.dbo.TBShipCompany";

            SqlCommand cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader dt = cmd.ExecuteReader();

            string Update_strSql = "UPDATE NEW_SHIP.dbo.TBShipCompany SET";

            string ShipCompanyNo = "";
            string ShipCompanyName = "";
            //string Tel = "";
            string ShipName = "";
            string ShipType = "";
            string Addr = "";
            string Personnel = "";
            //string ShipVehiclesYN = "";
            string ShipVehiclesCnt = "";
            string OperationRange = "";
            string Speed = "";
            string ShipCompanyDate = "";
            string URL = "";
            //string DelYN
            string CreateDate = "";
            string UpdateDate = "";


            //해운정보 텍스트박스의 공백이 아닐 경우 출력을 하기위해 조건을 건다.

            if (!string.IsNullOrEmpty("@ShipCompanyNo"))
            {
                ShipCompanyNo = " ShipCompanyNo = @ShipCompanyNo,";
            }
            if (!string.IsNullOrEmpty("@ShipCompanyName"))
            {
                ShipCompanyName = " ShipCompanyName = @ShipCompanyName,";
            }
            /*if (!string.IsNullOrEmpty("@Tel"))
            {
                Tel = " Tel = @Tel, ShipName = @ShipName,";
            }*/
            if (!string.IsNullOrEmpty("@ShipType"))
            {
                ShipType = " ShipType = @ShipType,";
            }
            if (!string.IsNullOrEmpty("@Addr"))
            {
                Addr = " Addr = @Addr,";
            }
            if (!string.IsNullOrEmpty("@Personnel"))
            {
                Personnel = " Personnel = @Personnel,";
            }
            if (!string.IsNullOrEmpty("@ShipVehiclesCnt"))
            {
                ShipVehiclesCnt = " ShipVehiclesCnt = @ShipVehiclesCnt,";
            }
            if (!string.IsNullOrEmpty("@OperationRange"))
            {
                OperationRange = " OperationRange = @OperationRange,";
            }
            if (!string.IsNullOrEmpty("@Speed"))
            {
                Speed = " Speed = @Speed,";
            }
            if (!string.IsNullOrEmpty("@ShipCompanyDate"))
            {
                ShipCompanyDate = " ShipCompanyDate = @ShipCompanyDate,";
            }
            if (!string.IsNullOrEmpty("@URL"))
            {
                URL = " URL = @URL";
            }



            /*
            " ShipCompanyName = @ShipCompanyName," +
            " Tel = @Tel, ShipName = @ShipName," +
            " ShipType = @ShipType," +
            " Addr = @Addr," +
            " Personnel = @Personnel," +
            " ShipVehiclesYN = @ShipVehiclesYN," + // YN선택지라 제외
            " ShipVehiclesCnt = @ShipVehiclesCnt," +
            " OperationRange = @OperationRange," +
            " Speed = @Speed," +
            " ShipCompanyDate = @ShipCompanyDate," +
            " URL = @URL" +
            " DelYN = @DelYN" +// YN선택지라 제외
            */
            string Update_where = " where ODSayShipCompanyID = @ODSayShipCompanyID";

            Update_strSql += ShipCompanyNo += ShipCompanyName += ShipName += ShipType += Addr += Personnel += ShipVehiclesCnt += OperationRange += Speed += ShipCompanyDate += URL += Update_where;

            //구간별 하나씩 오류발생시 어디서 오류인지 파악할수있게 구분.
            SqlCommand Update_cmd = new SqlCommand(Update_strSql, sqlConnect);
            try
            {
                Update_cmd.Parameters.AddWithValue("@ODSayShipCompanyID", Ship_ShipCompanyID_TB.Text);
            }
            catch
            {
                MessageBox.Show(Ship_ShipCompanyID_TB.Text + "저장 오류입니다.");
            }
            try
            {
                Update_cmd.Parameters.AddWithValue("@ShipCompanyNo", Ship_BusinessNum_TB.Text); //선사번호(사업자)
            }
            catch
            {
                MessageBox.Show(Ship_BusinessNum_TB.Text + "저장 오류입니다.");
            }
            try
            {
                Update_cmd.Parameters.AddWithValue("@ShipCompanyName", Ship_ShipName_TB.Text); //선사명
            }
            catch
            {
                MessageBox.Show(Ship_ShipName_TB.Text + "저장 오류입니다.");
            }
            /*try
            {
                Update_cmd.Parameters.AddWithValue("@Tel", Ship_ShipCompanyNum_TB.Text); //선사연락처
            }
            catch
            {
                MessageBox.Show(Ship_ShipCompanyNum_TB.Text + "저장 오류입니다.");
            }*/
            try
            {
                Update_cmd.Parameters.AddWithValue("@ShipName", Ship_ShipName_TB.Text); //선박명
            }
            catch
            {
                MessageBox.Show(Ship_ShipName_TB.Text + "저장 오류입니다.");
            }
            try
            {
                Update_cmd.Parameters.AddWithValue("@ShipType", Ship_ShipType_TB.Text); //선박종류
            }
            catch
            {
                MessageBox.Show(Ship_ShipType_TB.Text + "저장 오류입니다.");
            }
            try
            {
                Update_cmd.Parameters.AddWithValue("@Addr", Ship_ShipAddress_TB.Text); //주소
            }
            catch
            {
                MessageBox.Show(Ship_ShipAddress_TB.Text + "저장 오류입니다.");
            }
            try
            {
                Update_cmd.Parameters.AddWithValue("@Personnel", Ship_ShipCapacity_TB.Text); //정원
            }
            catch
            {
                MessageBox.Show(Ship_ShipCapacity_TB.Text + "저장 오류입니다.");
            }
            try
            {
                Update_cmd.Parameters.AddWithValue("@ShipVehiclesCnt", Ship_ShipCarNum_TB.Text); //차량선적대수
            }
            catch
            {
                MessageBox.Show(Ship_ShipCarNum_TB.Text + "저장 오류입니다.");
            }
            try
            {
                Update_cmd.Parameters.AddWithValue("@OperationRange", Ship_ShipRoute_TB.Text); //(운행구간)
            }
            catch
            {
                MessageBox.Show(Ship_ShipRoute_TB.Text + "저장 오류입니다.");
            }
            try
            {
                Update_cmd.Parameters.AddWithValue("@Speed", Ship_ShipKnot_TB.Text); //속력(노트)
            }
            catch
            {
                MessageBox.Show(Ship_ShipKnot_TB.Text + "저장 오류입니다.");
            }
            try
            {
                Update_cmd.Parameters.AddWithValue("@ShipCompanyDate", Ship_ShipCompanyDate_TB.Text); //전수년월
            }
            catch
            {
                MessageBox.Show(Ship_ShipCompanyDate_TB.Text + "저장 오류입니다.");
            }
            try
            {
                Update_cmd.Parameters.AddWithValue("@URL", Ship_ShipURL_TB.Text); //홈페이지
            }
            catch
            {
                MessageBox.Show(Ship_ShipURL_TB.Text + "저장 오류입니다.");
            }


            /*
            Update_cmd.Parameters.AddWithValue("@ShipCompanyNo", Ship_BusinessNum_TB.Text); //선사번호(사업자)
            Update_cmd.Parameters.AddWithValue("@ShipCompanyName", Ship_ShipName_TB.Text); //선사명
            Update_cmd.Parameters.AddWithValue("@Tel", Ship_ShipCompanyNum_TB.Text); //선사연락처
            Update_cmd.Parameters.AddWithValue("@ShipName", Ship_ShipName_TB.Text); //선박명
            Update_cmd.Parameters.AddWithValue("@ShipType", Ship_ShipType_TB.Text); //선박종류
            Update_cmd.Parameters.AddWithValue("@Addr", Ship_ShipAddress_TB.Text); //주소
            Update_cmd.Parameters.AddWithValue("@Personnel", Ship_ShipCapacity_TB.Text); //정원
            Update_cmd.Parameters.AddWithValue("@ShipVehiclesCnt", Ship_ShipCarNum_TB.Text); //차량선적대수
            Update_cmd.Parameters.AddWithValue("@OperationRange", Ship_ShipRoute_TB.Text); //(운행구간)
            Update_cmd.Parameters.AddWithValue("@Speed", Ship_ShipKnot_TB.Text); //속력(노트)
            Update_cmd.Parameters.AddWithValue("@ShipCompanyDate", Ship_ShipCompanyDate_TB.Text); //전수년월
            Update_cmd.Parameters.AddWithValue("@URL", Ship_ShipURL_TB.Text); //홈페이지
            */

            Update_cmd.ExecuteNonQuery();
            sqlConnect.Close();
        }

        //저장시 자동으로 수정날짜 바꾸기
        private void Ship_ShipUpDate_TB2_TextChanged()
        {
            //select* from[NEW_SHIP].[dbo].TBHarbor where ID ='88888'

            // 현재 시간과 날짜를 가져오기
            string currentTime = DateTime.Now.ToString("HH:mm:ss.fff");
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");

            // 텍스트박스에 현재 시간과 날짜 넣기
            string current = currentDate + " " + currentTime;
            Ship_ShipUpDate_TB2.Text = current;


            Connect();

            string strSql = "UPDATE NEW_SHIP.dbo.TBShipCompany SET UpdateDate = @UpdateDate Where ODSayShipCompanyID = @ODSayShipCompanyID";
            SqlCommand cmd = new SqlCommand(strSql, sqlConnect);

            try
            {
                cmd.Parameters.AddWithValue("@UpdateDate", current);
                cmd.Parameters.AddWithValue("@ODSayShipCompanyID", Ship_ShipCompanyID_TB.Text);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("시간 오류입니다.");
            }
            sqlConnect.Close();

        }

        //초기화 버튼.
        private void Ship_Clear_BT2_Click(object sender, EventArgs e)
        {
            Ship_Clear_BT_Clear();
            Ship_DataGridViewData_Station_DG.CurrentCell = null;
        }

        private void Ship_Update_BT2_Click(object sender, EventArgs e)
        {
            Ship_textBox_TextChanged1(); // 텍스트박스 수정 후 저장코드
            Ship_ShipUpDate_TB2_TextChanged(); // 시간변경 코드
            Ship_DataGridViewData_Company_DG.Rows.Clear();
            selectODSayShipCompanyID();
            MessageBox.Show("저장되었습니다.");
        }

        //-----------------------------------------------해운정보------------------------------------------------------------



        //-----------------------------------------------항구정보------------------------------------------------------------
        public void selectODSayShipStation()
        {

            Connect();

            string strSql = "select * from NEW_SHIP.dbo.TBStation_Ship";

            cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader dt = cmd.ExecuteReader();

            while (dt.Read())
            {
                Ship_DataGridViewData_Station_DG.Rows.Add(dt[0], dt[1], dt[2], dt[5], dt[8], dt[12]);
            }

            sqlConnect.Close();
            foreach (DataGridViewColumn column in Ship_DataGridViewData_Station_DG.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            Ship_DataGridViewData_Station_DG.CurrentCell = null;
        }

        //셀 클릭시 해당 데이터 불러오기.
        private void Ship_DataGridViewData_Station_DG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Connect();

            string strSql = "select * from NEW_SHIP.dbo.TBStation_Ship";

            SqlCommand cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                if (e.RowIndex == -1)
                {
                    continue;
                }
                else if (Ship_DataGridViewData_Station_DG.Rows[e.RowIndex].Cells[0].Value.ToString() == dt[0].ToString())
                {
                    Ship_StationID_TB.Text = dt[0].ToString(); //항구ID
                    Ship_X_TB.Text = dt[1].ToString(); //카텍 X
                    Ship_Y_TB.Text = dt[2].ToString(); //카텍 Y
                    Ship_StationName_TB.Text = dt[5].ToString(); //항구명
                    Ship_CityCode_TB.Text = dt[8].ToString(); //시티코드
                    Ship_District_TB.Text = dt[12].ToString(); //행정구역
                }
            }
            sqlConnect.Close();

        }

        //텍스트박스 수정 후 DB저장
        private void Ship_textBox_TextChanged2()
        {
            Connect();

            string strSql = "select * from NEW_SHIP.dbo.TBStation_Ship";

            SqlCommand cmd = new SqlCommand(strSql, sqlConnect);

            SqlDataReader dt = cmd.ExecuteReader();

            string Update_strSql = "UPDATE NEW_SHIP.dbo.TBStation_Ship SET";

            string StationID = "";
            string X = "";
            string Y = "";
            string NameKor = "";
            string CityCode = "";
            string Do = "";
            

            //해운정보 텍스트박스의 공백이 아닐 경우 출력을 하기위해 조건을 건다.

            if (!string.IsNullOrEmpty("@StationID"))
            {
                StationID = " StationID = @StationID,";
            }
            if (!string.IsNullOrEmpty("@X"))
            {
                X = " X = @X,";
            }
            if (!string.IsNullOrEmpty("@Y"))
            {
                Y = " Y = @Y,";
            }
            if (!string.IsNullOrEmpty("@NameKor"))
            {
                NameKor = " NameKor = @NameKor,";
            }
            if (!string.IsNullOrEmpty("@CityCode"))
            {
                CityCode = " CityCode = @CityCode,";
            }
            if (!string.IsNullOrEmpty("@Do"))
            {
                Do = " Do = @Do,";
            }

            string Update_where = " where StationID = @StationID";

            Update_strSql += StationID += X += Y += NameKor += CityCode += Do += Update_where;

            //구간별 하나씩 오류발생시 어디서 오류인지 파악할수있게 구분.
            SqlCommand Update_cmd = new SqlCommand(Update_strSql, sqlConnect);
            try
            {
                Update_cmd.Parameters.AddWithValue("@StationID", Ship_StationID_TB.Text);
            }
            catch
            {
                MessageBox.Show(Ship_StationID_TB.Text + "저장 오류입니다.");
            }
            try
            {
                Update_cmd.Parameters.AddWithValue("@X", Ship_X_TB.Text); //선사번호(사업자)
            }
            catch
            {
                MessageBox.Show(Ship_X_TB.Text + "저장 오류입니다.");
            }
            try
            {
                Update_cmd.Parameters.AddWithValue("@Y", Ship_Y_TB.Text); //선사명
            }
            catch
            {
                MessageBox.Show(Ship_Y_TB.Text + "저장 오류입니다.");
            }
            try
            {
                Update_cmd.Parameters.AddWithValue("@NameKor", Ship_StationName_TB.Text); //선사연락처
            }
            catch
            {
                MessageBox.Show(Ship_StationName_TB.Text + "저장 오류입니다.");
            }
            try
            {
                Update_cmd.Parameters.AddWithValue("@CityCode", Ship_CityCode_TB.Text); //선박명
            }
            catch
            {
                MessageBox.Show(Ship_CityCode_TB.Text + "저장 오류입니다.");
            }
            try
            {
                Update_cmd.Parameters.AddWithValue("@Do", Ship_District_TB.Text); //선박종류
            }
            catch
            {
                MessageBox.Show(Ship_District_TB.Text + "저장 오류입니다.");
            }

            Update_cmd.ExecuteNonQuery();
            sqlConnect.Close();
        }

        //초기화 버튼.
        private void Ship_Clear_BT3_Click(object sender, EventArgs e)
        {
            Ship_Clear_BT_Clear();
        }

        private void Ship_Update_BT3_Click(object sender, EventArgs e)
        {
            Ship_textBox_TextChanged2(); // 텍스트박스 수정 후 저장코드
            MessageBox.Show("저장되었습니다.");
        }

        private void Ship_Delete_BT3_Click(object sender, EventArgs e)
        {
            /* 삭제 기능 일시 대기.
            Ship_Delete_BT_Delete();
            MessageBox.Show("삭제 되었습니다.");
            Ship_DataGridViewData_Station_DG.Rows.Clear();
            selectODSayShipStation();
            */
            MessageBox.Show("사용 불가능한 기능입니다.");
        }

        








        //-----------------------------------------------항구정보------------------------------------------------------------

    }
}
