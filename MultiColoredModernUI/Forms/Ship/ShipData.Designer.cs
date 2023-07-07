namespace MultiColoredModernUI.Forms.Ship
{
    partial class ShipData
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Ship_MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Ship_DateTimePickerSearch = new System.Windows.Forms.DateTimePicker();
            this.Ship_DBupdate = new FontAwesome.Sharp.IconButton();
            this.Ship_DataDownload = new FontAwesome.Sharp.IconButton();
            this.Ship_DataCollection = new FontAwesome.Sharp.IconButton();
            this.Ship_ChromeDriverTermination = new FontAwesome.Sharp.IconButton();
            this.Ship_TestdataButton = new FontAwesome.Sharp.IconButton();
            this.Ship_Pagelink = new FontAwesome.Sharp.IconButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Ship_DataGridViewData = new Guna.UI2.WinForms.Guna2DataGridView();
            this.column_ShipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_TimeRequired = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_AdultFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_YouthFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_SeniorFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_ChildFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_RemainingSeat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Reservation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harbor_Name_S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harbor_Name_E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harbor_DetailsName_S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Harbor_DetailsName_E = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ship_MainPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ship_DataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // Ship_MainPanel
            // 
            this.Ship_MainPanel.AutoSize = true;
            this.Ship_MainPanel.BackColor = System.Drawing.Color.White;
            this.Ship_MainPanel.Controls.Add(this.Ship_DateTimePickerSearch);
            this.Ship_MainPanel.Controls.Add(this.Ship_DBupdate);
            this.Ship_MainPanel.Controls.Add(this.Ship_DataDownload);
            this.Ship_MainPanel.Controls.Add(this.Ship_DataCollection);
            this.Ship_MainPanel.Controls.Add(this.Ship_ChromeDriverTermination);
            this.Ship_MainPanel.Controls.Add(this.Ship_TestdataButton);
            this.Ship_MainPanel.Controls.Add(this.Ship_Pagelink);
            this.Ship_MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Ship_MainPanel.Location = new System.Drawing.Point(0, 0);
            this.Ship_MainPanel.Name = "Ship_MainPanel";
            this.Ship_MainPanel.Size = new System.Drawing.Size(1115, 83);
            this.Ship_MainPanel.TabIndex = 0;
            // 
            // Ship_DateTimePickerSearch
            // 
            this.Ship_DateTimePickerSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ship_DateTimePickerSearch.Location = new System.Drawing.Point(903, 12);
            this.Ship_DateTimePickerSearch.Name = "Ship_DateTimePickerSearch";
            this.Ship_DateTimePickerSearch.Size = new System.Drawing.Size(200, 21);
            this.Ship_DateTimePickerSearch.TabIndex = 12;
            this.Ship_DateTimePickerSearch.ValueChanged += new System.EventHandler(this.Ship_DateTimePickerSearch_ValueChanged);
            // 
            // Ship_DBupdate
            // 
            this.Ship_DBupdate.BackColor = System.Drawing.Color.White;
            this.Ship_DBupdate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Ship_DBupdate.FlatAppearance.BorderSize = 0;
            this.Ship_DBupdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Ship_DBupdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Ship_DBupdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ship_DBupdate.ForeColor = System.Drawing.Color.Black;
            this.Ship_DBupdate.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Ship_DBupdate.IconColor = System.Drawing.Color.White;
            this.Ship_DBupdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ship_DBupdate.Location = new System.Drawing.Point(555, 12);
            this.Ship_DBupdate.Name = "Ship_DBupdate";
            this.Ship_DBupdate.Size = new System.Drawing.Size(101, 68);
            this.Ship_DBupdate.TabIndex = 11;
            this.Ship_DBupdate.Text = "DB업데이트";
            this.Ship_DBupdate.UseVisualStyleBackColor = false;
            this.Ship_DBupdate.Click += new System.EventHandler(this.Ship_DBupdate_Click);
            // 
            // Ship_DataDownload
            // 
            this.Ship_DataDownload.BackColor = System.Drawing.Color.White;
            this.Ship_DataDownload.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Ship_DataDownload.FlatAppearance.BorderSize = 0;
            this.Ship_DataDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Ship_DataDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Ship_DataDownload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ship_DataDownload.ForeColor = System.Drawing.Color.Black;
            this.Ship_DataDownload.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Ship_DataDownload.IconColor = System.Drawing.Color.White;
            this.Ship_DataDownload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ship_DataDownload.Location = new System.Drawing.Point(435, 12);
            this.Ship_DataDownload.Name = "Ship_DataDownload";
            this.Ship_DataDownload.Size = new System.Drawing.Size(101, 68);
            this.Ship_DataDownload.TabIndex = 10;
            this.Ship_DataDownload.Text = "다운로드";
            this.Ship_DataDownload.UseVisualStyleBackColor = false;
            this.Ship_DataDownload.Click += new System.EventHandler(this.Ship_DataDownload_Click);
            // 
            // Ship_DataCollection
            // 
            this.Ship_DataCollection.BackColor = System.Drawing.Color.White;
            this.Ship_DataCollection.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Ship_DataCollection.FlatAppearance.BorderSize = 0;
            this.Ship_DataCollection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Ship_DataCollection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Ship_DataCollection.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ship_DataCollection.ForeColor = System.Drawing.Color.Black;
            this.Ship_DataCollection.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Ship_DataCollection.IconColor = System.Drawing.Color.White;
            this.Ship_DataCollection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ship_DataCollection.Location = new System.Drawing.Point(195, 12);
            this.Ship_DataCollection.Name = "Ship_DataCollection";
            this.Ship_DataCollection.Size = new System.Drawing.Size(101, 68);
            this.Ship_DataCollection.TabIndex = 9;
            this.Ship_DataCollection.Text = "데이터 수집";
            this.Ship_DataCollection.UseVisualStyleBackColor = false;
            this.Ship_DataCollection.Click += new System.EventHandler(this.Ship_DataCollection_Click);
            // 
            // Ship_ChromeDriverTermination
            // 
            this.Ship_ChromeDriverTermination.BackColor = System.Drawing.Color.White;
            this.Ship_ChromeDriverTermination.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Ship_ChromeDriverTermination.FlatAppearance.BorderSize = 0;
            this.Ship_ChromeDriverTermination.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Ship_ChromeDriverTermination.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Ship_ChromeDriverTermination.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ship_ChromeDriverTermination.ForeColor = System.Drawing.Color.Black;
            this.Ship_ChromeDriverTermination.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Ship_ChromeDriverTermination.IconColor = System.Drawing.Color.White;
            this.Ship_ChromeDriverTermination.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ship_ChromeDriverTermination.Location = new System.Drawing.Point(315, 12);
            this.Ship_ChromeDriverTermination.Name = "Ship_ChromeDriverTermination";
            this.Ship_ChromeDriverTermination.Size = new System.Drawing.Size(101, 68);
            this.Ship_ChromeDriverTermination.TabIndex = 8;
            this.Ship_ChromeDriverTermination.Text = "크롬 \r\n드라이버 종료";
            this.Ship_ChromeDriverTermination.UseVisualStyleBackColor = false;
            this.Ship_ChromeDriverTermination.Click += new System.EventHandler(this.Ship_ChromeDriverTermination_Click);
            // 
            // Ship_TestdataButton
            // 
            this.Ship_TestdataButton.BackColor = System.Drawing.Color.White;
            this.Ship_TestdataButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Ship_TestdataButton.FlatAppearance.BorderSize = 0;
            this.Ship_TestdataButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Ship_TestdataButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Ship_TestdataButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ship_TestdataButton.ForeColor = System.Drawing.Color.Black;
            this.Ship_TestdataButton.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Ship_TestdataButton.IconColor = System.Drawing.Color.White;
            this.Ship_TestdataButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ship_TestdataButton.Location = new System.Drawing.Point(22, 52);
            this.Ship_TestdataButton.Name = "Ship_TestdataButton";
            this.Ship_TestdataButton.Size = new System.Drawing.Size(101, 28);
            this.Ship_TestdataButton.TabIndex = 5;
            this.Ship_TestdataButton.Text = "테스트 데이터";
            this.Ship_TestdataButton.UseVisualStyleBackColor = false;
            this.Ship_TestdataButton.Click += new System.EventHandler(this.Ship_TestdataButton_Click);
            // 
            // Ship_Pagelink
            // 
            this.Ship_Pagelink.BackColor = System.Drawing.Color.White;
            this.Ship_Pagelink.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Ship_Pagelink.FlatAppearance.BorderSize = 0;
            this.Ship_Pagelink.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.Ship_Pagelink.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.Ship_Pagelink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Ship_Pagelink.ForeColor = System.Drawing.Color.Black;
            this.Ship_Pagelink.IconChar = FontAwesome.Sharp.IconChar.None;
            this.Ship_Pagelink.IconColor = System.Drawing.Color.White;
            this.Ship_Pagelink.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Ship_Pagelink.Location = new System.Drawing.Point(22, 12);
            this.Ship_Pagelink.Name = "Ship_Pagelink";
            this.Ship_Pagelink.Size = new System.Drawing.Size(101, 28);
            this.Ship_Pagelink.TabIndex = 4;
            this.Ship_Pagelink.Text = "가보고싶은섬";
            this.Ship_Pagelink.UseVisualStyleBackColor = false;
            this.Ship_Pagelink.Click += new System.EventHandler(this.Ship_Pagelink_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.AutoScroll = true;
            this.guna2Panel1.AutoSize = true;
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.Ship_DataGridViewData);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 83);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1115, 566);
            this.guna2Panel1.TabIndex = 1;
            // 
            // Ship_DataGridViewData
            // 
            this.Ship_DataGridViewData.AllowUserToAddRows = false;
            this.Ship_DataGridViewData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Ship_DataGridViewData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Ship_DataGridViewData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Ship_DataGridViewData.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.Ship_DataGridViewData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Ship_DataGridViewData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Ship_DataGridViewData.ColumnHeadersHeight = 26;
            this.Ship_DataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Ship_DataGridViewData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_ShipName,
            this.column_StartTime,
            this.column_TimeRequired,
            this.column_Rank,
            this.column_AdultFee,
            this.column_YouthFee,
            this.column_SeniorFee,
            this.column_ChildFee,
            this.column_RemainingSeat,
            this.column_Reservation,
            this.Harbor_Name_S,
            this.Harbor_Name_E,
            this.Harbor_DetailsName_S,
            this.Harbor_DetailsName_E});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Ship_DataGridViewData.DefaultCellStyle = dataGridViewCellStyle3;
            this.Ship_DataGridViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Ship_DataGridViewData.GridColor = System.Drawing.Color.Black;
            this.Ship_DataGridViewData.Location = new System.Drawing.Point(0, 0);
            this.Ship_DataGridViewData.Name = "Ship_DataGridViewData";
            this.Ship_DataGridViewData.RowHeadersVisible = false;
            this.Ship_DataGridViewData.RowTemplate.Height = 23;
            this.Ship_DataGridViewData.Size = new System.Drawing.Size(1115, 566);
            this.Ship_DataGridViewData.TabIndex = 0;
            this.Ship_DataGridViewData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Ship_DataGridViewData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Ship_DataGridViewData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Ship_DataGridViewData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Ship_DataGridViewData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Ship_DataGridViewData.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Ship_DataGridViewData.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.Ship_DataGridViewData.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Ship_DataGridViewData.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.Ship_DataGridViewData.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Ship_DataGridViewData.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Ship_DataGridViewData.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Ship_DataGridViewData.ThemeStyle.HeaderStyle.Height = 26;
            this.Ship_DataGridViewData.ThemeStyle.ReadOnly = false;
            this.Ship_DataGridViewData.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Ship_DataGridViewData.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Ship_DataGridViewData.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Ship_DataGridViewData.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Ship_DataGridViewData.ThemeStyle.RowsStyle.Height = 23;
            this.Ship_DataGridViewData.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Ship_DataGridViewData.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // column_ShipName
            // 
            this.column_ShipName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_ShipName.HeaderText = "선박명";
            this.column_ShipName.Name = "column_ShipName";
            // 
            // column_StartTime
            // 
            this.column_StartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_StartTime.HeaderText = "출발시각";
            this.column_StartTime.Name = "column_StartTime";
            // 
            // column_TimeRequired
            // 
            this.column_TimeRequired.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_TimeRequired.HeaderText = "소요시각";
            this.column_TimeRequired.Name = "column_TimeRequired";
            // 
            // column_Rank
            // 
            this.column_Rank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_Rank.HeaderText = "등급";
            this.column_Rank.Name = "column_Rank";
            // 
            // column_AdultFee
            // 
            this.column_AdultFee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_AdultFee.HeaderText = "대인";
            this.column_AdultFee.Name = "column_AdultFee";
            // 
            // column_YouthFee
            // 
            this.column_YouthFee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_YouthFee.HeaderText = "중고";
            this.column_YouthFee.Name = "column_YouthFee";
            // 
            // column_SeniorFee
            // 
            this.column_SeniorFee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_SeniorFee.HeaderText = "경로";
            this.column_SeniorFee.Name = "column_SeniorFee";
            // 
            // column_ChildFee
            // 
            this.column_ChildFee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_ChildFee.HeaderText = "소아";
            this.column_ChildFee.Name = "column_ChildFee";
            // 
            // column_RemainingSeat
            // 
            this.column_RemainingSeat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_RemainingSeat.HeaderText = "잔여석";
            this.column_RemainingSeat.Name = "column_RemainingSeat";
            // 
            // column_Reservation
            // 
            this.column_Reservation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_Reservation.HeaderText = "예매";
            this.column_Reservation.Name = "column_Reservation";
            // 
            // Harbor_Name_S
            // 
            this.Harbor_Name_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Harbor_Name_S.HeaderText = "출발지";
            this.Harbor_Name_S.Name = "Harbor_Name_S";
            // 
            // Harbor_Name_E
            // 
            this.Harbor_Name_E.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Harbor_Name_E.HeaderText = "도착지";
            this.Harbor_Name_E.Name = "Harbor_Name_E";
            // 
            // Harbor_DetailsName_S
            // 
            this.Harbor_DetailsName_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Harbor_DetailsName_S.HeaderText = "출발지 상세주소";
            this.Harbor_DetailsName_S.Name = "Harbor_DetailsName_S";
            // 
            // Harbor_DetailsName_E
            // 
            this.Harbor_DetailsName_E.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Harbor_DetailsName_E.HeaderText = "도착지 상세주소";
            this.Harbor_DetailsName_E.Name = "Harbor_DetailsName_E";
            // 
            // ShipData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 649);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.Ship_MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShipData";
            this.Text = "Ship";
            this.Ship_MainPanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ship_DataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Ship_MainPanel;
        private FontAwesome.Sharp.IconButton Ship_DBupdate;
        private FontAwesome.Sharp.IconButton Ship_DataDownload;
        private FontAwesome.Sharp.IconButton Ship_DataCollection;
        private FontAwesome.Sharp.IconButton Ship_ChromeDriverTermination;
        private FontAwesome.Sharp.IconButton Ship_TestdataButton;
        private FontAwesome.Sharp.IconButton Ship_Pagelink;
        private System.Windows.Forms.DateTimePicker Ship_DateTimePickerSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView Ship_DataGridViewData;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_ShipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_TimeRequired;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_AdultFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_YouthFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_SeniorFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_ChildFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_RemainingSeat;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Reservation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harbor_Name_S;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harbor_Name_E;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harbor_DetailsName_S;
        private System.Windows.Forms.DataGridViewTextBoxColumn Harbor_DetailsName_E;
    }
}