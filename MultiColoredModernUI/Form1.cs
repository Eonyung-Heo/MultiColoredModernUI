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
        public SpF.ShipData spfShip = new SpF.ShipData { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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
            /*
            panelToolListSubMenu.Visible = false;
            panelSettingListSubMenu.Visible = false;
            panelArrayListSubMenu.Visible = false;*/
        }

        private void hideSubMenu()
        {
            if (panelProductsSubMenu.Visible == true)
                panelProductsSubMenu.Visible = false;

            if (panelShipSubMenu.Visible == true)
                panelShipSubMenu.Visible = false;

            /*
            if (panelToolListSubMenu.Visible == true)
                panelToolListSubMenu.Visible = false;
            if (panelSettingListSubMenu.Visible == true)
                panelSettingListSubMenu.Visible = false;
            if (panelArrayListSubMenu.Visible == true)
                panelArrayListSubMenu.Visible = false;*/
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
            /*
            if (activeForm != null)
                activeForm.Close();
                */
            //dashBoard = new DashBoard();

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

        private void btnShipProducts_Click(object sender, EventArgs e)
        {
            showSubMenu(panelShipSubMenu);
            Activatebutton(sender);
            btnShip_Click((Button)btnShip, e);
        }

        private void btnShip_Click(object sender, EventArgs e)
        {
            OpenChildForm(spfShip, sender);
            sql.Log(StaticMain.userName, StaticMain.userMac, "해운 데이터 선택");
        }
    }
}
