using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DF = MultiColoredModernUI.Forms.DashBoard;
using SF = MultiColoredModernUI.Forms.Subway;
using MF = MultiColoredModernUI.Forms.Master;
using SpF = MultiColoredModernUI.Forms.Ship;
using SaF = MultiColoredModernUI.Forms.Airplane;
using IF = MultiColoredModernUI.Forms.InterCityBus;
using System.Net.NetworkInformation;

namespace MultiColoredModernUI
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Button currentSubButton;
        private Random random;
        private int tempIndex;
        public static Form activeForm;
        private LoginForm loginForm;
        public static DashBoard dashBoard;

        public DF.StatusRegionData dfRegionData = new DF.StatusRegionData { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public DF.StatusDataManegement dfDataManegement = new DF.StatusDataManegement { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public SF.SubwayExchange sfExchange = new SF.SubwayExchange { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public SF.SubwayFacility sfFacility = new SF.SubwayFacility { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public SF.SubwayGateLink sfGateLink = new SF.SubwayGateLink { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public SF.SubwayStation sfStation = new SF.SubwayStation { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public SF.SubwayExitLink sfExitLink = new SF.SubwayExitLink { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public SpF.ShipData spfShipCrawling = new SpF.ShipData { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public SpF.ShipAdd spfShipAdd = new SpF.ShipAdd { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public SpF.ShipLoad spfShipLoad = new SpF.ShipLoad { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public SaF.AirData safAirData = new SaF.AirData { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public IF.InterCityBusSchedule ifBusSchedule = new IF.InterCityBusSchedule { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public IF.InterCityBusRoute ifBusRoute = new IF.InterCityBusRoute { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
        public IF.InterCityBusManegement ifBusManegement = new IF.InterCityBusManegement { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };


        public MF.MasterForm mfMaster = new MF.MasterForm { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };


        Mssql sql = new Mssql();
        

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            customizDesing();
            btnCloseChileForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            panelSideMenu.Visible = false;
            

        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL")]
        private extern static bool ShowWindow(System.IntPtr hWnd, int nCmdShow);


        [DllImport("user32")]
        private static extern bool SetForegroundWindow(IntPtr handle);

        [DllImport("user32")]
        private static extern IntPtr GetActiveWindow();



        private Color SelectThemeColor()
        {
            /*
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;*/
            string color = StaticMain.ColorList[0];
            return ColorTranslator.FromHtml(color);

        }

        private  void Activatebutton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender )
                {
                    DisableButton();                   
                    //Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.LightGray;
                    //currentButton.ForeColor = Color.White;
                    //currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //panelTitle.BackColor = color;
                    //panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChileForm.Visible = true ;

                    if (currentButton.Text != "")
                        lblTitle.Text = currentButton.Text;
                    else
                        lblTitle.Text = "DASHBOARD";


                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelSideMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.White;
                    //previousBtn.ForeColor = Color.LightGray;
                    //previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                    foreach (Control previousSubBtn in panelProductsSubMenu.Controls)
                    {
                        if (previousSubBtn.GetType() == typeof(Button))
                        {
                            previousSubBtn.BackColor = Color.White;
                            //previousSubBtn.ForeColor = Color.LightGray;
                            //previousSubBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        }
                    }
                    foreach (Control previousSubBtn in panelShipSubMenu.Controls)
                    {
                        if (previousSubBtn.GetType() == typeof(Button))
                        {
                            previousSubBtn.BackColor = Color.White;
                            //previousSubBtn.ForeColor = Color.LightGray;
                            //previousSubBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        }
                    }
                    foreach (Control previousSubBtn in panelInterCityBusSubMenu.Controls)
                    {
                        if (previousSubBtn.GetType() == typeof(Button))
                        {
                            previousSubBtn.BackColor = Color.White;
                            //previousSubBtn.ForeColor = Color.LightGray;
                            //previousSubBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        }
                    }

                }
            }
        }

        public  void OpenChildForm(Form childForm, object btnSender)
        {
            /*
            if(activeForm != null)
            {
                activeForm.Close();
            }*/

            Activatebutton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            this.panelDeskTop.Controls.Clear();
            this.panelDeskTop.Controls.Add(childForm);
            this.panelDeskTop.Tag = childForm;

           // Form1.ActiveForm.Size += childForm.Size - this.panelDeskTop.Size;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void customizDesing()
        {
            panelProductsSubMenu.Visible = false;
            panelShipSubMenu.Visible = false;
            panelInterCityBusSubMenu.Visible = false;

        }

        private void hideSubMenu()
        {
            if (panelProductsSubMenu.Visible == true)
                panelProductsSubMenu.Visible = false;

            if (panelShipSubMenu.Visible == true)
                panelShipSubMenu.Visible = false;

            if (panelInterCityBusSubMenu.Visible == true)
                panelInterCityBusSubMenu.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProductsSubMenu);
            Activatebutton(sender);
            btnStation_Click((Button)btnStation, e);
            
        }




        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); 
            SendMessage(this.Handle, 0x112, 0xf012, 0);
           
        }
        
        private void btnCloseChileForm_Click(object sender, EventArgs e)
        {

            BtnEvent();

            OpenChildForm(dashBoard, sender);

            
            Reset();

        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "DASHBOARD";
            currentButton = null;
            btnCloseChileForm.Visible = false;
            btnCloseChileForm.BackColor = Color.White;
            hideSubMenu();

            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            
            dashBoard = new DashBoard();
            dashBoard.TopLevel = false;
            this.panelDeskTop.Controls.Add(dashBoard);
            this.panelDeskTop.Tag = dashBoard;
            activeForm = dashBoard;
            dashBoard.Dock = DockStyle.Fill;
            //Form1.ActiveForm.Size += dashBoard.Size - this.panelDeskTop.Size;
            dashBoard.BringToFront();
            dashBoard.Show();


            BtnEvent();

           
   

        }
        
        private void btnMaster_Click(object sender, EventArgs e)
        {
            OpenChildForm(mfMaster, sender);
            hideSubMenu();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
                /*
            this.StartPosition = FormStartPosition.Manual;
            this.Bounds = Rectangle.Empty;
            foreach (var screen in Screen.AllScreens)
            {
                this.Bounds = Rectangle.Union(this.Bounds, screen.Bounds);
            }
            this.ClientSize = new Size(this.Bounds.Width, this.Bounds.Height);
            this.Location = new Point(this.Bounds.Left, this.Bounds.Top);
   */
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
            
        public void btnRegionData_Click(object sender, EventArgs e)
        {

            OpenChildForm(dfRegionData, sender);
            hideSubMenu();
        }

        private void btnStation_Click(object sender, EventArgs e)
        {
            if(StaticMain.toolSelect != 1)
            {
                if (StaticMain.toolSelect == 2)
                    sfFacility.btnAlter_Click(sender, e);
                else if (StaticMain.toolSelect == 3)
                    sfGateLink.btnAlter_Click(sender, e);
                else if (StaticMain.toolSelect == 4)
                    sfExchange.btnAlter_Click(sender, e);

                toolSelectCheckReset();

                StaticMain.toolSelect = 1;
            }
       
            sfStation.Reset();
            OpenChildForm(sfStation, sender);
            sql.Log(StaticMain.userName, StaticMain.userMac, "지하철 역 정보 선택");
            
        }

        private void btnFacility_Click(object sender, EventArgs e)
        {
            if (StaticMain.toolSelect != 2)
            {
                if (StaticMain.toolSelect == 1)
                    sfStation.btnAlter_Click(sender, e);
                else if (StaticMain.toolSelect == 3)
                    sfGateLink.btnAlter_Click(sender, e);
                else if (StaticMain.toolSelect == 4)
                    sfExchange.btnAlter_Click(sender, e);

                toolSelectCheckReset();

                StaticMain.toolSelect = 2;
            }
            sfFacility.Reset();
            OpenChildForm(sfFacility, sender);
            sql.Log(StaticMain.userName, StaticMain.userMac, "지하철 역 시설 선택");
            
        }

        private void btnGateLink_Click(object sender, EventArgs e)
        {
            if (StaticMain.toolSelect != 3)
            {
                if (StaticMain.toolSelect == 2)
                    sfFacility.btnAlter_Click(sender, e);
                else if (StaticMain.toolSelect == 1)
                    sfStation.btnAlter_Click(sender, e);
                else if (StaticMain.toolSelect == 4)
                    sfExchange.btnAlter_Click(sender, e);

                toolSelectCheckReset();

                StaticMain.toolSelect = 3;
            }
            sfGateLink.Reset();
            OpenChildForm(sfGateLink, sender);
            sql.Log(StaticMain.userName, StaticMain.userMac, "지하철 역 출구 선택");
            
            
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            if (StaticMain.toolSelect != 1)
            {
                if (StaticMain.toolSelect == 2)
                    sfFacility.btnAlter_Click(sender, e);
                else if (StaticMain.toolSelect == 3)
                    sfGateLink.btnAlter_Click(sender, e);
                else if (StaticMain.toolSelect == 1)
                    sfStation.btnAlter_Click(sender, e);

                toolSelectCheckReset();

                StaticMain.toolSelect = 4;
            }
            sfExchange.Reset();
            OpenChildForm(sfExchange, sender);
            sql.Log(StaticMain.userName, StaticMain.userMac, "지하철 역 환승 선택");
            
        }

        private void btnExitLink_Click(object sender, EventArgs e)
        {
            if (StaticMain.toolSelect != 5)
            {
                if (StaticMain.toolSelect == 1)
                    sfStation.btnAlter_Click(sender, e);
                else if (StaticMain.toolSelect == 2)
                    sfFacility.btnAlter_Click(sender, e);
                else if (StaticMain.toolSelect == 3)
                    sfGateLink.btnAlter_Click(sender, e);
                else if (StaticMain.toolSelect == 4)
                    sfExchange.btnAlter_Click(sender, e);

                toolSelectCheckReset();

                StaticMain.toolSelect = 5;
            }

            sfExitLink.Reset();
            OpenChildForm(sfExitLink, sender);
            sql.Log(StaticMain.userName, StaticMain.userMac, "지하철 빠른 하차 선택");

        }


        private void label2_Click(object sender, EventArgs e)
        {
            if (StaticMain.userName == "")
            {
                loginForm = new LoginForm();
                
                DialogResult result = loginForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    panelSideMenu.Visible = true;
                    label2.Text = StaticMain.userName;

                    levelDisable(StaticMain.userLevel);
                }
            }
        }

        public  void BtnEvent()
        {

            dashBoard.RegionDataView += new DashBoard.FormSendDataHandler(btnRegionData_Click);
            dashBoard.DataManegementView += new DashBoard.FormSendDataHandler(btnDataManegement_Click);

        }

        private void btnDataManegement_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(dfDataManegement, sender);
            hideSubMenu();


        }

        private void toolSelectCheckReset()
        {

            sfStation.listClickReset();
            sfFacility.listClickReset();
            sfGateLink.listClickReset();
            sfExchange.listClickReset();
        }

        private void panelTitle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                ShowWindow(GetActiveWindow(), 3);
            else
                ShowWindow(GetActiveWindow(), 2);
        }

        // 버튼 클릭시 시작하는 화면 나오는곳
        private void btnShipProducts_Click(object sender, EventArgs e)
        {
            showSubMenu(panelShipSubMenu);
            Activatebutton(sender);
            btnShipCollection_Click((Button)btnShipCollection, e); 
            //btnShipAdd_Click((Button)btnShipAdd, e);//상용추가
            //btnShipLoad_Click((Button)btnShipLoad, e);//상용추가
        }

        private void btnShipCollection_Click(object sender, EventArgs e)
        {
            OpenChildForm(spfShipCrawling, sender);
            sql.Log(StaticMain.userName, StaticMain.userMac, "해운 데이터 수집 선택");
        }

        //상용추가
        private void btnShipAdd_Click(object sender, EventArgs e)
        {
            OpenChildForm(spfShipAdd, sender);
            sql.Log(StaticMain.userName, StaticMain.userMac, "해운 데이터 추가 선택");
        }

        //상용추가
        private void btnShipLoad_Click(object sender, EventArgs e)
        {
            OpenChildForm(spfShipLoad, sender);
            sql.Log(StaticMain.userName, StaticMain.userMac, "해운 데이터 수정 선택");
        }

        //상용추가
        private void btnAirPlane_Click(object sender, EventArgs e)
        {
            OpenChildForm(safAirData, sender);
            hideSubMenu();
            sql.Log(StaticMain.userName, StaticMain.userMac, "항공 선택");
        }

        public void levelDisable(int level)
        {
            
            if (level != -1)
            {
                if (level == 1)
                {
                    btnMaster.Visible = false;
                    btnShipProducts.Visible = false;
                    btnAirPlane.Visible = false;

                }
            }
                
        }

        private void btnInterCityBus_Click(object sender, EventArgs e)
        {
            showSubMenu(panelInterCityBusSubMenu);
            Activatebutton(sender);
            btnBusManagement_Click((Button)btnBusManagement, e);
        }

        private void btnBusSchedule_Click(object sender, EventArgs e)
        {
            OpenChildForm(ifBusSchedule, sender);
            sql.Log(StaticMain.userName, StaticMain.userMac, "공항버스 스케쥴 선택");
        }

        private void btnBusRoute_Click(object sender, EventArgs e)
        {
            OpenChildForm(ifBusRoute, sender);
            sql.Log(StaticMain.userName, StaticMain.userMac, "공항버스 노선 선택");
        }

        private void btnBusManagement_Click(object sender, EventArgs e)
        {
            OpenChildForm(ifBusManegement, sender);
            sql.Log(StaticMain.userName, StaticMain.userMac, "공항버스 버스 관리 선택");
        }
    }
}
