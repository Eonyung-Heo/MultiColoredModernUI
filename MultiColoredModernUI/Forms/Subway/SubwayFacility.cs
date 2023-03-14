using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiColoredModernUI.Forms.Subway
{
    public partial class SubwayFacility : Form
    {
        MssqlSubway sql = new MssqlSubway();
        Mssql mainSql = new Mssql();
        bool listClickCheck = false;
        List<string> itemList = new List<string>();
        List<string> currItemList = new List<string>();
        string strLog = "";

        public SubwayFacility()
        {
            InitializeComponent();
            ComboBoxValueAdd();
            sql.GetRegion();
            RegionAdd();
            StationNameList();
            StationList();
            ValueClear();
        }

        public void RegionAdd()
        {
            for (int i = 0; i < StaticSubway.regions.Count; i++)
            {
                comboboxRegion.Items.Add(StaticSubway.regions[i][1].ToString());
            }

        }

        private void StationNameList()
        {
            listStationName.Clear();
            listStationName.View = View.Details;
            listStationName.GridLines = true;
            listStationName.FullRowSelect = true;


            listStationName.Columns.Add("지하철 역 이름", listStationName.Width);

        }

        private void comboboxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            listStationName.Items.Clear();
            listStationName.Refresh();

            int i = comboboxRegion.SelectedIndex;

            btnAlter_Click(sender, e);

            listClickCheck = false;

            if (i == -1)
                return;

            int cityCode = Convert.ToInt16(StaticSubway.regions[i][0].ToString());


            sql.GetLaneType(cityCode);
            sql.GetStationName(cityCode, 0);
            //StationNameItemAdd();
            LaneTypeAdd();
            ValueClear();
        }

        public void LaneTypeAdd()
        {
            comboBoxLaneType.Items.Clear();

            for (int i = 0; i < StaticSubway.laneTypes.Count; i++)
            {
                comboBoxLaneType.Items.Add(StaticSubway.laneTypes[i][0].ToString());
            }


        }

        private void comboBoxLaneType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int laneType = -1;
            int cityCode = -1;


            int i = comboboxRegion.SelectedIndex;
            int j = comboBoxLaneType.SelectedIndex;

            btnAlter_Click(sender, e);

            listClickCheck = false;

            if (i != -1 && j != -1)
            {
                laneType = Convert.ToInt16(StaticSubway.laneTypes[j][1].ToString());
                cityCode = Convert.ToInt16(StaticSubway.regions[i][0].ToString());
            }

            sql.GetLaneType(cityCode);
            sql.GetStationName(cityCode, laneType);
            StationNameItemAdd();
            guna2DataGridView1.Rows.Clear();
            ValueClear();

        }

        public void StationNameItemAdd()
        {
            listStationName.Items.Clear();
            listStationName.Refresh();

            for (int i = 0; i < StaticSubway.stationNames.Count; i++)
            {
                string[] str = StaticSubway.stationNames[i].ToArray();

                ListViewItem item = new ListViewItem(str);

                listStationName.Items.Add(item);
            }
        }

        public void StationItemAdd()
        {
            guna2DataGridView1.Rows.Clear();
            guna2DataGridView1.Refresh();

            for (int i = 0; i < StaticSubway.stations.Count; i++)
            {
                string[] str = StaticSubway.stations[i].ToArray();

                guna2DataGridView1.Rows.Add(str);

            }
        }

        private void listStationName_Click(object sender, EventArgs e)
        {
            IEnumerator enm = listStationName.SelectedIndices.GetEnumerator();

            int currIndex = -1;

            while (enm.MoveNext())
            {
                currIndex = (int)enm.Current;


            }

            if (currIndex != -1)
            {

                btnAlter_Click(sender, e);

                listClickCheck = true;

                long stationID = Convert.ToInt32(StaticSubway.stationNames[currIndex][1].ToString());

                sql.GetFacility(stationID);
                StationItemAdd();

                ValueClear();

                listStation_Click(sender, e);
            }
        }
        
        private void StationList()
        {
            /*
            listStation.Clear();
            listStation.View = View.Details;
            listStation.GridLines = true;
            listStation.FullRowSelect = true;


            listStation.Columns.Add("SSID", 0);
            listStation.Columns.Add("역 이름",100);
            listStation.Columns.Add("유실물 센터", 100);
            listStation.Columns.Add("자전거 보관소", 100);
            listStation.Columns.Add("환승 주차장", 100);
            listStation.Columns.Add("역무실", 50);
            listStation.Columns.Add("현장민원실", 80);
            listStation.Columns.Add("매표소", 50);
            listStation.Columns.Add("장애인화장실", 100);
            listStation.Columns.Add("엘리베이터", 80);
            listStation.Columns.Add("휠체어리프트", 100);
            listStation.Columns.Add("관광안내소", 80);
            listStation.Columns.Add("무인민원발급기", 100);
            listStation.Columns.Add("수유방", 50);
            listStation.Columns.Add("물품보관실", 80);
            listStation.Columns.Add("유실물센터 전화번호", 130);
            listStation.Columns.Add("유실물센터 URL", 150);

            //listStation.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //listStation.Columns[0].Width = 0;
            */

            guna2DataGridView1.Columns[0].Visible = false;
        }

        public void ComboBoxValueAdd()
        {

            ValueClear();

            string[] lostCenter = { "0:없음","1:있음"};
            string[] bicycleRack = { "0:없음", "1:있음" };
            string[] transferParking = { "0:없음", "1:있음" };
            string[] stationOffice = { "0:없음", "1:있음" };
            string[] publicOffice = { "0:없음", "1:있음" };
            string[] ticket = { "0:없음", "1:있음" };
            string[] disabledToilet = { "0:없음", "1:있음" };
            string[] elevator = { "0:없음", "1:있음" };
            string[] wheelChairLift = { "0:없음", "1:있음" };
            string[] visitorCenter = { "0:없음", "1:있음" };
            string[] automaticDispenser = { "0:없음", "1:있음" };
            string[] lactationRoom = { "0:없음", "1:있음" };
            string[] locker = { "0:없음", "1:있음" };

            comboLostCenter.Items.AddRange(lostCenter.ToArray());
            comboBicycleRack.Items.AddRange(bicycleRack.ToArray());
            comboTransferParking.Items.AddRange(transferParking.ToArray());
            comboStationOffice.Items.AddRange(stationOffice.ToArray());
            comboPublicOffice.Items.AddRange(publicOffice.ToArray());
            comboTicket.Items.AddRange(ticket.ToArray());
            comboDisabledToilet.Items.AddRange(disabledToilet.ToArray());
            comboElevator.Items.AddRange(elevator.ToArray());
            comboWheelChairLift.Items.AddRange(wheelChairLift.ToArray());
            comboVisitorCenter.Items.AddRange(visitorCenter.ToArray());
            comboAutomaticDispenser.Items.AddRange(automaticDispenser.ToArray());
            combolactationRoom.Items.AddRange(lactationRoom.ToArray());
            comboLocker.Items.AddRange(locker.ToArray());

            comboLostCenter.Enabled = true;
            comboBicycleRack.Enabled = true;
            comboTransferParking.Enabled = true;
            comboStationOffice.Enabled = true;
            comboPublicOffice.Enabled = true;
            comboTicket.Enabled = true;
            comboDisabledToilet.Enabled = true;
            comboElevator.Enabled = true;
            comboWheelChairLift.Enabled = true;
            comboVisitorCenter.Enabled = true;
            comboAutomaticDispenser.Enabled = true;
            combolactationRoom.Enabled = true;
            comboLocker.Enabled = true;
            textLostCenterTel.Enabled = true;
            textLostCenterUrl.Enabled = true;
            textStationName.Enabled = true;
            btnAlter.Enabled = true;


        }

        public int ComboBoxValue(int iValue, string sValue)
        {
            if (sValue != "")
            {
                int i = sValue.IndexOf(":", 0);

                iValue = Convert.ToInt16(sValue.Substring(0, i));
            }

            return iValue;
        }

        private void listStation_Click(object sender, EventArgs e)
        {

            int currIndex = -1;


            bool currRow = guna2DataGridView1.CurrentRow.Selected;

            if (currRow == true)
                currIndex = guna2DataGridView1.CurrentCell.RowIndex;

            if (currIndex != -1)
            {
                ComboBoxValueAdd();

                textStationName.Text = StaticSubway.stations[currIndex][1].ToString();
                comboLostCenter.SelectedIndex = ComboBoxValue(Convert.ToInt16(StaticSubway.stations[currIndex][2].ToString()), "");
                comboBicycleRack.SelectedIndex = ComboBoxValue(Convert.ToInt16(StaticSubway.stations[currIndex][3].ToString()), "");
                comboTransferParking.SelectedIndex = ComboBoxValue(Convert.ToInt16(StaticSubway.stations[currIndex][4].ToString()), "");
                comboStationOffice.SelectedIndex = ComboBoxValue(Convert.ToInt16(StaticSubway.stations[currIndex][5].ToString()), "");
                comboPublicOffice.SelectedIndex = ComboBoxValue(Convert.ToInt16(StaticSubway.stations[currIndex][6].ToString()), "");
                comboTicket.SelectedIndex = ComboBoxValue(Convert.ToInt16(StaticSubway.stations[currIndex][7].ToString()), "");
                comboDisabledToilet.SelectedIndex = ComboBoxValue(Convert.ToInt16(StaticSubway.stations[currIndex][8].ToString()), "");
                comboElevator.SelectedIndex = ComboBoxValue(Convert.ToInt16(StaticSubway.stations[currIndex][9].ToString()), "");
                comboWheelChairLift.SelectedIndex = ComboBoxValue(Convert.ToInt16(StaticSubway.stations[currIndex][10].ToString()), "");
                comboVisitorCenter.SelectedIndex = ComboBoxValue(Convert.ToInt16(StaticSubway.stations[currIndex][11].ToString()), "");
                comboAutomaticDispenser.SelectedIndex = ComboBoxValue(Convert.ToInt16(StaticSubway.stations[currIndex][12].ToString()), "");
                combolactationRoom.SelectedIndex = ComboBoxValue(Convert.ToInt16(StaticSubway.stations[currIndex][13].ToString()), "");
                comboLocker.SelectedIndex = ComboBoxValue(Convert.ToInt16(StaticSubway.stations[currIndex][14].ToString()), "");
                textLostCenterTel.Text = StaticSubway.stations[currIndex][15].ToString();
                textLostCenterUrl.Text = StaticSubway.stations[currIndex][16].ToString();

                itemList.Clear();

                itemList.AddRange(StaticSubway.stations[currIndex].ToList());

                comboLostCenter.Enabled = true;
                comboBicycleRack.Enabled = true;
                comboTransferParking.Enabled = true;
                comboStationOffice.Enabled = true;
                comboPublicOffice.Enabled = true;
                comboTicket.Enabled = true;
                comboDisabledToilet.Enabled = true;
                comboElevator.Enabled = true;
                comboWheelChairLift.Enabled = true;
                comboVisitorCenter.Enabled = true;
                comboAutomaticDispenser.Enabled = true;
                combolactationRoom.Enabled = true;
                comboLocker.Enabled = true;
                textLostCenterTel.Enabled = true;
                textLostCenterUrl.Enabled = true;
                textStationName.Enabled = true;
                btnAlter.Enabled = true;

            }
        }

        public void ValueClear()
        {
            //guna2DataGridView1.Rows.Clear();

            textStationName.Text = "";
            textLostCenterTel.Text = "";
            textLostCenterUrl.Text = "";
            
            comboLostCenter.Text = "";
            comboBicycleRack.Text = "";
            comboTransferParking.Text = "";
            comboPublicOffice.Text = "";
            comboTicket.Text = "";
            comboDisabledToilet.Text = "";
            comboStationOffice.Text = "";

            comboElevator.Text = "";
            comboWheelChairLift.Text = "";
            comboVisitorCenter.Text = "";
            comboAutomaticDispenser.Text = "";
            combolactationRoom.Text = "";
            comboLocker.Text = "";

            comboLostCenter.Items.Clear();
            comboBicycleRack.Items.Clear();
            comboTransferParking.Items.Clear();
            comboPublicOffice.Items.Clear();
            comboTicket.Items.Clear();
            comboDisabledToilet.Items.Clear();

            comboElevator.Items.Clear();
            comboWheelChairLift.Items.Clear();
            comboVisitorCenter.Items.Clear();
            comboAutomaticDispenser.Items.Clear();
            combolactationRoom.Items.Clear();
            comboLocker.Items.Clear();
            comboStationOffice.Items.Clear();
            
            comboLostCenter.Enabled = false;
            comboBicycleRack.Enabled = false;
            comboTransferParking.Enabled = false;
            comboStationOffice.Enabled = false;
            comboPublicOffice.Enabled = false;
            comboTicket.Enabled = false;
            comboDisabledToilet.Enabled = false;
            comboElevator.Enabled = false;
            comboWheelChairLift.Enabled = false;
            comboVisitorCenter.Enabled = false;
            comboAutomaticDispenser.Enabled = false;
            combolactationRoom.Enabled = false;
            comboLocker.Enabled = false;
            textLostCenterTel.Enabled = false;
            textLostCenterUrl.Enabled = false;
            textStationName.Enabled = false;
            btnAlter.Enabled = false;



        }


        public void btnAlter_Click(object sender, EventArgs e)
        {
            if (listClickCheck == true)
            {

                listClickCheck = false;


                bool check = itemCheck();

                if (check == false && MessageBox.Show("지하철 : " + textStationName.Text + "역 \n\n수정 내용을 적용 하시겠습니까?", "지하철 역 정보 수정", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sql.SetFacility(itemList[0],currItemList[0], currItemList[1], currItemList[2], currItemList[3], currItemList[4], currItemList[5], currItemList[6], currItemList[7], currItemList[8]
                        ,currItemList[9], currItemList[10], currItemList[11], currItemList[12], currItemList[13], currItemList[14], currItemList[15],strLog);
                    mainSql.Log(StaticMain.userName, StaticMain.userMac, "지하철 시설 정보 수정");

                    MessageBox.Show("DB 입력 완료", "알림");

                    listStationName_Click(sender, e);


                }
                else
                    return;
            }
        }

        public void Reset()
        {
            comboboxRegion.SelectedIndex = -1;
            comboBoxLaneType.SelectedIndex = -1;

            StationNameList();
            StationList();
            ValueClear();
        }

        public void listClickReset()
        {
            this.listClickCheck = false;
        }

        public bool itemCheck()
        {
            currItemList.Clear();
            bool check = true;
            strLog = "";

            currItemList.Add(textStationName.Text);
            currItemList.Add(ComboBoxValue(0, comboLostCenter.Text).ToString());
            currItemList.Add(ComboBoxValue(0, comboBicycleRack.Text).ToString());
            currItemList.Add(ComboBoxValue(0, comboTransferParking.Text).ToString());
            currItemList.Add(ComboBoxValue(0, comboStationOffice.Text).ToString());
            currItemList.Add(ComboBoxValue(0, comboPublicOffice.Text).ToString());
            currItemList.Add(ComboBoxValue(0, comboTicket.Text).ToString());

            currItemList.Add(ComboBoxValue(0, comboDisabledToilet.Text).ToString());
            currItemList.Add(ComboBoxValue(0, comboElevator.Text).ToString());
            currItemList.Add(ComboBoxValue(0, comboWheelChairLift.Text).ToString());
            currItemList.Add(ComboBoxValue(0, comboVisitorCenter.Text).ToString());

            currItemList.Add(ComboBoxValue(0, comboAutomaticDispenser.Text).ToString());
            currItemList.Add(ComboBoxValue(0, combolactationRoom.Text).ToString());
            currItemList.Add(ComboBoxValue(0, comboLocker.Text).ToString());

            currItemList.Add(textLostCenterTel.Text);
            currItemList.Add(textLostCenterUrl.Text);


            for (int i = 0; i < currItemList.Count; i++)
            {
                if (itemList[i + 1] != currItemList[i])
                {
                    check = false;

                    if (strLog != "")
                        strLog += " | ";

                    if (i == 1)
                        strLog += "LostCenter : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 2)
                        strLog += "BicycleRack : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 3)
                        strLog += "TransferParking : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 4)
                        strLog += "StationOffice : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 5)
                        strLog += "PublicOffice : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 6)
                        strLog += "Ticket : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 7)
                        strLog += "DisabledToilet : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 8)
                        strLog += "Elevator : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 9)
                        strLog += "WheelChairLift : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 10)
                        strLog += "VisitorCenter : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 11)
                        strLog += "AutomaticDispenser : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 12)
                        strLog += "LactationRoom : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 13)
                        strLog += "Locker : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 14)
                        strLog += "lostcenter_tel : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 15)
                        strLog += "lostcenter_url : " + itemList[i + 1] + " => " + currItemList[i];

                }
            }

            return check;

        }
    }
}
