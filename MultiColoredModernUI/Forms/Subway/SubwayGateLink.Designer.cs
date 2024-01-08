namespace MultiColoredModernUI.Forms.Subway
{
    partial class SubwayGateLink
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textGateNoAlter = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxCnstruction = new System.Windows.Forms.CheckBox();
            this.btnGateInfoAlter = new System.Windows.Forms.Button();
            this.textGateInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btndel = new System.Windows.Forms.Button();
            this.textGateNoAdd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGateInfoAdd = new System.Windows.Forms.Button();
            this.textGateInfoAdd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textStationName = new System.Windows.Forms.TextBox();
            this.btnAlter = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listStation = new System.Windows.Forms.ListView();
            this.comGateNo = new System.Windows.Forms.ComboBox();
            this.listStationName = new Guna.UI2.WinForms.Guna2DataGridView();
            this.SSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.route = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxLaneType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboboxRegion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listStationName)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxLaneType);
            this.panel1.Controls.Add(this.comboboxRegion);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listStationName);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.guna2TextBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 649);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tabControl);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textStationName);
            this.panel2.Controls.Add(this.btnAlter);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.listStation);
            this.panel2.Controls.Add(this.comGateNo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(211, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(904, 649);
            this.panel2.TabIndex = 3;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(3, 48);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(896, 102);
            this.tabControl.TabIndex = 46;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.textGateNoAlter);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.checkBoxCnstruction);
            this.tabPage1.Controls.Add(this.btnGateInfoAlter);
            this.tabPage1.Controls.Add(this.textGateInfo);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(888, 76);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "수정";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnDelete.Location = new System.Drawing.Point(840, 46);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 22);
            this.btnDelete.TabIndex = 49;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textGateNoAlter
            // 
            this.textGateNoAlter.Enabled = false;
            this.textGateNoAlter.Location = new System.Drawing.Point(103, 7);
            this.textGateNoAlter.Name = "textGateNoAlter";
            this.textGateNoAlter.Size = new System.Drawing.Size(100, 21);
            this.textGateNoAlter.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 10);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 12);
            this.label10.TabIndex = 47;
            this.label10.Text = "출구 번호";
            // 
            // checkBoxCnstruction
            // 
            this.checkBoxCnstruction.AutoSize = true;
            this.checkBoxCnstruction.Location = new System.Drawing.Point(209, 9);
            this.checkBoxCnstruction.Name = "checkBoxCnstruction";
            this.checkBoxCnstruction.Size = new System.Drawing.Size(60, 16);
            this.checkBoxCnstruction.TabIndex = 42;
            this.checkBoxCnstruction.Text = "공사중";
            this.checkBoxCnstruction.UseVisualStyleBackColor = true;
            this.checkBoxCnstruction.CheckedChanged += new System.EventHandler(this.checkBoxCnstruction_CheckedChanged);
            // 
            // btnGateInfoAlter
            // 
            this.btnGateInfoAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGateInfoAlter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnGateInfoAlter.Location = new System.Drawing.Point(382, 46);
            this.btnGateInfoAlter.Name = "btnGateInfoAlter";
            this.btnGateInfoAlter.Size = new System.Drawing.Size(40, 22);
            this.btnGateInfoAlter.TabIndex = 41;
            this.btnGateInfoAlter.Text = "수정";
            this.btnGateInfoAlter.UseVisualStyleBackColor = true;
            this.btnGateInfoAlter.Click += new System.EventHandler(this.btnGateInfoAlter_Click);
            // 
            // textGateInfo
            // 
            this.textGateInfo.Location = new System.Drawing.Point(103, 46);
            this.textGateInfo.Multiline = true;
            this.textGateInfo.Name = "textGateInfo";
            this.textGateInfo.Size = new System.Drawing.Size(273, 21);
            this.textGateInfo.TabIndex = 40;
            this.textGateInfo.TextChanged += new System.EventHandler(this.textGateInfo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 12);
            this.label5.TabIndex = 38;
            this.label5.Text = "출구 정보 ";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.btndel);
            this.tabPage2.Controls.Add(this.textGateNoAdd);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnGateInfoAdd);
            this.tabPage2.Controls.Add(this.textGateInfoAdd);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(888, 76);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "추가";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btndel
            // 
            this.btndel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btndel.BackColor = System.Drawing.Color.White;
            this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btndel.Location = new System.Drawing.Point(840, 46);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(40, 22);
            this.btndel.TabIndex = 50;
            this.btndel.Text = "삭제";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textGateNoAdd
            // 
            this.textGateNoAdd.Location = new System.Drawing.Point(103, 7);
            this.textGateNoAdd.Name = "textGateNoAdd";
            this.textGateNoAdd.Size = new System.Drawing.Size(100, 21);
            this.textGateNoAdd.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 12);
            this.label7.TabIndex = 44;
            this.label7.Text = "출구 번호";
            // 
            // btnGateInfoAdd
            // 
            this.btnGateInfoAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGateInfoAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnGateInfoAdd.Location = new System.Drawing.Point(382, 46);
            this.btnGateInfoAdd.Name = "btnGateInfoAdd";
            this.btnGateInfoAdd.Size = new System.Drawing.Size(40, 22);
            this.btnGateInfoAdd.TabIndex = 48;
            this.btnGateInfoAdd.Text = "추가";
            this.btnGateInfoAdd.UseVisualStyleBackColor = true;
            this.btnGateInfoAdd.Click += new System.EventHandler(this.btnGateInfoAdd_Click);
            // 
            // textGateInfoAdd
            // 
            this.textGateInfoAdd.Location = new System.Drawing.Point(103, 46);
            this.textGateInfoAdd.Multiline = true;
            this.textGateInfoAdd.Name = "textGateInfoAdd";
            this.textGateInfoAdd.Size = new System.Drawing.Size(273, 21);
            this.textGateInfoAdd.TabIndex = 47;
            this.textGateInfoAdd.TextChanged += new System.EventHandler(this.textGateInfoAdd_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 12);
            this.label9.TabIndex = 45;
            this.label9.Text = "출구 정보 ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(264, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 37;
            this.label4.Text = "출구 번호";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(18, 624);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 12);
            this.label6.TabIndex = 43;
            this.label6.Text = "※ 지하철역이 환승역일 경우 정보 수정 시 같이 변경됩니다.";
            // 
            // textStationName
            // 
            this.textStationName.Location = new System.Drawing.Point(98, 20);
            this.textStationName.Name = "textStationName";
            this.textStationName.Size = new System.Drawing.Size(156, 21);
            this.textStationName.TabIndex = 39;
            // 
            // btnAlter
            // 
            this.btnAlter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlter.Location = new System.Drawing.Point(820, 614);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 35;
            this.btnAlter.Text = "적용";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 12);
            this.label3.TabIndex = 36;
            this.label3.Text = "지하철 역 이름";
            // 
            // listStation
            // 
            this.listStation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listStation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listStation.HideSelection = false;
            this.listStation.Location = new System.Drawing.Point(5, 152);
            this.listStation.MultiSelect = false;
            this.listStation.Name = "listStation";
            this.listStation.Size = new System.Drawing.Size(890, 456);
            this.listStation.TabIndex = 20;
            this.listStation.UseCompatibleStateImageBehavior = false;
            this.listStation.SelectedIndexChanged += new System.EventHandler(this.listStation_Click);
            this.listStation.Click += new System.EventHandler(this.listStation_Click);
            // 
            // comGateNo
            // 
            this.comGateNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.comGateNo.BackColor = System.Drawing.Color.White;
            this.comGateNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comGateNo.FormattingEnabled = true;
            this.comGateNo.Location = new System.Drawing.Point(327, 20);
            this.comGateNo.Name = "comGateNo";
            this.comGateNo.Size = new System.Drawing.Size(91, 20);
            this.comGateNo.TabIndex = 7;
            this.comGateNo.SelectedIndexChanged += new System.EventHandler(this.comGateNo_SelectedIndexChanged);
            // 
            // listStationName
            // 
            this.listStationName.AllowUserToAddRows = false;
            this.listStationName.AllowUserToDeleteRows = false;
            this.listStationName.AllowUserToResizeColumns = false;
            this.listStationName.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.listStationName.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.listStationName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listStationName.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listStationName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listStationName.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.listStationName.ColumnHeadersHeight = 20;
            this.listStationName.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SSID,
            this.route,
            this.station});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listStationName.DefaultCellStyle = dataGridViewCellStyle12;
            this.listStationName.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listStationName.Location = new System.Drawing.Point(11, 136);
            this.listStationName.MultiSelect = false;
            this.listStationName.Name = "listStationName";
            this.listStationName.ReadOnly = true;
            this.listStationName.RowHeadersVisible = false;
            this.listStationName.RowTemplate.Height = 25;
            this.listStationName.Size = new System.Drawing.Size(186, 508);
            this.listStationName.TabIndex = 19;
            this.listStationName.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.listStationName.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.listStationName.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.listStationName.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.listStationName.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.listStationName.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.listStationName.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listStationName.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.listStationName.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listStationName.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listStationName.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.listStationName.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.listStationName.ThemeStyle.HeaderStyle.Height = 20;
            this.listStationName.ThemeStyle.ReadOnly = true;
            this.listStationName.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.listStationName.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listStationName.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listStationName.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listStationName.ThemeStyle.RowsStyle.Height = 25;
            this.listStationName.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listStationName.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listStationName.Click += new System.EventHandler(this.listStationName_Click);
            // 
            // SSID
            // 
            this.SSID.HeaderText = "아이디";
            this.SSID.Name = "SSID";
            this.SSID.ReadOnly = true;
            this.SSID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SSID.Visible = false;
            // 
            // route
            // 
            this.route.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.route.FillWeight = 80F;
            this.route.HeaderText = "노 선";
            this.route.Name = "route";
            this.route.ReadOnly = true;
            this.route.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.route.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.route.Visible = false;
            // 
            // station
            // 
            this.station.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.station.HeaderText = "지하철 역";
            this.station.Name = "station";
            this.station.ReadOnly = true;
            this.station.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.station.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Location = new System.Drawing.Point(142, 108);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(55, 22);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Text = "검색";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(11, 108);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(124, 22);
            this.guna2TextBox1.TabIndex = 17;
            this.guna2TextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.guna2TextBox1_KeyUp);
            this.guna2TextBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.guna2TextBox1_MouseClick);
            // 
            // comboBoxLaneType
            // 
            this.comboBoxLaneType.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxLaneType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxLaneType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLaneType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxLaneType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxLaneType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxLaneType.ForeColor = System.Drawing.Color.Black;
            this.comboBoxLaneType.IntegralHeight = false;
            this.comboBoxLaneType.ItemHeight = 30;
            this.comboBoxLaneType.Location = new System.Drawing.Point(52, 62);
            this.comboBoxLaneType.Name = "comboBoxLaneType";
            this.comboBoxLaneType.Size = new System.Drawing.Size(135, 36);
            this.comboBoxLaneType.TabIndex = 23;
            this.comboBoxLaneType.SelectedIndexChanged += new System.EventHandler(this.comboBoxLaneType_SelectedIndexChanged);
            // 
            // comboboxRegion
            // 
            this.comboboxRegion.BackColor = System.Drawing.Color.White;
            this.comboboxRegion.BorderColor = System.Drawing.Color.LightGray;
            this.comboboxRegion.DisabledState.BorderColor = System.Drawing.Color.White;
            this.comboboxRegion.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.comboboxRegion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxRegion.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxRegion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxRegion.FocusedState.FillColor = System.Drawing.Color.White;
            this.comboboxRegion.FocusedState.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboboxRegion.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.comboboxRegion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboboxRegion.ForeColor = System.Drawing.Color.Black;
            this.comboboxRegion.HoverState.BorderColor = System.Drawing.Color.White;
            this.comboboxRegion.HoverState.FillColor = System.Drawing.Color.White;
            this.comboboxRegion.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboboxRegion.HoverState.ForeColor = System.Drawing.Color.Black;
            this.comboboxRegion.IntegralHeight = false;
            this.comboboxRegion.ItemHeight = 30;
            this.comboboxRegion.ItemsAppearance.BackColor = System.Drawing.Color.White;
            this.comboboxRegion.ItemsAppearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboboxRegion.ItemsAppearance.ForeColor = System.Drawing.Color.White;
            this.comboboxRegion.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.comboboxRegion.ItemsAppearance.SelectedFont = new System.Drawing.Font("Segoe UI", 10F);
            this.comboboxRegion.ItemsAppearance.SelectedForeColor = System.Drawing.Color.Black;
            this.comboboxRegion.Location = new System.Drawing.Point(52, 11);
            this.comboboxRegion.Name = "comboboxRegion";
            this.comboboxRegion.Size = new System.Drawing.Size(135, 36);
            this.comboboxRegion.TabIndex = 22;
            this.comboboxRegion.SelectedIndexChanged += new System.EventHandler(this.comboboxRegion_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 14);
            this.label2.TabIndex = 21;
            this.label2.Text = "노 선";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 20;
            this.label1.Text = "지 역";
            // 
            // SubwayGateLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 649);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubwayGateLink";
            this.Text = "TBSubwayGateLink";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listStationName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textStationName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGateInfoAlter;
        private System.Windows.Forms.ComboBox comGateNo;
        private System.Windows.Forms.TextBox textGateInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGateInfoAdd;
        private System.Windows.Forms.TextBox textGateInfoAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxCnstruction;
        private System.Windows.Forms.TextBox textGateNoAlter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textGateNoAdd;
        public System.Windows.Forms.ListView listStation;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btndel;
        private Guna.UI2.WinForms.Guna2DataGridView listStationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn route;
        private System.Windows.Forms.DataGridViewTextBoxColumn station;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxLaneType;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxRegion;
        private Guna.UI2.WinForms.Guna2HtmlLabel label2;
        private Guna.UI2.WinForms.Guna2HtmlLabel label1;
    }
}