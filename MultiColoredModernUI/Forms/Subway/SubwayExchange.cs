﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiColoredModernUI.Forms.Subway
{
    public partial class SubwayExchange : Form
    {

        MssqlSubway sql = new MssqlSubway();
        Mssql mainSql = new Mssql();
        bool listClickCheck = false;
        List<string> itemList = new List<string>();
        List<string> currItemList = new List<string>();
        string strLog = "";

        public SubwayExchange()
        {
            InitializeComponent();
            sql.GetRegion();
            RegionAdd();
            StationNameList();
            StationList();
            ValueClear();

            //StationList();
            //ValueClear();
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
            sql.GetExChangeStationName(cityCode, laneType);
            StationNameItemAdd();
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

                sql.GetSubwayExchange(stationID);

                ValueClear();

                StationItemAdd();

                listStation_Click(sender, e);
            }

        }

         
        private void listStation_Click(object sender, EventArgs e)
        {


            int currIndex = 0;


            currIndex = guna2DataGridView1.SelectedRows.Count;
            

            if (currIndex != -1)
            {
                textExchangeTime1.Enabled = true;
                textExchangeTime2.Enabled = true;
                textExchangeTime3.Enabled = true;
                textExchangeTime4.Enabled = true;
                textTrain1.Enabled = true;
                textDoor1.Enabled = true;
                textTrain2.Enabled = true;
                textDoor2.Enabled = true;
                textTrain3.Enabled = true;
                textDoor3.Enabled = true;
                textTrain4.Enabled = true;
                textDoor4.Enabled = true;


                textStationID.Text = StaticSubway.stations[currIndex][0].ToString();
                textStationName.Text = StaticSubway.stations[currIndex][1].ToString();
                textLane1.Text = StaticSubway.stations[currIndex][2].ToString();

                textStationID2.Text = StaticSubway.stations[currIndex][3].ToString();
                textLane2.Text = StaticSubway.stations[currIndex][5].ToString();

                textExchangeTime1.Text = StaticSubway.stations[currIndex][6].ToString();
                textExchangeTime2.Text = StaticSubway.stations[currIndex][7].ToString();
                textExchangeTime3.Text = StaticSubway.stations[currIndex][8].ToString();
                textExchangeTime4.Text = StaticSubway.stations[currIndex][9].ToString();                  

                textTrain1.Text = StaticSubway.stations[currIndex][10].ToString();
                textDoor1.Text = StaticSubway.stations[currIndex][11].ToString();
                textTrain2.Text = StaticSubway.stations[currIndex][12].ToString();
                textDoor2.Text = StaticSubway.stations[currIndex][13].ToString();
                textTrain3.Text = StaticSubway.stations[currIndex][14].ToString();
                textDoor3.Text = StaticSubway.stations[currIndex][15].ToString();
                textTrain4.Text = StaticSubway.stations[currIndex][16].ToString();
                textDoor4.Text = StaticSubway.stations[currIndex][17].ToString();

                itemList.Clear();

                itemList.AddRange(StaticSubway.stations[currIndex].ToList());
            }

            //textStationLaneID1.Text = StaticSubway.stations[currIndex][0].ToString();
            //textStationLaneID2.Text = StaticSubway.stations[currIndex][4].ToString();

        }

        private void StationList()
        {/*
            listStation.Clear();
            listStation.View = View.Details;
            listStation.GridLines = true;
            listStation.FullRowSelect = true;


            listStation.Columns.Add("SSID1", 0);
            listStation.Columns.Add("역 이름", 0);
            listStation.Columns.Add("하차노선", 100);
            listStation.Columns.Add("SSID2", 0);
            listStation.Columns.Add("Namekor2", 0);
            listStation.Columns.Add("승차노선", 100);
            
            listStation.Columns.Add("소요시간1",100);
            listStation.Columns.Add("소요시간2", 100);
            listStation.Columns.Add("소요시간3", 100);
            listStation.Columns.Add("소요시간4", 100);
            listStation.Columns.Add("하차 열차1", 100);
            listStation.Columns.Add("하차 문1", 100);
            listStation.Columns.Add("하차 열차2", 100);
            listStation.Columns.Add("하차 문2", 100);
            listStation.Columns.Add("하차 열차3", 100);
            listStation.Columns.Add("하차 문3", 100);
            listStation.Columns.Add("하차 열차4", 100);
            listStation.Columns.Add("하차 문4", 100);

            */
            //listStation.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //listStation.Columns[0].Width = 0;


            guna2DataGridView1.Columns[0].Visible = false;
            guna2DataGridView1.Columns[1].Visible = false;
            guna2DataGridView1.Columns[3].Visible = false;
            guna2DataGridView1.Columns[4].Visible = false;


        }

        public void ValueClear()
        {
            textStationName.Text = "";
            textLane1.Text = "";
            textLane2.Text = "";
            textExchangeTime1.Text = "";
            textExchangeTime2.Text = "";
            textExchangeTime3.Text = "";
            textExchangeTime4.Text = "";

            textTrain1.Text = "";
            textDoor1.Text = "";
            textTrain2.Text = "";
            textDoor2.Text = "";
            textTrain3.Text = "";
            textDoor3.Text = "";
            textTrain4.Text = "";
            textDoor4.Text = "";
            textStationID.Text = "";
            textStationID2.Text = "";

            textStationName.Enabled = false;
            textLane1.Enabled = false;
            textLane2.Enabled = false;
            textExchangeTime1.Enabled = false;
            textExchangeTime2.Enabled = false;
            textExchangeTime3.Enabled = false;
            textExchangeTime4.Enabled = false;
            textTrain1.Enabled = false;
            textDoor1.Enabled = false;
            textTrain2.Enabled = false;
            textDoor2.Enabled = false;
            textTrain3.Enabled = false;
            textDoor3.Enabled = false;
            textTrain4.Enabled = false;
            textDoor4.Enabled = false;


            textStationID.Enabled = false;
            textStationID2.Enabled = false;



        }
        /*
        private void btnChangeStation_Click(object sender, EventArgs e)
        {
            IEnumerator enm = listStation.SelectedIndices.GetEnumerator();

            int currIndex = 0;

            while (enm.MoveNext())
            {
                currIndex = (int)enm.Current;
            }

            long stationID1 = Convert.ToInt32(StaticSubway.stations[currIndex][1].ToString());
            long stationID2 = Convert.ToInt32(StaticSubway.stations[currIndex][5].ToString());

            sql.GetSubwayExchange(stationID2, 0);

            StationItemAdd();

            listStation_Click(sender, e);
        }
        */
        public void btnAlter_Click(object sender, EventArgs e)
        {
            if (listClickCheck == true)
            {

                listClickCheck = false;

                int currIndex = 0;


                currIndex = guna2DataGridView1.SelectedRows.Count;


                bool check = itemCheck();
                
            
                if (check == false && MessageBox.Show("지하철 : " + textStationName.Text + "역 \n\n수정 내용을 적용 하시겠습니까?", "지하철 빠른 환승 수정", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sql.setSubwayExchange(itemList[0], itemList[3], itemList[1],currItemList[0], currItemList[1], currItemList[2], currItemList[3], currItemList[4], currItemList[5], currItemList[6], currItemList[7], currItemList[8], currItemList[9], currItemList[10], currItemList[11],strLog, currItemList[12]);

                    mainSql.Log(StaticMain.userName, StaticMain.userMac, "지하철 빠른 환승 수정");

                    MessageBox.Show("DB 입력 완료", "알림");

                    listStationName_Click(sender, e);
                }
                else
                {

                    return;
                }
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


            int exchangeCount = 0;

            int sum = 0;

            if (Convert.ToInt16(textExchangeTime1.Text) > 0)
            {
                sum += Convert.ToInt16(textExchangeTime1.Text);
                exchangeCount++;
            }
            

            if (Convert.ToInt16(textExchangeTime2.Text) > 0)
            {
                sum += Convert.ToInt16(textExchangeTime2.Text);
                exchangeCount++;
            }
            

            if (Convert.ToInt16(textExchangeTime3.Text) > 0)
            {
                sum += Convert.ToInt16(textExchangeTime3.Text);
                exchangeCount++;
            }
            


            if (Convert.ToInt16(textExchangeTime4.Text) > 0)
            {
                sum += Convert.ToInt16(textExchangeTime4.Text);
                exchangeCount++;
            }
            


            currItemList.Add(textExchangeTime1.Text);
            currItemList.Add(textExchangeTime2.Text);
            currItemList.Add(textExchangeTime3.Text);
            currItemList.Add(textExchangeTime4.Text);
            currItemList.Add(textTrain1.Text);
            currItemList.Add(textDoor1.Text);
            currItemList.Add(textTrain2.Text);
            currItemList.Add(textDoor2.Text);
            currItemList.Add(textTrain3.Text);
            currItemList.Add(textDoor3.Text);
            currItemList.Add(textTrain4.Text);
            currItemList.Add(textDoor4.Text);

            for (int i = 0; i < currItemList.Count; i++)
            {
                if (itemList[i + 6] != currItemList[i])
                {
                    check = false;

                    if (strLog != "")
                        strLog += " | ";

                    if (i == 0) 
                        strLog += "ExchangeTime1 : " + itemList[i + 6] + " => " + currItemList[i];
                    else if (i == 1)
                        strLog += "ExchangeTime2 : " + itemList[i + 6] + " => " + currItemList[i];
                    else if (i == 2)
                        strLog += "ExchangeTime3 : " + itemList[i + 6] + " => " + currItemList[i];
                    else if (i == 3)
                        strLog += "ExchangeTime4 : " + itemList[i + 6] + " => " + currItemList[i];
                    else if (i == 4)
                        strLog += "FastExTrain1 : " + itemList[i + 6] + " => " + currItemList[i];
                    else if (i == 5)
                        strLog += "FastExDoor1 : " + itemList[i + 6] + " => " + currItemList[i];
                    else if (i == 6)
                        strLog += "FastExTrain2 : " + itemList[i + 6] + " => " + currItemList[i];
                    else if (i == 7)
                        strLog += "FastExDoor2 : " + itemList[i + 6] + " => " + currItemList[i];
                    else if (i == 8)
                        strLog += "FastExTrain3 : " + itemList[i + 6] + " => " + currItemList[i];
                    else if (i == 9)
                        strLog += "FastExDoor3 : " + itemList[i + 6] + " => " + currItemList[i];
                    else if (i == 10)
                        strLog += "FastExTrain4 : " + itemList[i + 6] + " => " + currItemList[i];
                    else if (i == 11)
                        strLog += "FastExDoor4 : " + itemList[i + 6] + " => " + currItemList[i];

                }
            }

            if(exchangeCount != 0)
                currItemList.Add((sum / exchangeCount).ToString());


            return check;

        }

        public string textLimit(string text)
        {


            string iLimit = "0";

            if (Convert.ToInt16(text) < -3)
                return iLimit;

            return text;
        }

        private void textTrain1_TextChanged(object sender, EventArgs e)
        {
            Regex rx = new Regex(@"^[+-]?\d");

            if (rx.IsMatch(textTrain1.Text))
            {
                textTrain1.Text = textLimit(textTrain1.Text);
            }
        }

        private void textTrain2_TextChanged(object sender, EventArgs e)
        {
            Regex rx = new Regex(@"^[+-]?\d");

            if (rx.IsMatch(textTrain2.Text))
            {
                textTrain2.Text = textLimit(textTrain2.Text);
            }
        }

        private void textTrain3_TextChanged(object sender, EventArgs e)
        {
            Regex rx = new Regex(@"^[+-]?\d");

            if (rx.IsMatch(textTrain3.Text))
            {
                textTrain3.Text = textLimit(textTrain3.Text);
            }
        }

        private void textTrain4_TextChanged(object sender, EventArgs e)
        {
            Regex rx = new Regex(@"^[+-]?\d");

            if (rx.IsMatch(textTrain4.Text))
            {
                textTrain4.Text = textLimit(textTrain4.Text);
            }
        }

        private void textDoor1_TextChanged(object sender, EventArgs e)
        {
            Regex rx = new Regex(@"^[+-]?\d");

            if (rx.IsMatch(textDoor1.Text))
            {
                textDoor1.Text = textLimit(textDoor1.Text);
            }
        }

        private void textDoor2_TextChanged(object sender, EventArgs e)
        {
            Regex rx = new Regex(@"^[+-]?\d");

            if (rx.IsMatch(textDoor2.Text))
            {
                textDoor2.Text = textLimit(textDoor2.Text);
            }
        }

        private void textDoor3_TextChanged(object sender, EventArgs e)
        {
            Regex rx = new Regex(@"^[+-]?\d");

            if (rx.IsMatch(textDoor3.Text))
            {
                textDoor3.Text = textLimit(textDoor3.Text);
            }
        }

        private void textDoor4_TextChanged(object sender, EventArgs e)
        {
            Regex rx = new Regex(@"^[+-]?\d");

            if (rx.IsMatch(textDoor4.Text))
            {
                textDoor4.Text = textLimit(textDoor4.Text);
            }
        }
    }
}
