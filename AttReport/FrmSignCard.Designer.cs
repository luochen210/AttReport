namespace AttReport
{
    partial class FrmSignCard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.lblDep = new System.Windows.Forms.Label();
            this.dtpQEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpQBeginDate = new System.Windows.Forms.DateTimePicker();
            this.lblCEnd = new System.Windows.Forms.Label();
            this.lblCBegin = new System.Windows.Forms.Label();
            this.btnExactQuery = new System.Windows.Forms.Button();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dgvDayResult = new System.Windows.Forms.DataGridView();
            this.AtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OffDutyTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkTime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OffDutyTime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkTime3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OffDutyTime3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtSign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBatch = new System.Windows.Forms.Button();
            this.lblClasses = new System.Windows.Forms.Label();
            this.cboClasses = new System.Windows.Forms.ComboBox();
            this.lblTimes = new System.Windows.Forms.Label();
            this.cboTimes = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.cboTimes);
            this.panel1.Controls.Add(this.cboName);
            this.panel1.Controls.Add(this.lblTimes);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.cboClasses);
            this.panel1.Controls.Add(this.cboDepartment);
            this.panel1.Controls.Add(this.lblClasses);
            this.panel1.Controls.Add(this.lblDep);
            this.panel1.Controls.Add(this.dtpQEndDate);
            this.panel1.Controls.Add(this.dtpQBeginDate);
            this.panel1.Controls.Add(this.lblCEnd);
            this.panel1.Controls.Add(this.lblCBegin);
            this.panel1.Controls.Add(this.btnBatch);
            this.panel1.Controls.Add(this.btnExactQuery);
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 63);
            this.panel1.TabIndex = 11;
            // 
            // cboName
            // 
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(311, 35);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(97, 20);
            this.cboName.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(266, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "姓名：";
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(311, 8);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(97, 20);
            this.cboDepartment.TabIndex = 10;
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Location = new System.Drawing.Point(266, 11);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(41, 12);
            this.lblDep.TabIndex = 9;
            this.lblDep.Text = "部门：";
            // 
            // dtpQEndDate
            // 
            this.dtpQEndDate.CustomFormat = "";
            this.dtpQEndDate.Location = new System.Drawing.Point(39, 35);
            this.dtpQEndDate.Name = "dtpQEndDate";
            this.dtpQEndDate.Size = new System.Drawing.Size(110, 21);
            this.dtpQEndDate.TabIndex = 8;
            // 
            // dtpQBeginDate
            // 
            this.dtpQBeginDate.CustomFormat = "";
            this.dtpQBeginDate.Location = new System.Drawing.Point(39, 8);
            this.dtpQBeginDate.Name = "dtpQBeginDate";
            this.dtpQBeginDate.Size = new System.Drawing.Size(110, 21);
            this.dtpQBeginDate.TabIndex = 8;
            // 
            // lblCEnd
            // 
            this.lblCEnd.AutoSize = true;
            this.lblCEnd.Location = new System.Drawing.Point(9, 39);
            this.lblCEnd.Name = "lblCEnd";
            this.lblCEnd.Size = new System.Drawing.Size(29, 12);
            this.lblCEnd.TabIndex = 0;
            this.lblCEnd.Text = "到：";
            // 
            // lblCBegin
            // 
            this.lblCBegin.AutoSize = true;
            this.lblCBegin.Location = new System.Drawing.Point(9, 12);
            this.lblCBegin.Name = "lblCBegin";
            this.lblCBegin.Size = new System.Drawing.Size(29, 12);
            this.lblCBegin.TabIndex = 0;
            this.lblCBegin.Text = "从：";
            // 
            // btnExactQuery
            // 
            this.btnExactQuery.BackColor = System.Drawing.Color.White;
            this.btnExactQuery.Location = new System.Drawing.Point(414, 8);
            this.btnExactQuery.Name = "btnExactQuery";
            this.btnExactQuery.Size = new System.Drawing.Size(75, 48);
            this.btnExactQuery.TabIndex = 5;
            this.btnExactQuery.Text = "签卡";
            this.btnExactQuery.UseVisualStyleBackColor = false;
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(155, 8);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 48);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询异常";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // dgvDayResult
            // 
            this.dgvDayResult.AllowUserToAddRows = false;
            this.dgvDayResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDayResult.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDayResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDayResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDayResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AtDate,
            this.SfId,
            this.SfName,
            this.SfGroup,
            this.ClassesName,
            this.WorkTime1,
            this.OffDutyTime1,
            this.WorkTime2,
            this.OffDutyTime2,
            this.WorkTime3,
            this.OffDutyTime3,
            this.AtDay,
            this.AtState,
            this.AtSign});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDayResult.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDayResult.Location = new System.Drawing.Point(12, 88);
            this.dgvDayResult.Name = "dgvDayResult";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDayResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDayResult.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDayResult.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDayResult.RowTemplate.Height = 23;
            this.dgvDayResult.Size = new System.Drawing.Size(986, 629);
            this.dgvDayResult.TabIndex = 10;
            // 
            // AtDate
            // 
            this.AtDate.DataPropertyName = "AtDate";
            this.AtDate.HeaderText = "日期";
            this.AtDate.Name = "AtDate";
            this.AtDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AtDate.Width = 72;
            // 
            // SfId
            // 
            this.SfId.DataPropertyName = "SfId";
            this.SfId.HeaderText = "考勤号";
            this.SfId.Name = "SfId";
            this.SfId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SfId.Width = 72;
            // 
            // SfName
            // 
            this.SfName.DataPropertyName = "SfName";
            this.SfName.HeaderText = "姓名";
            this.SfName.Name = "SfName";
            this.SfName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SfName.Width = 72;
            // 
            // SfGroup
            // 
            this.SfGroup.DataPropertyName = "SfGroup";
            this.SfGroup.HeaderText = "部门";
            this.SfGroup.Name = "SfGroup";
            this.SfGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.SfGroup.Width = 71;
            // 
            // ClassesName
            // 
            this.ClassesName.DataPropertyName = "ClassesName";
            this.ClassesName.HeaderText = "班次";
            this.ClassesName.Name = "ClassesName";
            this.ClassesName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ClassesName.Width = 73;
            // 
            // WorkTime1
            // 
            this.WorkTime1.DataPropertyName = "WorkTime1";
            this.WorkTime1.HeaderText = "上班1";
            this.WorkTime1.Name = "WorkTime1";
            this.WorkTime1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WorkTime1.Width = 73;
            // 
            // OffDutyTime1
            // 
            this.OffDutyTime1.DataPropertyName = "OffDutyTime1";
            this.OffDutyTime1.HeaderText = "下班1";
            this.OffDutyTime1.Name = "OffDutyTime1";
            this.OffDutyTime1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OffDutyTime1.Width = 73;
            // 
            // WorkTime2
            // 
            this.WorkTime2.DataPropertyName = "WorkTime2";
            this.WorkTime2.HeaderText = "上班2";
            this.WorkTime2.Name = "WorkTime2";
            this.WorkTime2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WorkTime2.Width = 73;
            // 
            // OffDutyTime2
            // 
            this.OffDutyTime2.DataPropertyName = "OffDutyTime2";
            this.OffDutyTime2.HeaderText = "下班2";
            this.OffDutyTime2.Name = "OffDutyTime2";
            this.OffDutyTime2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OffDutyTime2.Width = 73;
            // 
            // WorkTime3
            // 
            this.WorkTime3.DataPropertyName = "WorkTime3";
            this.WorkTime3.HeaderText = "上班3";
            this.WorkTime3.Name = "WorkTime3";
            this.WorkTime3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.WorkTime3.Width = 72;
            // 
            // OffDutyTime3
            // 
            this.OffDutyTime3.DataPropertyName = "OffDutyTime3";
            this.OffDutyTime3.HeaderText = "下班3";
            this.OffDutyTime3.Name = "OffDutyTime3";
            this.OffDutyTime3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OffDutyTime3.Width = 73;
            // 
            // AtDay
            // 
            this.AtDay.DataPropertyName = "AtDay";
            this.AtDay.HeaderText = "天数";
            this.AtDay.Name = "AtDay";
            this.AtDay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AtDay.Width = 73;
            // 
            // AtState
            // 
            this.AtState.DataPropertyName = "AtState";
            this.AtState.HeaderText = "考勤状态";
            this.AtState.Name = "AtState";
            this.AtState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AtState.Width = 73;
            // 
            // AtSign
            // 
            this.AtSign.DataPropertyName = "AtSign";
            this.AtSign.HeaderText = "处理标记";
            this.AtSign.Name = "AtSign";
            this.AtSign.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.AtSign.Width = 73;
            // 
            // btnBatch
            // 
            this.btnBatch.BackColor = System.Drawing.Color.White;
            this.btnBatch.Location = new System.Drawing.Point(864, 6);
            this.btnBatch.Name = "btnBatch";
            this.btnBatch.Size = new System.Drawing.Size(75, 48);
            this.btnBatch.TabIndex = 5;
            this.btnBatch.Text = "批量签卡";
            this.btnBatch.UseVisualStyleBackColor = false;
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Location = new System.Drawing.Point(509, 10);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(41, 12);
            this.lblClasses.TabIndex = 9;
            this.lblClasses.Text = "班次：";
            // 
            // cboClasses
            // 
            this.cboClasses.FormattingEnabled = true;
            this.cboClasses.Location = new System.Drawing.Point(554, 7);
            this.cboClasses.Name = "cboClasses";
            this.cboClasses.Size = new System.Drawing.Size(97, 20);
            this.cboClasses.TabIndex = 10;
            this.cboClasses.SelectedIndexChanged += new System.EventHandler(this.cboClasses_SelectedIndexChanged);
            // 
            // lblTimes
            // 
            this.lblTimes.AutoSize = true;
            this.lblTimes.Location = new System.Drawing.Point(509, 37);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(41, 12);
            this.lblTimes.TabIndex = 9;
            this.lblTimes.Text = "时段：";
            // 
            // cboTimes
            // 
            this.cboTimes.FormattingEnabled = true;
            this.cboTimes.Location = new System.Drawing.Point(554, 34);
            this.cboTimes.Name = "cboTimes";
            this.cboTimes.Size = new System.Drawing.Size(97, 20);
            this.cboTimes.TabIndex = 10;
            // 
            // FrmSignCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDayResult);
            this.Name = "FrmSignCard";
            this.Text = "考勤异常";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSignCard_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.DateTimePicker dtpQEndDate;
        private System.Windows.Forms.DateTimePicker dtpQBeginDate;
        private System.Windows.Forms.Label lblCEnd;
        private System.Windows.Forms.Label lblCBegin;
        private System.Windows.Forms.Button btnExactQuery;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dgvDayResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkTime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OffDutyTime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkTime2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OffDutyTime2;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkTime3;
        private System.Windows.Forms.DataGridViewTextBoxColumn OffDutyTime3;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtState;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtSign;
        private System.Windows.Forms.ComboBox cboTimes;
        private System.Windows.Forms.Label lblTimes;
        private System.Windows.Forms.ComboBox cboClasses;
        private System.Windows.Forms.Label lblClasses;
        private System.Windows.Forms.Button btnBatch;
    }
}