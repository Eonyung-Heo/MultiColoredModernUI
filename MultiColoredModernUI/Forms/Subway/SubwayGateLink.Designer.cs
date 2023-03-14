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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listStationName = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxLaneType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboboxRegion = new System.Windows.Forms.ComboBox();
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
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.listStationName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxLaneType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboboxRegion);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(211, 649);
            this.panel1.TabIndex = 2;
            // 
            // listStationName
            // 
            this.listStationName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listStationName.HideSelection = false;
            this.listStationName.Location = new System.Drawing.Point(10, 125);
            this.listStationName.Margin = new System.Windows.Forms.Padding(10);
            this.listStationName.MultiSelect = false;
            this.listStationName.Name = "listStationName";
            this.listStationName.Size = new System.Drawing.Size(186, 512);
            this.listStationName.TabIndex = 6;
            this.listStationName.UseCompatibleStateImageBehavior = false;
            this.listStationName.SelectedIndexChanged += new System.EventHandler(this.listStationName_Click);
            this.listStationName.Click += new System.EventHandler(this.listStationName_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "노 선";
            // 
            // comboBoxLaneType
            // 
            this.comboBoxLaneType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLaneType.BackColor = System.Drawing.Color.White;
            this.comboBoxLaneType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLaneType.FormattingEnabled = true;
            this.comboBoxLaneType.Location = new System.Drawing.Point(97, 64);
            this.comboBoxLaneType.Name = "comboBoxLaneType";
            this.comboBoxLaneType.Size = new System.Drawing.Size(80, 20);
            this.comboBoxLaneType.TabIndex = 3;
            this.comboBoxLaneType.SelectedIndexChanged += new System.EventHandler(this.comboBoxLaneType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "지 역";
            // 
            // comboboxRegion
            // 
            this.comboboxRegion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboboxRegion.BackColor = System.Drawing.Color.White;
            this.comboboxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxRegion.FormattingEnabled = true;
            this.comboboxRegion.Location = new System.Drawing.Point(97, 26);
            this.comboboxRegion.Name = "comboboxRegion";
            this.comboboxRegion.Size = new System.Drawing.Size(80, 20);
            this.comboboxRegion.TabIndex = 1;
            this.comboboxRegion.SelectedIndexChanged += new System.EventHandler(this.comboboxRegion_SelectedIndexChanged);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listStationName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxLaneType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboboxRegion;
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
    }
}