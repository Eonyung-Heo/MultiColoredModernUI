namespace MultiColoredModernUI.Forms.Ship
{
    partial class ShipLoad
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
            ((System.ComponentModel.ISupportInitialize)(this.Ship_DataGridViewData)).BeginInit();
            this.SuspendLayout();
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
            this.Ship_DataGridViewData.GridColor = System.Drawing.Color.Black;
            this.Ship_DataGridViewData.Location = new System.Drawing.Point(449, 166);
            this.Ship_DataGridViewData.Name = "Ship_DataGridViewData";
            this.Ship_DataGridViewData.RowHeadersVisible = false;
            this.Ship_DataGridViewData.RowTemplate.Height = 23;
            this.Ship_DataGridViewData.Size = new System.Drawing.Size(603, 400);
            this.Ship_DataGridViewData.TabIndex = 1;
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
            // ShipLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 654);
            this.Controls.Add(this.Ship_DataGridViewData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShipLoad";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Ship_DataGridViewData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridViewStyler guna2DataGridViewStyler1;
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