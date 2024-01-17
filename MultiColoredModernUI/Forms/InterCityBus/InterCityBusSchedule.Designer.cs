namespace MultiColoredModernUI.Forms.InterCityBus
{
    partial class InterCityBusSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.sFileCheckBtn = new Guna.UI2.WinForms.Guna2Button();
            this.sFileUpdateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.LaneID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LaneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceDayID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OperationOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationSequence = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameKor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DepartureTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Error = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.sFileLoadBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ProgressBar1 = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.guna2Panel5);
            this.guna2Panel3.Controls.Add(this.guna2Panel4);
            this.guna2Panel3.Controls.Add(this.guna2Panel2);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1107, 639);
            this.guna2Panel3.TabIndex = 4;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel5.BorderThickness = 1;
            this.guna2Panel5.Controls.Add(this.sFileCheckBtn);
            this.guna2Panel5.Controls.Add(this.sFileUpdateBtn);
            this.guna2Panel5.Location = new System.Drawing.Point(848, 3);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(256, 39);
            this.guna2Panel5.TabIndex = 4;
            // 
            // sFileCheckBtn
            // 
            this.sFileCheckBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sFileCheckBtn.BorderThickness = 1;
            this.sFileCheckBtn.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.sFileCheckBtn.DisabledState.CustomBorderColor = System.Drawing.Color.LightGray;
            this.sFileCheckBtn.DisabledState.FillColor = System.Drawing.Color.LightGray;
            this.sFileCheckBtn.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.sFileCheckBtn.FillColor = System.Drawing.Color.White;
            this.sFileCheckBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sFileCheckBtn.ForeColor = System.Drawing.Color.Black;
            this.sFileCheckBtn.Location = new System.Drawing.Point(3, 3);
            this.sFileCheckBtn.Name = "sFileCheckBtn";
            this.sFileCheckBtn.Size = new System.Drawing.Size(97, 32);
            this.sFileCheckBtn.TabIndex = 3;
            this.sFileCheckBtn.Text = "데이터 수정";
            this.sFileCheckBtn.Click += new System.EventHandler(this.sFileCheckBtn_Click);
            // 
            // sFileUpdateBtn
            // 
            this.sFileUpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sFileUpdateBtn.BorderThickness = 1;
            this.sFileUpdateBtn.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.sFileUpdateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.LightGray;
            this.sFileUpdateBtn.DisabledState.FillColor = System.Drawing.Color.LightGray;
            this.sFileUpdateBtn.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.sFileUpdateBtn.FillColor = System.Drawing.Color.White;
            this.sFileUpdateBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sFileUpdateBtn.ForeColor = System.Drawing.Color.Black;
            this.sFileUpdateBtn.Location = new System.Drawing.Point(106, 3);
            this.sFileUpdateBtn.Name = "sFileUpdateBtn";
            this.sFileUpdateBtn.Size = new System.Drawing.Size(147, 32);
            this.sFileUpdateBtn.TabIndex = 2;
            this.sFileUpdateBtn.Text = "공항버스 업데이트";
            this.sFileUpdateBtn.Click += new System.EventHandler(this.sFileUpdateBtn_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel4.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.guna2DataGridView1);
            this.guna2Panel4.Location = new System.Drawing.Point(3, 44);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(1101, 592);
            this.guna2Panel4.TabIndex = 3;
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            this.guna2DataGridView1.AllowUserToResizeColumns = false;
            this.guna2DataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.guna2DataGridView1.ColumnHeadersHeight = 30;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LaneID,
            this.LaneNo,
            this.ServiceDayID,
            this.OperationOrder,
            this.StationSequence,
            this.StationID,
            this.NameKor,
            this.DepartureTime,
            this.Error});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.guna2DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowTemplate.Height = 23;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1101, 592);
            this.guna2DataGridView1.TabIndex = 0;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 23;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellValueChanged);
            // 
            // LaneID
            // 
            this.LaneID.HeaderText = "LaneID";
            this.LaneID.Name = "LaneID";
            this.LaneID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LaneNo
            // 
            this.LaneNo.HeaderText = "LaneNo";
            this.LaneNo.Name = "LaneNo";
            this.LaneNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ServiceDayID
            // 
            this.ServiceDayID.HeaderText = "ServiceDayID";
            this.ServiceDayID.Name = "ServiceDayID";
            this.ServiceDayID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OperationOrder
            // 
            this.OperationOrder.HeaderText = "OperationOrder";
            this.OperationOrder.Name = "OperationOrder";
            this.OperationOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StationSequence
            // 
            this.StationSequence.HeaderText = "StationSequence";
            this.StationSequence.Name = "StationSequence";
            this.StationSequence.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StationID
            // 
            this.StationID.HeaderText = "StationID";
            this.StationID.Name = "StationID";
            this.StationID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NameKor
            // 
            this.NameKor.HeaderText = "NameKor";
            this.NameKor.Name = "NameKor";
            this.NameKor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DepartureTime
            // 
            this.DepartureTime.HeaderText = "DepartureTime";
            this.DepartureTime.Name = "DepartureTime";
            this.DepartureTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Error
            // 
            this.Error.HeaderText = "Error";
            this.Error.Name = "Error";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.Controls.Add(this.guna2ProgressBar1);
            this.guna2Panel2.Controls.Add(this.sFileLoadBtn);
            this.guna2Panel2.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(839, 39);
            this.guna2Panel2.TabIndex = 2;
            // 
            // sFileLoadBtn
            // 
            this.sFileLoadBtn.BorderThickness = 1;
            this.sFileLoadBtn.DisabledState.BorderColor = System.Drawing.Color.Black;
            this.sFileLoadBtn.DisabledState.CustomBorderColor = System.Drawing.Color.LightGray;
            this.sFileLoadBtn.DisabledState.FillColor = System.Drawing.Color.LightGray;
            this.sFileLoadBtn.DisabledState.ForeColor = System.Drawing.Color.Black;
            this.sFileLoadBtn.FillColor = System.Drawing.Color.White;
            this.sFileLoadBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sFileLoadBtn.ForeColor = System.Drawing.Color.Black;
            this.sFileLoadBtn.Location = new System.Drawing.Point(3, 3);
            this.sFileLoadBtn.Name = "sFileLoadBtn";
            this.sFileLoadBtn.Size = new System.Drawing.Size(107, 32);
            this.sFileLoadBtn.TabIndex = 0;
            this.sFileLoadBtn.Text = "파일 불러오기";
            this.sFileLoadBtn.Click += new System.EventHandler(this.sFileLoadBtn_Click);
            // 
            // guna2ProgressBar1
            // 
            this.guna2ProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ProgressBar1.BorderThickness = 1;
            this.guna2ProgressBar1.FillColor = System.Drawing.Color.White;
            this.guna2ProgressBar1.Location = new System.Drawing.Point(116, 3);
            this.guna2ProgressBar1.Name = "guna2ProgressBar1";
            this.guna2ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2ProgressBar1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.guna2ProgressBar1.ShowText = true;
            this.guna2ProgressBar1.Size = new System.Drawing.Size(720, 32);
            this.guna2ProgressBar1.TabIndex = 2;
            this.guna2ProgressBar1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2ProgressBar1.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            this.guna2ProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ProgressBar1.UseTransparentBackground = true;
            // 
            // InterCityBusSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 639);
            this.Controls.Add(this.guna2Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InterCityBusSchedule";
            this.Text = "InterCityBusSchedule";
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2Button sFileUpdateBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaneID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LaneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceDayID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OperationOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationSequence;
        private System.Windows.Forms.DataGridViewTextBoxColumn StationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameKor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DepartureTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Error;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button sFileLoadBtn;
        private Guna.UI2.WinForms.Guna2Button sFileCheckBtn;
        private Guna.UI2.WinForms.Guna2ProgressBar guna2ProgressBar1;
    }
}