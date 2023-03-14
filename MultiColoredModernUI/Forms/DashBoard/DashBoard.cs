using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DB = MultiColoredModernUI.Forms.DashBoard;

namespace MultiColoredModernUI
{
    public partial class DashBoard : Form
    {
        DB.MssqlDashBoard sql = new DB.MssqlDashBoard();
        DB.StatusDataManegement sDM = new DB.StatusDataManegement();
  
        Form1 mainForm = new Form1();


        public DashBoard()
        {
            InitializeComponent();
            test();
            RegionDBStatus();
            UpdateDateStatus();
           


        }

        #region LabelコントロールのDrawing Region 

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]            //Dll임포트



        private static extern IntPtr CreateRoundRectRgn(
            
            int nLeftRect,      // x-coordinate of upper-left corner

            int nTopRect,       // y-coordinate of upper-left corner

            int nRightRect,     // x-coordinate of lower-right corner

            int nBottomRect,    // y-coordinate of lower-right corner   

            int nWidthEllipse,  // height of ellipse

            int nHeightEllipse  // width of ellipse  

        );

        #endregion

        public delegate void FormSendDataHandler(object obj, EventArgs e);

        public event FormSendDataHandler RegionDataView;
        public event FormSendDataHandler DataManegementView;

        public void test()
        {

          
            guna2DataGridView1.Rows.Add(11);
            guna2DataGridView2.Rows.Add(11);

            for (int i = 0; i < 11; i++)
            {

                guna2DataGridView1.Rows[i].Cells[0].Value = "용인시";
                guna2DataGridView1.Rows[i].Cells[1].Value = "2022년7월15일";

            }

            for (int i = 0; i < 11; i++)
            {

                guna2DataGridView2.Rows[i].Cells[0].Value = "양주시";
                guna2DataGridView2.Rows[i].Cells[1].Value = "2022년 7월 1일";

            }

            
        }


        public void RegionDBStatus()
        {
            sql.RegionData();

                
            lblCityBusStation.Text = DB.StaticDashBoard.dashBoard_RegionData[0].ToString();
            lblExpressBusStation.Text = DB.StaticDashBoard.dashBoard_RegionData[5].ToString();
            lblInterBusStation.Text = DB.StaticDashBoard.dashBoard_RegionData[7].ToString(); ;
            lblSubwayStation.Text = DB.StaticDashBoard.dashBoard_RegionData[8].ToString();
            lblTrainStation.Text = DB.StaticDashBoard.dashBoard_RegionData[11].ToString();
            lblAirStation.Text = DB.StaticDashBoard.dashBoard_RegionData[13].ToString();

            lblCityBusRoute.Text = DB.StaticDashBoard.dashBoard_RegionData[2].ToString();
            lblExpressBusRoute.Text = DB.StaticDashBoard.dashBoard_RegionData[4].ToString();
            lblInterBusRoute.Text = DB.StaticDashBoard.dashBoard_RegionData[6].ToString();
            lblSubwayRoute.Text = DB.StaticDashBoard.dashBoard_RegionData[9].ToString();
            lblTrainRoute.Text = DB.StaticDashBoard.dashBoard_RegionData[10].ToString();
            lblAirRoute.Text = DB.StaticDashBoard.dashBoard_RegionData[12].ToString();


            guna2DataGridView1.Rows.Clear();
            guna2DataGridView2.Rows.Clear();
            guna2DataGridView3.Rows.Clear();
            guna2DataGridView4.Rows.Clear();
            ColumnVisible();

            int index = 4;
            int count = 0;
            for (int i = 0; i < index; i++)
            {
                sql.DataManegementView(i, 0, "");

                if (DB.StaticDashBoard.dashBoard_DataMenegements.Count > 10)
                    count = 10;
                else
                    count = DB.StaticDashBoard.dashBoard_DataMenegements.Count;

                for (int j = 0; j < count; j++)
                {
                    string[] str = DB.StaticDashBoard.dashBoard_DataMenegements[j].ToArray();

                    if(i == 1)
                        guna2DataGridView1.Rows.Add(str);
                    else if (i == 2)
                        guna2DataGridView2.Rows.Add(str);
                    else if (i == 3)
                        guna2DataGridView3.Rows.Add(str);
                    else if (i == 0)
                        guna2DataGridView4.Rows.Add(str);
                }

            }

            for (int i = 0; i < 11; i++)
            {
                chart1.Series[0].Points.Add(i);
                chart1.Series[1].Points.Add(i);
                chart1.Series[2].Points.Add(i);
            }

            for (int i = 0; i < 11; i++)
            {
                chart2.Series[0].Points.Add(i);

            }
        }

        private void ViewMoreRegionData_Click(object sender, EventArgs e)
        {
            //mainForm.OpenChildForm(new Forms.DashBoard.StatusRegionData(), sender);
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {


            RegionDataView((Button) mainForm.btnRegionData,e);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            DataManegementView((Button)mainForm.btnDataManegement, e);
            
            
        }
        
        public void ColumnVisible()
        {

            guna2DataGridView1.Columns[1].Visible = false;
            guna2DataGridView1.Columns[2].Visible = false;
            guna2DataGridView1.Columns[3].Visible = false;
            guna2DataGridView1.Columns[4].Visible = false;
            guna2DataGridView1.Columns[5].Visible = false;
            guna2DataGridView1.Columns[6].Visible = false;
            guna2DataGridView1.Columns[8].Visible = false;

            
            guna2DataGridView2.Columns[1].Visible = false;
            guna2DataGridView2.Columns[2].Visible = false;
            guna2DataGridView2.Columns[3].Visible = false;
            guna2DataGridView2.Columns[4].Visible = false;
            guna2DataGridView2.Columns[5].Visible = false;
            guna2DataGridView2.Columns[6].Visible = false;
            guna2DataGridView2.Columns[8].Visible = false;


            
            guna2DataGridView3.Columns[1].Visible = false;
            guna2DataGridView3.Columns[2].Visible = false;
            guna2DataGridView3.Columns[3].Visible = false;
            guna2DataGridView3.Columns[4].Visible = false;
            guna2DataGridView3.Columns[5].Visible = false;
            guna2DataGridView3.Columns[6].Visible = false;
            guna2DataGridView3.Columns[8].Visible = false;


            guna2DataGridView4.Columns[0].Visible = false;
            guna2DataGridView4.Columns[5].Visible = false;
            guna2DataGridView4.Columns[1].Visible = false;
            guna2DataGridView4.Columns[3].Visible = false;
            guna2DataGridView4.Columns[4].Visible = false;
            guna2DataGridView4.Columns[6].Visible = false;
            guna2DataGridView4.Columns[8].Visible = false;

        }

        public void UpdateDateStatus()
        {
            sql.UpdateDateStatus(0);


            naverUpdateDate.Text = DB.StaticDashBoard.updateDates[2][1];
            tmapUpdateDate.Text = DB.StaticDashBoard.updateDates[5][1];
            googleUpdateDate.Text = DB.StaticDashBoard.updateDates[1][1];
            odsayUpdateDate.Text = DB.StaticDashBoard.updateDates[3][1];
            langUpdateDate.Text = DB.StaticDashBoard.updateDates[4][1];
            naverOdsayUpdateDate.Text = DB.StaticDashBoard.updateDates[0][1];
            shipUpdateDate.Text = DB.StaticDashBoard.updateDates[6][1];

        }
    }
}
