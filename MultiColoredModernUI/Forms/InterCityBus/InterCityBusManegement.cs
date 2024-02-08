using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiColoredModernUI.Forms.InterCityBus
{
    public partial class InterCityBusManegement : Form
    {
        MssqlInterCityBus sql = new MssqlInterCityBus();

        public InterCityBusManegement()
        {
            InitializeComponent();
            SelectRouteList();
            SelectNBusSchedule();
        }

        public void SelectRouteList()
        {
            guna2DataGridView1.Rows.Clear();

            List<List<string>> route = new List<List<string>>();

            route = sql.SelectRouteList(guna2TextBox1.Text,"","");

            for (int i = 0; i < route.Count; i++)
            {
                guna2DataGridView1.Rows.Add(route[i].ToArray());
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();

            SelectRouteList();
        }

        public void SelectNBusSchedule()
        {
            List<List<string>> route = new List<List<string>>();

            var laneid = guna2TextBox2.Text;
            var dayId = guna2TextBox3.Text;
            var order = guna2TextBox4.Text;
            var sequence = guna2TextBox5.Text;
            var stationid = guna2TextBox6.Text;

            route = sql.SelectNBusSchedule(laneid, dayId, order, sequence, stationid);

            for (int i = 0; i < route.Count; i++)
            {
                guna2DataGridView2.Rows.Add(route[i].ToArray());
            }
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            guna2DataGridView2.Rows.Clear();

            SelectNBusSchedule();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            List<List<string>> route = new List<List<string>>();

            bool check = true;

            if (guna2TextBox11.Text != "")
            {
                if (guna2TextBox10.Text == "" && guna2TextBox9.Text == "")
                    MessageBox.Show("AroID 또는 NToolID 둘중 하나의 ID는 입력 되어야 합니다.");
                else
                {
                    if (guna2TextBox10.Text != "")
                    {
                        route = sql.SelectRouteList("", guna2TextBox10.Text, "");
                        if (route.Count > 0)
                        {
                            check = false;
                            MessageBox.Show("AroID가 이미 등록 되어 있습니다.");
                        }

                    }
                    if (guna2TextBox9.Text != "")
                    {
                        route = sql.SelectRouteList("", "", guna2TextBox9.Text);
                        if (route.Count > 0)
                        {
                            check = false;
                            MessageBox.Show("NToolID가 이미 등록 되어 있습니다.");
                        }

                    }               
                    if(check)
                    {
                        if (MessageBox.Show("선택하신 정보가 저장됩니다", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            if (route.Count == 0)
                                sql.InsertRouteList(guna2TextBox11.Text, guna2TextBox10.Text, guna2TextBox9.Text);

                            SelectRouteList();

                            guna2TextBox11.Text = "";
                            guna2TextBox10.Text = "";
                            guna2TextBox9.Text = "";
                        }
                    }
                }
            }
            else
                MessageBox.Show("LaneNo를 입력 하세요");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = "";

            guna2TextBox11.Text = "";
            guna2TextBox10.Text = "";
            guna2TextBox9.Text = "";

            SelectRouteList();
        }

        private void guna2DataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("해당 정보를 삭제 하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var laneNo = guna2DataGridView1.Rows[e.Row.Index].Cells[0].Value.ToString();
                var aroID = guna2DataGridView1.Rows[e.Row.Index].Cells[1].Value.ToString();
                var ntoolID = guna2DataGridView1.Rows[e.Row.Index].Cells[2].Value.ToString();

                sql.DeleteRouteList(laneNo, aroID, ntoolID);
            }
            else
                e.Cancel = true;
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2TextBox2.Text = guna2DataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
