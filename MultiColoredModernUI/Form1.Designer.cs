namespace MultiColoredModernUI
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelShipSubMenu = new System.Windows.Forms.Panel();
            this.btnShip = new System.Windows.Forms.Button();
            this.btnShipProducts = new System.Windows.Forms.Button();
            this.panelProductsSubMenu = new System.Windows.Forms.Panel();
            this.btnExchange = new System.Windows.Forms.Button();
            this.btnGateLink = new System.Windows.Forms.Button();
            this.btnFacility = new System.Windows.Forms.Button();
            this.btnStation = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnDataManegement = new System.Windows.Forms.Button();
            this.btnRegionData = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMaster = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnCloseChileForm = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.lblTitle = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelDeskTop = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panelShipSubMenu.SuspendLayout();
            this.panelProductsSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.White;
            this.panelSideMenu.Controls.Add(this.panelShipSubMenu);
            this.panelSideMenu.Controls.Add(this.btnShipProducts);
            this.panelSideMenu.Controls.Add(this.panelProductsSubMenu);
            this.panelSideMenu.Controls.Add(this.btnProducts);
            this.panelSideMenu.Controls.Add(this.btnDataManegement);
            this.panelSideMenu.Controls.Add(this.btnRegionData);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Controls.Add(this.btnMaster);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(204, 658);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelShipSubMenu
            // 
            this.panelShipSubMenu.BackColor = System.Drawing.Color.White;
            this.panelShipSubMenu.Controls.Add(this.btnShip);
            this.panelShipSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShipSubMenu.Location = new System.Drawing.Point(0, 395);
            this.panelShipSubMenu.Name = "panelShipSubMenu";
            this.panelShipSubMenu.Size = new System.Drawing.Size(204, 42);
            this.panelShipSubMenu.TabIndex = 10;
            // 
            // btnShip
            // 
            this.btnShip.BackColor = System.Drawing.Color.White;
            this.btnShip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShip.FlatAppearance.BorderSize = 0;
            this.btnShip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShip.ForeColor = System.Drawing.Color.Black;
            this.btnShip.Location = new System.Drawing.Point(0, 0);
            this.btnShip.Name = "btnShip";
            this.btnShip.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnShip.Size = new System.Drawing.Size(204, 42);
            this.btnShip.TabIndex = 0;
            this.btnShip.Text = "해운 정보";
            this.btnShip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShip.UseVisualStyleBackColor = false;
            this.btnShip.Click += new System.EventHandler(this.btnShip_Click);
            // 
            // btnShipProducts
            // 
            this.btnShipProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShipProducts.FlatAppearance.BorderSize = 0;
            this.btnShipProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShipProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShipProducts.ForeColor = System.Drawing.Color.Black;
            this.btnShipProducts.Location = new System.Drawing.Point(0, 350);
            this.btnShipProducts.Name = "btnShipProducts";
            this.btnShipProducts.Size = new System.Drawing.Size(204, 45);
            this.btnShipProducts.TabIndex = 9;
            this.btnShipProducts.Text = "해운 관리";
            this.btnShipProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShipProducts.UseVisualStyleBackColor = true;
            this.btnShipProducts.Click += new System.EventHandler(this.btnShipProducts_Click);
            // 
            // panelProductsSubMenu
            // 
            this.panelProductsSubMenu.BackColor = System.Drawing.Color.White;
            this.panelProductsSubMenu.Controls.Add(this.btnExchange);
            this.panelProductsSubMenu.Controls.Add(this.btnGateLink);
            this.panelProductsSubMenu.Controls.Add(this.btnFacility);
            this.panelProductsSubMenu.Controls.Add(this.btnStation);
            this.panelProductsSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductsSubMenu.Location = new System.Drawing.Point(0, 210);
            this.panelProductsSubMenu.Name = "panelProductsSubMenu";
            this.panelProductsSubMenu.Size = new System.Drawing.Size(204, 140);
            this.panelProductsSubMenu.TabIndex = 2;
            // 
            // btnExchange
            // 
            this.btnExchange.BackColor = System.Drawing.Color.White;
            this.btnExchange.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExchange.FlatAppearance.BorderSize = 0;
            this.btnExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExchange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExchange.ForeColor = System.Drawing.Color.Black;
            this.btnExchange.Location = new System.Drawing.Point(0, 105);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnExchange.Size = new System.Drawing.Size(204, 35);
            this.btnExchange.TabIndex = 3;
            this.btnExchange.Text = "지하철 환승 정보";
            this.btnExchange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExchange.UseVisualStyleBackColor = false;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // btnGateLink
            // 
            this.btnGateLink.BackColor = System.Drawing.Color.White;
            this.btnGateLink.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGateLink.FlatAppearance.BorderSize = 0;
            this.btnGateLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGateLink.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGateLink.ForeColor = System.Drawing.Color.Black;
            this.btnGateLink.Location = new System.Drawing.Point(0, 70);
            this.btnGateLink.Name = "btnGateLink";
            this.btnGateLink.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnGateLink.Size = new System.Drawing.Size(204, 35);
            this.btnGateLink.TabIndex = 2;
            this.btnGateLink.Text = "지하철 출구 정보";
            this.btnGateLink.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGateLink.UseVisualStyleBackColor = false;
            this.btnGateLink.Click += new System.EventHandler(this.btnGateLink_Click);
            // 
            // btnFacility
            // 
            this.btnFacility.BackColor = System.Drawing.Color.White;
            this.btnFacility.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFacility.FlatAppearance.BorderSize = 0;
            this.btnFacility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacility.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacility.ForeColor = System.Drawing.Color.Black;
            this.btnFacility.Location = new System.Drawing.Point(0, 35);
            this.btnFacility.Name = "btnFacility";
            this.btnFacility.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnFacility.Size = new System.Drawing.Size(204, 35);
            this.btnFacility.TabIndex = 1;
            this.btnFacility.Text = "지하철 시설 정보";
            this.btnFacility.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacility.UseVisualStyleBackColor = false;
            this.btnFacility.Click += new System.EventHandler(this.btnFacility_Click);
            // 
            // btnStation
            // 
            this.btnStation.BackColor = System.Drawing.Color.White;
            this.btnStation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStation.FlatAppearance.BorderSize = 0;
            this.btnStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStation.ForeColor = System.Drawing.Color.Black;
            this.btnStation.Location = new System.Drawing.Point(0, 0);
            this.btnStation.Name = "btnStation";
            this.btnStation.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnStation.Size = new System.Drawing.Size(204, 35);
            this.btnStation.TabIndex = 0;
            this.btnStation.Text = "지하철 역 정보";
            this.btnStation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStation.UseVisualStyleBackColor = false;
            this.btnStation.Click += new System.EventHandler(this.btnStation_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.Black;
            this.btnProducts.Location = new System.Drawing.Point(0, 165);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(204, 45);
            this.btnProducts.TabIndex = 8;
            this.btnProducts.Text = "지하철 관리";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnDataManegement
            // 
            this.btnDataManegement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDataManegement.FlatAppearance.BorderSize = 0;
            this.btnDataManegement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataManegement.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.btnDataManegement.ForeColor = System.Drawing.Color.Black;
            this.btnDataManegement.Location = new System.Drawing.Point(0, 120);
            this.btnDataManegement.Name = "btnDataManegement";
            this.btnDataManegement.Size = new System.Drawing.Size(204, 45);
            this.btnDataManegement.TabIndex = 5;
            this.btnDataManegement.Text = "데이터 관리(유지보수) 현황";
            this.btnDataManegement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataManegement.UseVisualStyleBackColor = true;
            this.btnDataManegement.Click += new System.EventHandler(this.btnDataManegement_Click);
            // 
            // btnRegionData
            // 
            this.btnRegionData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegionData.FlatAppearance.BorderSize = 0;
            this.btnRegionData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegionData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegionData.ForeColor = System.Drawing.Color.Black;
            this.btnRegionData.Location = new System.Drawing.Point(0, 75);
            this.btnRegionData.Name = "btnRegionData";
            this.btnRegionData.Size = new System.Drawing.Size(204, 45);
            this.btnRegionData.TabIndex = 4;
            this.btnRegionData.Text = "데이터 보유현황";
            this.btnRegionData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegionData.UseVisualStyleBackColor = true;
            this.btnRegionData.Click += new System.EventHandler(this.btnRegionData_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(204, 75);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnMaster
            // 
            this.btnMaster.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnMaster.FlatAppearance.BorderSize = 0;
            this.btnMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaster.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaster.ForeColor = System.Drawing.Color.Black;
            this.btnMaster.Location = new System.Drawing.Point(0, 613);
            this.btnMaster.Name = "btnMaster";
            this.btnMaster.Size = new System.Drawing.Size(204, 45);
            this.btnMaster.TabIndex = 3;
            this.btnMaster.Text = "Master";
            this.btnMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaster.UseVisualStyleBackColor = true;
            this.btnMaster.Click += new System.EventHandler(this.btnMaster_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.White;
            this.panelTitle.Controls.Add(this.btnCloseChileForm);
            this.panelTitle.Controls.Add(this.label2);
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(this.btnMaximize);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(204, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(889, 75);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDoubleClick);
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // btnCloseChileForm
            // 
            this.btnCloseChileForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChileForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChileForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChileForm.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.btnCloseChileForm.IconColor = System.Drawing.Color.Black;
            this.btnCloseChileForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseChileForm.IconSize = 20;
            this.btnCloseChileForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChileForm.Name = "btnCloseChileForm";
            this.btnCloseChileForm.Size = new System.Drawing.Size(75, 75);
            this.btnCloseChileForm.TabIndex = 1;
            this.btnCloseChileForm.Tag = "DASHBOARD";
            this.btnCloseChileForm.UseVisualStyleBackColor = true;
            this.btnCloseChileForm.Click += new System.EventHandler(this.btnCloseChileForm_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(730, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Mongolian Baiti", 10F);
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.Location = new System.Drawing.Point(811, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(21, 20);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Mongolian Baiti", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(865, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 20);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Mongolian Baiti", 10F);
            this.btnMaximize.ForeColor = System.Drawing.Color.Black;
            this.btnMaximize.Location = new System.Drawing.Point(838, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(21, 20);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Enabled = false;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(6, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(871, 30);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "DASHBOARD";
            this.lblTitle.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDeskTop
            // 
            this.panelDeskTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDeskTop.Location = new System.Drawing.Point(204, 75);
            this.panelDeskTop.Name = "panelDeskTop";
            this.panelDeskTop.Size = new System.Drawing.Size(889, 583);
            this.panelDeskTop.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 658);
            this.Controls.Add(this.panelDeskTop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelShipSubMenu.ResumeLayout(false);
            this.panelProductsSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelProductsSubMenu;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.Button btnGateLink;
        private System.Windows.Forms.Button btnFacility;
        private System.Windows.Forms.Button btnStation;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitle;
        private FontAwesome.Sharp.IconButton btnCloseChileForm;
        private System.Windows.Forms.Button btnMaster;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblTitle;
        public System.Windows.Forms.Button btnRegionData;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panelDeskTop;
        public System.Windows.Forms.Button btnDataManegement;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnShipProducts;
        private System.Windows.Forms.Panel panelShipSubMenu;
        private System.Windows.Forms.Button btnShip;
    }
}

