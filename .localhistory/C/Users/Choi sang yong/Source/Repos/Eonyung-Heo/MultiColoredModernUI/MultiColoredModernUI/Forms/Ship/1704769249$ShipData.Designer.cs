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
            Guna.UI2.WinForms.Guna2Button Ship_ChromeDriverTermination;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Ship_MainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.Ship_DataClear = new Guna.UI2.WinForms.Guna2Button();
            this.Ship_DBupdate = new Guna.UI2.WinForms.Guna2Button();
            this.Ship_DataDownload = new Guna.UI2.WinForms.Guna2Button();
            this.Ship_TestdataButton = new Guna.UI2.WinForms.Guna2Button();
            this.Ship_Pagelink = new Guna.UI2.WinForms.Guna2Button();
            this.Ship_DataCollection = new Guna.UI2.WinForms.Guna2Button();
            this.Ship_DateTimePickerSearch = new System.Windows.Forms.DateTimePicker();
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
            Ship_ChromeDriverTermination = new Guna.UI2.WinForms.Guna2Button();
            this.Ship_MainPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ship_DataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // Ship_ChromeDriverTermination
            // 
            Ship_ChromeDriverTermination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            Ship_ChromeDriverTermination.BorderColor = System.Drawing.Color.LightGray;
            Ship_ChromeDriverTermination.BorderRadius = 8;
            Ship_ChromeDriverTermination.BorderThickness = 1;
            Ship_ChromeDriverTermination.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            Ship_ChromeDriverTermination.DisabledState.FillColor = System.Drawing.Color.White;
            Ship_ChromeDriverTermination.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            Ship_ChromeDriverTermination.FillColor = System.Drawing.Color.White;
            Ship_ChromeDriverTermination.Font = new System.Drawing.Font("Segoe UI", 9F);
            Ship_ChromeDriverTermination.ForeColor = System.Drawing.Color.Black;
            Ship_ChromeDriverTermination.Location = new System.Drawing.Point(454, 12);
            Ship_ChromeDriverTermination.Name = "Ship_ChromeDriverTermination";
            Ship_ChromeDriverTermination.Size = new System.Drawing.Size(133, 60);
            Ship_ChromeDriverTermination.TabIndex = 16;
            Ship_ChromeDriverTermination.Text = "크롬 드라이버 종료";
            Ship_ChromeDriverTermination.Click += new System.EventHandler(this.Ship_ChromeDriverTermination_Click);
            // 
            // Ship_MainPanel
            // 
            this.Ship_MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ship_MainPanel.AutoSize = true;
            this.Ship_MainPanel.BackColor = System.Drawing.Color.White;
            this.Ship_MainPanel.Controls.Add(this.Ship_DataClear);
            this.Ship_MainPanel.Controls.Add(this.Ship_DBupdate);
            this.Ship_MainPanel.Controls.Add(this.Ship_DataDownload);
            this.Ship_MainPanel.Controls.Add(Ship_ChromeDriverTermination);
            this.Ship_MainPanel.Controls.Add(this.Ship_TestdataButton);
            this.Ship_MainPanel.Controls.Add(this.Ship_Pagelink);
            this.Ship_MainPanel.Controls.Add(this.Ship_DataCollection);
            this.Ship_MainPanel.Controls.Add(this.Ship_DateTimePickerSearch);
            this.Ship_MainPanel.Location = new System.Drawing.Point(12, 15);
            this.Ship_MainPanel.Name = "Ship_MainPanel";
            this.Ship_MainPanel.Size = new System.Drawing.Size(1091, 83);
            this.Ship_MainPanel.TabIndex = 0;
            // 
            // Ship_DataClear
            // 
            this.Ship_DataClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ship_DataClear.BorderColor = System.Drawing.Color.LightGray;
            this.Ship_DataClear.BorderRadius = 8;
            this.Ship_DataClear.BorderThickness = 1;
            this.Ship_DataClear.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Ship_DataClear.DisabledState.FillColor = System.Drawing.Color.White;
            this.Ship_DataClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Ship_DataClear.FillColor = System.Drawing.Color.White;
            this.Ship_DataClear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ship_DataClear.ForeColor = System.Drawing.Color.Black;
            this.Ship_DataClear.Location = new System.Drawing.Point(240, 12);
            this.Ship_DataClear.Name = "Ship_DataClear";
            this.Ship_DataClear.Size = new System.Drawing.Size(101, 60);
            this.Ship_DataClear.TabIndex = 19;
            this.Ship_DataClear.Text = "초기화";
            this.Ship_DataClear.Click += new System.EventHandler(this.Ship_DataClear_Click);
            // 
            // Ship_DBupdate
            // 
            this.Ship_DBupdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ship_DBupdate.BorderColor = System.Drawing.Color.LightGray;
            this.Ship_DBupdate.BorderRadius = 8;
            this.Ship_DBupdate.BorderThickness = 1;
            this.Ship_DBupdate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Ship_DBupdate.DisabledState.FillColor = System.Drawing.Color.White;
            this.Ship_DBupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Ship_DBupdate.FillColor = System.Drawing.Color.White;
            this.Ship_DBupdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ship_DBupdate.ForeColor = System.Drawing.Color.Black;
            this.Ship_DBupdate.Location = new System.Drawing.Point(700, 12);
            this.Ship_DBupdate.Name = "Ship_DBupdate";
            this.Ship_DBupdate.Size = new System.Drawing.Size(101, 60);
            this.Ship_DBupdate.TabIndex = 18;
            this.Ship_DBupdate.Text = "DB업데이트";
            this.Ship_DBupdate.Click += new System.EventHandler(this.Ship_DBupdate_Click);
            // 
            // Ship_DataDownload
            // 
            this.Ship_DataDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ship_DataDownload.BorderColor = System.Drawing.Color.LightGray;
            this.Ship_DataDownload.BorderRadius = 8;
            this.Ship_DataDownload.BorderThickness = 1;
            this.Ship_DataDownload.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Ship_DataDownload.DisabledState.FillColor = System.Drawing.Color.White;
            this.Ship_DataDownload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Ship_DataDownload.FillColor = System.Drawing.Color.White;
            this.Ship_DataDownload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ship_DataDownload.ForeColor = System.Drawing.Color.Black;
            this.Ship_DataDownload.Location = new System.Drawing.Point(593, 12);
            this.Ship_DataDownload.Name = "Ship_DataDownload";
            this.Ship_DataDownload.Size = new System.Drawing.Size(101, 60);
            this.Ship_DataDownload.TabIndex = 17;
            this.Ship_DataDownload.Text = "다운로드";
            this.Ship_DataDownload.Click += new System.EventHandler(this.Ship_DataDownload_Click);
            // 
            // Ship_TestdataButton
            // 
            this.Ship_TestdataButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ship_TestdataButton.BorderColor = System.Drawing.Color.LightGray;
            this.Ship_TestdataButton.BorderRadius = 8;
            this.Ship_TestdataButton.BorderThickness = 1;
            this.Ship_TestdataButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Ship_TestdataButton.DisabledState.FillColor = System.Drawing.Color.White;
            this.Ship_TestdataButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Ship_TestdataButton.FillColor = System.Drawing.Color.White;
            this.Ship_TestdataButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ship_TestdataButton.ForeColor = System.Drawing.Color.Black;
            this.Ship_TestdataButton.Location = new System.Drawing.Point(127, 46);
            this.Ship_TestdataButton.Name = "Ship_TestdataButton";
            this.Ship_TestdataButton.Size = new System.Drawing.Size(107, 26);
            this.Ship_TestdataButton.TabIndex = 15;
            this.Ship_TestdataButton.Text = "테스트 데이터";
            this.Ship_TestdataButton.Click += new System.EventHandler(this.Ship_TestdataButton_Click);
            // 
            // Ship_Pagelink
            // 
            this.Ship_Pagelink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ship_Pagelink.BorderColor = System.Drawing.Color.LightGray;
            this.Ship_Pagelink.BorderRadius = 8;
            this.Ship_Pagelink.BorderThickness = 1;
            this.Ship_Pagelink.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Ship_Pagelink.DisabledState.FillColor = System.Drawing.Color.White;
            this.Ship_Pagelink.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Ship_Pagelink.FillColor = System.Drawing.Color.White;
            this.Ship_Pagelink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ship_Pagelink.ForeColor = System.Drawing.Color.Black;
            this.Ship_Pagelink.Location = new System.Drawing.Point(127, 12);
            this.Ship_Pagelink.Name = "Ship_Pagelink";
            this.Ship_Pagelink.Size = new System.Drawing.Size(107, 26);
            this.Ship_Pagelink.TabIndex = 14;
            this.Ship_Pagelink.Text = "가보고싶은섬";
            this.Ship_Pagelink.Click += new System.EventHandler(this.Ship_Pagelink_Click);
            // 
            // Ship_DataCollection
            // 
            this.Ship_DataCollection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ship_DataCollection.BorderColor = System.Drawing.Color.LightGray;
            this.Ship_DataCollection.BorderRadius = 8;
            this.Ship_DataCollection.BorderThickness = 1;
            this.Ship_DataCollection.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Ship_DataCollection.DisabledState.FillColor = System.Drawing.Color.White;
            this.Ship_DataCollection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Ship_DataCollection.FillColor = System.Drawing.Color.White;
            this.Ship_DataCollection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Ship_DataCollection.ForeColor = System.Drawing.Color.Black;
            this.Ship_DataCollection.Location = new System.Drawing.Point(347, 12);
            this.Ship_DataCollection.Name = "Ship_DataCollection";
            this.Ship_DataCollection.Size = new System.Drawing.Size(101, 60);
            this.Ship_DataCollection.TabIndex = 13;
            this.Ship_DataCollection.Text = "데이터 수집";
            this.Ship_DataCollection.Click += new System.EventHandler(this.Ship_DataCollection_Click);
            // 
            // Ship_DateTimePickerSearch
            // 
            this.Ship_DateTimePickerSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ship_DateTimePickerSearch.Location = new System.Drawing.Point(879, 12);
            this.Ship_DateTimePickerSearch.Name = "Ship_DateTimePickerSearch";
            this.Ship_DateTimePickerSearch.Size = new System.Drawing.Size(200, 21);
            this.Ship_DateTimePickerSearch.TabIndex = 12;
            this.Ship_DateTimePickerSearch.ValueChanged += new System.EventHandler(this.Ship_DateTimePickerSearch_ValueChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.AutoScroll = true;
            this.guna2Panel1.AutoSize = true;
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.Ship_DataGridViewData);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 110);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1091, 532);
            this.guna2Panel1.TabIndex = 1;
            // 
            // Ship_DataGridViewData
            // 
            this.Ship_DataGridViewData.AllowUserToAddRows = false;
            this.Ship_DataGridViewData.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Ship_DataGridViewData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Ship_DataGridViewData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.Ship_DataGridViewData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
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
            this.Ship_DataGridViewData.Size = new System.Drawing.Size(1091, 532);
            this.Ship_DataGridViewData.TabIndex = 0;
            this.Ship_DataGridViewData.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Ship_DataGridViewData.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Ship_DataGridViewData.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Ship_DataGridViewData.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Ship_DataGridViewData.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Ship_DataGridViewData.ThemeStyle.BackColor = System.Drawing.Color.White;
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
            this.Ship_DataGridViewData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Ship_DataGridViewData_CellContentClick);
            // 
            // column_ShipName
            // 
            this.column_ShipName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_ShipName.HeaderText = "선박명";
            this.column_ShipName.Name = "column_ShipName";
            this.column_ShipName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // column_StartTime
            // 
            this.column_StartTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_StartTime.HeaderText = "출발시각";
            this.column_StartTime.Name = "column_StartTime";
            this.column_StartTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // column_TimeRequired
            // 
            this.column_TimeRequired.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_TimeRequired.HeaderText = "소요시각";
            this.column_TimeRequired.Name = "column_TimeRequired";
            this.column_TimeRequired.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // column_Rank
            // 
            this.column_Rank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_Rank.HeaderText = "등급";
            this.column_Rank.Name = "column_Rank";
            this.column_Rank.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // column_AdultFee
            // 
            this.column_AdultFee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_AdultFee.HeaderText = "대인";
            this.column_AdultFee.Name = "column_AdultFee";
            this.column_AdultFee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // column_YouthFee
            // 
            this.column_YouthFee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_YouthFee.HeaderText = "중고";
            this.column_YouthFee.Name = "column_YouthFee";
            this.column_YouthFee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // column_SeniorFee
            // 
            this.column_SeniorFee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_SeniorFee.HeaderText = "경로";
            this.column_SeniorFee.Name = "column_SeniorFee";
            this.column_SeniorFee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // column_ChildFee
            // 
            this.column_ChildFee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_ChildFee.HeaderText = "소아";
            this.column_ChildFee.Name = "column_ChildFee";
            this.column_ChildFee.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // column_RemainingSeat
            // 
            this.column_RemainingSeat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_RemainingSeat.HeaderText = "잔여석";
            this.column_RemainingSeat.Name = "column_RemainingSeat";
            this.column_RemainingSeat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // column_Reservation
            // 
            this.column_Reservation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.column_Reservation.HeaderText = "예매";
            this.column_Reservation.Name = "column_Reservation";
            this.column_Reservation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Harbor_Name_S
            // 
            this.Harbor_Name_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Harbor_Name_S.HeaderText = "출발지";
            this.Harbor_Name_S.Name = "Harbor_Name_S";
            this.Harbor_Name_S.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Harbor_Name_E
            // 
            this.Harbor_Name_E.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Harbor_Name_E.HeaderText = "도착지";
            this.Harbor_Name_E.Name = "Harbor_Name_E";
            this.Harbor_Name_E.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Harbor_DetailsName_S
            // 
            this.Harbor_DetailsName_S.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Harbor_DetailsName_S.HeaderText = "출발지 상세주소";
            this.Harbor_DetailsName_S.Name = "Harbor_DetailsName_S";
            this.Harbor_DetailsName_S.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Harbor_DetailsName_E
            // 
            this.Harbor_DetailsName_E.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Harbor_DetailsName_E.HeaderText = "도착지 상세주소";
            this.Harbor_DetailsName_E.Name = "Harbor_DetailsName_E";
            this.Harbor_DetailsName_E.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
        private System.Windows.Forms.DateTimePicker Ship_DateTimePickerSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView Ship_DataGridViewData;
        private Guna.UI2.WinForms.Guna2Button Ship_DataCollection;
        private Guna.UI2.WinForms.Guna2Button Ship_Pagelink;
        private Guna.UI2.WinForms.Guna2Button Ship_TestdataButton;
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
        private Guna.UI2.WinForms.Guna2Button Ship_DataDownload;
        private Guna.UI2.WinForms.Guna2Button Ship_DBupdate;
        private Guna.UI2.WinForms.Guna2Button Ship_DataClear;
    }
}