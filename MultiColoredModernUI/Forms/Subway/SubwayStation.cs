using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiColoredModernUI.Forms.Subway
{
    public partial class SubwayStation : Form
    {
        MssqlSubway sql = new MssqlSubway();
        Mssql mainSql = new Mssql();
        bool listClickCheck = false;
        List<string> itemList = new List<string>();
        List<string> currItemList = new List<string>();
        string strLog = "";

        public SubwayStation()
        {
            InitializeComponent();
            sql.GetRegion();
            RegionAdd();
            StationNameList();
            StationList();
            ValueClear();

        }


        public void RegionAdd()
        {
            for(int i = 0; i < StaticSubway.regions.Count; i++)
            {
                comboboxRegion.Items.Add(StaticSubway.regions[i][1].ToString());
            }

            comboboxRegion.ForeColor = Color.Black;
            comboboxRegion.ItemsAppearance.ForeColor = Color.Black;
            comboboxRegion.HoverState.BorderColor = Color.LightGray;


        } 

        private void comboboxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            listStationName.Rows.Clear();
            listStationName.Refresh();

            int i =  comboboxRegion.SelectedIndex;


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

        private void StationNameList()
        {
            listStationName.Rows.Clear();
            
        }

        private void StationList()
        {

            guna2DataGridView1.Columns[0].Visible = false;

        }

        public void StationNameItemAdd()
        {
            listStationName.Rows.Clear();
            listStationName.Refresh();

            for (int i = 0; i < StaticSubway.stationNames.Count; i++)
            {

                string[] str = StaticSubway.stationNames[i].ToArray();
                
                listStationName.Rows.Add(str.ToArray());

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

            guna2TextBox1.Text = "";

            btnAlter_Click(sender, e);

            listClickCheck = false;

        
            if (i != -1 && j != -1)
            {
                laneType = Convert.ToInt16(StaticSubway.laneTypes[j][1].ToString());
                cityCode = Convert.ToInt16(StaticSubway.regions[i][0].ToString());

                listStationName.Columns[1].Visible = false;
                sql.GetLaneType(cityCode);
                sql.GetStationName(cityCode, laneType);
                StationNameItemAdd();
                guna2DataGridView1.Rows.Clear();
                ValueClear();
            }
            else
                return;


            
        }


        private void listStation_Click(object sender, EventArgs e)
        {



            int currIndex = -1;


            //currIndex = guna2DataGridView1.CurrentCell.RowIndex;
            bool currRow = guna2DataGridView1.CurrentRow.Selected;

            if (currRow == true)
                currIndex = guna2DataGridView1.CurrentCell.RowIndex;

            if (currIndex != -1)
            {
                ComboBoxValueAdd();

                textStationName.Text = StaticSubway.stations[currIndex][1].ToString();
                textStationAliaskor.Text = StaticSubway.stations[currIndex][2].ToString();
                textStationX.Text = StaticSubway.stations[currIndex][3].ToString();
                textStationY.Text = StaticSubway.stations[currIndex][4].ToString();
                comboStationPlatform.SelectedIndex = ComboBoxValue(Convert.ToInt16(StaticSubway.stations[currIndex][5].ToString()), "");
                comboStationRestRoom.SelectedIndex = ComboBoxValue(Convert.ToInt16(StaticSubway.stations[currIndex][6].ToString()), "");
                comboStationCrossOver.SelectedIndex = ComboBoxValue(Convert.ToInt16(StaticSubway.stations[currIndex][7].ToString()), "");
                comboStationMeetingPlace.SelectedIndex = ComboBoxValue(Convert.ToInt16(StaticSubway.stations[currIndex][8].ToString()), "");
                comboStationPublicOffice.SelectedIndex = ComboBoxValue(Convert.ToInt16(StaticSubway.stations[currIndex][9].ToString()), "");
                comboStationOffDoor.SelectedIndex = ComboBoxValue(Convert.ToInt16(StaticSubway.stations[currIndex][10].ToString()), "");
                textStationBicycle.Text = StaticSubway.stations[currIndex][11].ToString();
                textStationTel.Text = StaticSubway.stations[currIndex][12].ToString();
                textStationAddress.Text = StaticSubway.stations[currIndex][13].ToString();
                textStationRoadAddress.Text = StaticSubway.stations[currIndex][14].ToString();

                itemList.Clear();

                itemList.AddRange(StaticSubway.stations[currIndex].ToList());

                comboStationPlatform.Enabled = true;
                comboStationRestRoom.Enabled = true;
                comboStationCrossOver.Enabled = true;
                comboStationMeetingPlace.Enabled = true;
                comboStationPublicOffice.Enabled = true;
                comboStationOffDoor.Enabled = true;


            }

        }

        public void ComboBoxValueAdd()
        {

            ValueClear();

            string[] restRoom = { "0:없음", "1:개찰구안쪽", "2:개찰구바깥쪽", "3:환승역연결", "4:안쪽/바깥쪽" };
            string[] platForm = { "0:기타", "1:중앙(섬식)", "2:양쪽(상대식)", "3:복선(국철)", "4:일방향" };
            string[] crossOver = { "0:기타", "1:연결안됨", "2:연결됨", "3:환승역으로연결" };
            string[] meetPlace = { "0:없음", "1:있음" };
            string[] publicOffice = { "0:없음", "1:있음" };
            string[] offDoor = { "0:왼쪽", "1:오른쪽", "2:양쪽" };
            
            comboStationPlatform.Items.AddRange(platForm.ToArray());
            comboStationRestRoom.Items.AddRange(restRoom.ToArray());
            comboStationCrossOver.Items.AddRange(crossOver.ToArray());
            comboStationMeetingPlace.Items.AddRange(meetPlace.ToArray());
            comboStationPublicOffice.Items.AddRange(publicOffice.ToArray());
            comboStationOffDoor.Items.AddRange(offDoor.ToArray());
            
            //textStationAliaskor.Enabled = true;
            //textStationName.Enabled = true;
            //textStationX.Enabled = true;
            //textStationY.Enabled = true;
            textStationBicycle.Enabled = true;
            textStationTel.Enabled = true;
            textStationAddress.Enabled = true;
            textStationRoadAddress.Enabled = true;

            comboStationPlatform.Enabled = true;
            comboStationRestRoom.Enabled = true;
            comboStationCrossOver.Enabled = true;
            comboStationMeetingPlace.Enabled = true;
            comboStationPublicOffice.Enabled = true;
            comboStationOffDoor.Enabled = true;

            btnAlter.Enabled = true;

        }

        public int ComboBoxValue(int iValue,string sValue)
        {
            if(sValue != "")
            {
                int i = sValue.IndexOf(":", 0);

                iValue = Convert.ToInt16(sValue.Substring(0, i));
            }

            return iValue;
        }

        public void ValueClear()
        {
            textStationAliaskor.Text = "";
            textStationName.Text = "";
            textStationX.Text = "";
            textStationY.Text = "";
            textStationBicycle.Text = "";
            textStationTel.Text = "";
            textStationAddress.Text = "";
            textStationRoadAddress.Text = "";

            
            comboStationPlatform.Text = "";
            comboStationRestRoom.Text = "";
            comboStationCrossOver.Text = "";
            comboStationMeetingPlace.Text = "";
            comboStationPublicOffice.Text = "";
            comboStationOffDoor.Text = "";

            comboStationPlatform.Items.Clear();
            comboStationRestRoom.Items.Clear();
            comboStationCrossOver.Items.Clear();
            comboStationMeetingPlace.Items.Clear();
            comboStationPublicOffice.Items.Clear();
            comboStationOffDoor.Items.Clear();
          

            textStationAliaskor.Enabled = false;
            textStationName.Enabled = false;
            textStationX.Enabled = false;
            textStationY.Enabled = false;
            textStationBicycle.Enabled = false;
            textStationTel.Enabled = false;
            textStationAddress.Enabled = false;
            textStationRoadAddress.Enabled = false;

            comboStationPlatform.Enabled = false;
            comboStationRestRoom.Enabled = false;
            comboStationCrossOver.Enabled = false;
            comboStationMeetingPlace.Enabled = false;
            comboStationPublicOffice.Enabled = false;
            comboStationOffDoor.Enabled = false;
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
                    sql.SetStation(itemList[0], currItemList[0], currItemList[1], currItemList[2], currItemList[3], currItemList[4], currItemList[5], currItemList[6], currItemList[7], currItemList[8], currItemList[9], currItemList[10], currItemList[11], currItemList[12], currItemList[13],strLog);
                    mainSql.Log(StaticMain.userName, StaticMain.userMac, "지하철 역 정보 수정");

                    MessageBox.Show("DB 입력 완료", "알림");

                    listStationName_Click(sender, e);
                }
                else
                    return;
            }


        }

        public void Reset()
        {
            comboboxRegion.SelectedIndex = 0;
            comboBoxLaneType.SelectedIndex = -1;

            guna2TextBox1.Text = "";
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
            currItemList.Add(textStationAliaskor.Text);
            currItemList.Add(textStationX.Text);
            currItemList.Add(textStationY.Text);
            currItemList.Add(ComboBoxValue(0, comboStationPlatform.Text).ToString());
            currItemList.Add(ComboBoxValue(0, comboStationRestRoom.Text).ToString());
            currItemList.Add(ComboBoxValue(0, comboStationCrossOver.Text).ToString());
            currItemList.Add(ComboBoxValue(0, comboStationMeetingPlace.Text).ToString());
            currItemList.Add(ComboBoxValue(0, comboStationPublicOffice.Text).ToString());
            currItemList.Add(ComboBoxValue(0, comboStationOffDoor.Text).ToString());
            currItemList.Add(textStationBicycle.Text);
            currItemList.Add(textStationTel.Text);
            currItemList.Add(textStationAddress.Text);
            currItemList.Add(textStationRoadAddress.Text);

            for(int i = 0; i < currItemList.Count; i++)
            {
                if (itemList[i + 1] != currItemList[i])
                {
                    check = false;

                    if (strLog != "")
                        strLog += " | ";

                    if (i == 4)
                        strLog += "Platform : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 5)
                        strLog += "RestRoom : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 6)
                        strLog += "CrossOver : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 7)
                        strLog += "MeetingPlace : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 8)
                        strLog += "PublicOffice : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 9)
                        strLog += "OffDoor : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 10)
                        strLog += "Bicycle : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 11)
                        strLog += "Tel : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 12)
                        strLog += "AddressKor : " + itemList[i + 1] + " => " + currItemList[i];
                    else if (i == 13)
                        strLog += "RoadAddress : " + itemList[i + 1] + " => " + currItemList[i];

                }
            }

            return check;

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int laneType = -1;
            int cityCode = -1;

            

            int i = comboboxRegion.SelectedIndex;

            string search = guna2TextBox1.Text;
            
            btnAlter_Click(sender, e);

            listClickCheck = false;

            if (i != -1)
            {
                cityCode = Convert.ToInt16(StaticSubway.regions[i][0].ToString());

                sql.GetLaneType(cityCode);
                sql.GetStationSearch(cityCode, search);
                StationNameItemAdd();
                listStationName.Columns[1].Visible = true;

                guna2DataGridView1.Rows.Clear();
                ValueClear();
            }
            else
                MessageBox.Show("지역을 선택해 주세요");

            
        }



        private void listStationName_Click(object sender, EventArgs e)
        {
            bool indexCheck = listStationName.CurrentCell.Selected;

            int currIndex = -1;

            if (indexCheck == true)
                currIndex = listStationName.CurrentCell.RowIndex;

            if (currIndex != -1)
            {
                btnAlter_Click(sender, e);

                listClickCheck = true;

                long stationID = Convert.ToInt32(StaticSubway.stationNames[currIndex][0].ToString());

                sql.GetStation(stationID);
                StationItemAdd();

                ValueClear();

                listStation_Click(sender, e);
            }
        }


        private void guna2TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                guna2Button1_Click(sender, e);
            }

        }

        private void guna2TextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(comboBoxLaneType.SelectedIndex > -1)
                comboBoxLaneType.SelectedIndex = -1;
        }
    }
}
