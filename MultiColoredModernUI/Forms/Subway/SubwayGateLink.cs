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
    public partial class SubwayGateLink : Form
    {
        MssqlSubway sql = new MssqlSubway();
        Mssql mainSql = new Mssql();
        bool listClickCheck = false;
        List<List<string>> strLogList = new List<List<string>>();
        List<string> strLog = new List<string>();

        public SubwayGateLink()
        {
            InitializeComponent();

            sql.GetRegion();
            RegionAdd();
            StationNameList();
            StationList();
            //ValueClear();
            ItemClear();

        }

        public void RegionAdd()
        {
            for (int i = 0; i < StaticSubway.regions.Count; i++)
            {
                comboboxRegion.Items.Add(StaticSubway.regions[i][1].ToString());
            }

            comboboxRegion.ForeColor = Color.Black;
            comboboxRegion.ItemsAppearance.ForeColor = Color.Black;
            comboboxRegion.HoverState.BorderColor = Color.LightGray;

        }

        private void StationNameList()
        {
            listStationName.Rows.Clear();

        }

        private void comboboxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            listStationName.Rows.Clear();
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
            ItemClear();
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
                ItemClear();
            }
            else
                return;


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
            listStation.Items.Clear();
            listStation.Refresh();

            for (int i = 0; i < StaticSubway.gateLinks.Count; i++)
            {
                string[] str = StaticSubway.gateLinks[i].ToArray();

                ListViewItem item = new ListViewItem(str);

                listStation.Items.Add(item);
            }
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


                ItemClear();

                long stationID = Convert.ToInt32(StaticSubway.stationNames[currIndex][0].ToString());


                sql.GetGateLink(stationID, "");
                comGateNo.Items.Clear();
                StationItemAdd();
                ComboBoxValueAdd();
                textStationName.Text = StaticSubway.gateLinks[0][5].ToString();

                ItemEnabled();
            }

            //textGateInfo.Enabled = false;
            //tabControl1.TabPages checkBoxCnstruction.Enabled = false;

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
                ItemClear();

            }
            else
                MessageBox.Show("지역을 선택해 주세요");


        }

        private void StationList()
        {
            listStation.Clear();
            listStation.View = View.Details;
            listStation.GridLines = true;
            listStation.FullRowSelect = true;


            listStation.Columns.Add("지하철역 ID", 0);
            listStation.Columns.Add("출구 번호",149);
            listStation.Columns.Add("출구 정보 순서",0);
            listStation.Columns.Add("도시 코드", 0);
            listStation.Columns.Add("출구 정보",700);
            listStation.Columns.Add("지하철역 이름",0);


        }

        private void listStation_Click(object sender, EventArgs e)
        {


            IEnumerator enm = listStation.SelectedIndices.GetEnumerator();

            int currIndex = -1;

            while (enm.MoveNext())
            {
                currIndex = (int)enm.Current;
            }

            //ComboBoxValueAdd();
            if (currIndex != -1)
            {
                textGateInfo.Enabled = true;
                btnAlter.Enabled = true;


                textStationName.Text = StaticSubway.gateLinks[0][5].ToString();
                textGateNoAlter.Text = StaticSubway.gateLinks[currIndex][1].ToString();
                textGateInfo.Text = StaticSubway.gateLinks[currIndex][4].ToString();
                textGateNoAdd.Text = StaticSubway.gateLinks[currIndex][1].ToString();

                checkBoxCnstruction.Checked = false;

               

            }
            /*
            textGateInfo.Enabled = false;
            */
            
            

        }

        private void comGateNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            textGateInfo.Text = "";
            textGateNoAlter.Text = "";



            long stationID = Convert.ToInt32(StaticSubway.gateLinks[0][0].ToString());

            sql.GetGateLink(stationID, comGateNo.SelectedItem.ToString());

            StationItemAdd();


            if (comGateNo.SelectedItem.ToString() == "전체")
            {
                //textGateInfo.Enabled = false;
                checkBoxCnstruction.Enabled = false;
                //btnGateInfoAlter.Enabled = false;
            }
            else
            {
                //textGateInfo.Enabled = true;
                checkBoxCnstruction.Enabled = true;
                //btnGateInfoAlter.Enabled = true;

                checkBoxCnstruction.Checked = false;

                this.listStation.Items[0].Focused = true;
                this.listStation.Items[0].Selected = true;
                
                listStation_Click(sender, e);

            }
        }

        public void ComboBoxValueAdd()
        {
            comGateNo.Items.Add("전체");

            string str = "";
            string str2 = "";

            for (int i = 0; i < StaticSubway.gateLinks.Count; i++)
            {
                str2 = StaticSubway.gateLinks[i][1].ToString();

                if (str != str2)
                {
                    str = str2;
                    comGateNo.Items.Add(StaticSubway.gateLinks[i][1].ToString());
                    
                }

            }

            comGateNo.SelectedIndex = 0;
        }

        private void btnGateInfoAdd_Click(object sender, EventArgs e)
        {

            bool itemCheck = false;

            long stationID = Convert.ToInt32(StaticSubway.gateLinks[0][0].ToString());
            string namekor = textStationName.Text;
            string gateNo = textGateNoAdd.Text;
            string[] linkKors = textGateInfoAdd.Text.Split(',');
            string linkkor = "";

            for (int i = 0; i < comGateNo.Items.Count; i++)
            {

                if (comGateNo.Items[i].ToString() != gateNo)
                {
                    continue;
                }
                else
                {
                    itemCheck = true;
                    break;
                }
                 
            }

            if (itemCheck == true)
            {

                for (int i = 0; i < linkKors.Length; i++)
                {
                    

                    linkkor = linkKors[i].Replace(" ", "");
                    linkkor = linkkor.Replace("\r", "");
                    linkkor = linkkor.Replace("\n", "");
                    linkkor = linkkor.Replace(",", "");


                    if (!sql.setGateLinkAdd(stationID, gateNo, linkkor))
                        MessageBox.Show(linkkor + "의 출구 정보가 이미 존재 합니다.");
                    else
                    {
                        strLog.Add(stationID.ToString());
                        strLog.Add(namekor);
                        strLog.Add(gateNo);
                        strLog.Add(gateNo + "번 출구 => " + linkkor + " 출구 정보 추가");
                        strLogList.Add(strLog.ToList());
                        strLog.Clear();
                    }

                }

                comGateNo.SelectedItem = gateNo;
                comGateNo_SelectedIndexChanged(sender, e);
            }
            else
            {
                MessageBox.Show("새로운 출구는 등록 할 수 없습니다.");
            }


            textGateInfoAdd.Text = "";

            



        }

        private void btnGateInfoAlter_Click(object sender, EventArgs e)
        {

            IEnumerator enm = listStation.SelectedIndices.GetEnumerator();

            int currIndex = 0;

            while (enm.MoveNext())
            {
                currIndex = (int)enm.Current;
            }

            listClickCheck = true;

            long stationID = Convert.ToInt32(StaticSubway.gateLinks[currIndex][0].ToString());
            string gateNo = textGateNoAlter.Text;
            int idx = Convert.ToInt16(StaticSubway.gateLinks[currIndex][2].ToString());
            int cityCode = Convert.ToInt16(StaticSubway.gateLinks[currIndex][3].ToString());
            string linkKor = textGateInfo.Text;
            string namekor = textStationName.Text;


            if (checkBoxCnstruction.Checked == true)
            {
                if(MessageBox.Show(textGateNoAlter.Text + "번 출구를 공사중으로 변경 하시겠습니까?","수정 알림 창", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sql.setGateLinkAlter(stationID, gateNo, 0, "공사중", "");
                    sql.delGateLink(stationID, gateNo, -1);

                    strLog.Add(stationID.ToString());
                    strLog.Add(namekor);
                    strLog.Add(gateNo);
                    strLog.Add(gateNo + "번 출구 => 공사중");
                    strLogList.Add(strLog.ToList());
                    strLog.Clear();
                    
                }
            }
            else
            {
                sql.setGateLinkAlter(stationID, gateNo, idx, linkKor, namekor);
                
                strLog.Add(stationID.ToString());
                strLog.Add(namekor);
                strLog.Add(gateNo);
                strLog.Add(gateNo + "번 출구 => " + StaticSubway.gateLinks[currIndex][4].ToString() + " -> " + linkKor + " 수정");
                strLogList.Add(strLog.ToList());
                strLog.Clear();

            }
            


            comGateNo_SelectedIndexChanged(sender, e);

        }

        private void checkBoxCnstruction_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCnstruction.Checked == true)
            {
                textGateInfo.Text = "";
                textGateInfo.Enabled = false;
                btnGateInfoAlter.Enabled = true;
            }
            else
            {

                long stationID = Convert.ToInt32(StaticSubway.gateLinks[0][0].ToString());

                sql.GetGateLink(stationID, comGateNo.SelectedItem.ToString());

                StationItemAdd();

                textGateInfo.Enabled = true;

                btnGateInfoAlter.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {


            IEnumerator enm = listStation.SelectedIndices.GetEnumerator();

            int currIndex = 0;

            while (enm.MoveNext())
            {
                currIndex = (int)enm.Current;
            }

            listClickCheck = true;

            long stationID = Convert.ToInt32(StaticSubway.gateLinks[currIndex][0].ToString());
            string gateNo = textGateNoAlter.Text;
            int idx = Convert.ToInt16(StaticSubway.gateLinks[currIndex][2].ToString());
            int cityCode = Convert.ToInt16(StaticSubway.gateLinks[currIndex][3].ToString());
            string linkKor = textGateInfo.Text;
            string namekor = textStationName.Text;


            if (sql.delGateLink(stationID, gateNo, idx))
            {
                MessageBox.Show("출구 정보 삭제 완료");
                
                strLog.Add(stationID.ToString());
                strLog.Add(namekor);
                strLog.Add(gateNo);
                strLog.Add(gateNo + "번 출구 => " + linkKor + " 삭제");
                strLogList.Add(strLog.ToList());
                strLog.Clear();
            }
            else
                MessageBox.Show("출구 정보가 하나만 있을 경우 삭제 할 수 없습니다. ");

            comGateNo_SelectedIndexChanged(sender, e);

        }

        public void ItemClear()
        {
            btnGateInfoAdd.Enabled = false;
            btndel.Enabled = false;
            btnDelete.Enabled = false;
            btnAlter.Enabled = false;
            btnGateInfoAlter.Enabled = false;

            textStationName.Enabled = false;
            textGateNoAlter.Enabled = false;
            textGateNoAdd.Enabled = false;
            textGateInfo.Enabled = false;
            textGateInfoAdd.Enabled = false;
            checkBoxCnstruction.Enabled = false;
          
            textStationName.Text = "";
            textGateNoAlter.Text = "";
            textGateNoAdd.Text = "";
            textGateInfo.Text = "";
            textGateInfoAdd.Text = "";
            checkBoxCnstruction.Checked = false;
            comGateNo.Items.Clear();

            listStation.Clear();
            StationList();

        }

        public void ItemEnabled()
        {
            textGateInfoAdd.Enabled = true;
            textGateNoAdd.Enabled = true;
            btndel.Enabled = true;
            btnDelete.Enabled = true;


        }

        private void textGateInfo_TextChanged(object sender, EventArgs e)
        {
            if (textGateInfo.Text != "")
                btnGateInfoAlter.Enabled = true;
            else
                btnGateInfoAlter.Enabled = false;
        }

        public void btnAlter_Click(object sender, EventArgs e)
        {
            if (listClickCheck == true)
            {
                listClickCheck = false;

                bool check = sql.CheckGateLink();

                if (check == true && MessageBox.Show("지하철 : " + textStationName.Text + "역 \n\n수정 내용을 적용 하시겠습니까?", "지하철 출구 정보 수정", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    sql.applyGateLink(strLogList);
                    
                    mainSql.Log(StaticMain.userName, StaticMain.userMac, "지하철 출구 정보 수정");

                    MessageBox.Show("DB 입력 완료", "알림");

                    strLogList.Clear();
                }
            }

        }

        public void Reset()
        {
            comboboxRegion.SelectedIndex = 0;
            comboBoxLaneType.SelectedIndex = -1;

            guna2TextBox1.Text = "";
            StationNameList();
            ItemClear();
        }

        public void listClickReset()
        {
            this.listClickCheck = false;
        }

        private void textGateInfoAdd_TextChanged(object sender, EventArgs e)
        {
            if (textGateInfoAdd.Text != "")
                btnGateInfoAdd.Enabled = true;
            else
                btnGateInfoAdd.Enabled = false;
        }

        private void guna2TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button1_Click(sender, e);
            }

        }

        private void guna2TextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBoxLaneType.SelectedIndex > -1)
                comboBoxLaneType.SelectedIndex = -1;
        }
    }
}
