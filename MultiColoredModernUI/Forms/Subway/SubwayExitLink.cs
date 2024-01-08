using System;
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
    public partial class SubwayExitLink : Form
    {
        MssqlSubway sql = new MssqlSubway();
        Mssql mainSql = new Mssql();
        bool listClickCheck = false;
        List<string> itemList = new List<string>();
        List<string> currItemList = new List<string>();
        string strLog = "";


        public SubwayExitLink()
        {
            InitializeComponent();
            sql.GetRegion();
            
            RegionAdd();
            StationNameList();
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

        private void comboboxRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            listStationName.Rows.Clear();
            listStationName.Refresh();

            int i = comboboxRegion.SelectedIndex;


            listClickCheck = false;

            if (i == -1)
                return;

            int cityCode = Convert.ToInt16(StaticSubway.regions[i][0].ToString());


            sql.GetLaneType(cityCode);
            sql.GetStationName(cityCode, 0);
            //StationNameItemAdd();
            LaneTypeAdd();

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


            }
            else
                return;


        }

        private void StationNameList()
        {
            listStationName.Rows.Clear();

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
        private void listStationName_Click(object sender, EventArgs e)
        {

            bool indexCheck = listStationName.CurrentCell.Selected;

            int currIndex = -1;

            if (indexCheck == true)
                currIndex = listStationName.CurrentCell.RowIndex;

            guna2DataGridView1.Rows.Clear();

            if (currIndex != -1)
            {

                listClickCheck = true;

                long stationID = Convert.ToInt32(StaticSubway.stationNames[currIndex][0].ToString());

                sql.GetSubwayExitLink(stationID);


                StationItemAdd();


            }

        }

        public void StationItemAdd()
        {

            guna2DataGridView1.Rows.Clear();
            guna2DataGridView1.Refresh();

            for (int i = 0; i < StaticSubway.exitLinks.Count; i++)
            {
                string[] str = StaticSubway.exitLinks[i].ToArray();

                guna2DataGridView1.Rows.Add(str);

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int laneType = -1;
            int cityCode = -1;

            int i = comboboxRegion.SelectedIndex;

            string search = guna2TextBox1.Text;


            if (i != -1)
            {
                cityCode = Convert.ToInt16(StaticSubway.regions[i][0].ToString());

                sql.GetLaneType(cityCode);
                sql.GetStationSearch(cityCode, search);
                StationNameItemAdd();
                listStationName.Columns[1].Visible = true;

                guna2DataGridView1.Rows.Clear();

            }
            else
                MessageBox.Show("지역을 선택해 주세요");


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

        public void Reset()
        {
            comboboxRegion.SelectedIndex = 0;
            comboBoxLaneType.SelectedIndex = -1;
            guna2TextBox1.Text = "";

            StationNameList();
        }
    }
}
