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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblCBegin = new System.Windows.Forms.Label();
            this.lblCEnd = new System.Windows.Forms.Label();
            this.dtpQBeginDate = new System.Windows.Forms.DateTimePicker();
            this.dtpQEndDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSign = new System.Windows.Forms.Button();
            this.cboSTime = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cboAttState = new System.Windows.Forms.ComboBox();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.lblSTime = new System.Windows.Forms.Label();
            this.lblAttState = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnBatch = new System.Windows.Forms.Button();
            this.cboBTime = new System.Windows.Forms.ComboBox();
            this.lblClasses = new System.Windows.Forms.Label();
            this.cboTimeName = new System.Windows.Forms.ComboBox();
            this.cboShiftName = new System.Windows.Forms.ComboBox();
            this.lblBTime = new System.Windows.Forms.Label();
            this.lblTimes = new System.Windows.Forms.Label();
            this.dgvDayResult = new System.Windows.Forms.DataGridView();
            this.AtDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtWeek = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.AtOvertime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkConfirm = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 111);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnQuery);
            this.panel2.Controls.Add(this.lblCBegin);
            this.panel2.Controls.Add(this.lblCEnd);
            this.panel2.Controls.Add(this.dtpQBeginDate);
            this.panel2.Controls.Add(this.dtpQEndDate);
            this.panel2.Location = new System.Drawing.Point(7, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(242, 95);
            this.panel2.TabIndex = 11;
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(155, 22);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 48);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询异常";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblCBegin
            // 
            this.lblCBegin.AutoSize = true;
            this.lblCBegin.Location = new System.Drawing.Point(9, 26);
            this.lblCBegin.Name = "lblCBegin";
            this.lblCBegin.Size = new System.Drawing.Size(29, 12);
            this.lblCBegin.TabIndex = 0;
            this.lblCBegin.Text = "从：";
            // 
            // lblCEnd
            // 
            this.lblCEnd.AutoSize = true;
            this.lblCEnd.Location = new System.Drawing.Point(9, 53);
            this.lblCEnd.Name = "lblCEnd";
            this.lblCEnd.Size = new System.Drawing.Size(29, 12);
            this.lblCEnd.TabIndex = 0;
            this.lblCEnd.Text = "到：";
            // 
            // dtpQBeginDate
            // 
            this.dtpQBeginDate.CustomFormat = "";
            this.dtpQBeginDate.Location = new System.Drawing.Point(39, 22);
            this.dtpQBeginDate.Name = "dtpQBeginDate";
            this.dtpQBeginDate.Size = new System.Drawing.Size(110, 21);
            this.dtpQBeginDate.TabIndex = 8;
            // 
            // dtpQEndDate
            // 
            this.dtpQEndDate.CustomFormat = "";
            this.dtpQEndDate.Location = new System.Drawing.Point(39, 49);
            this.dtpQEndDate.Name = "dtpQEndDate";
            this.dtpQEndDate.Size = new System.Drawing.Size(110, 21);
            this.dtpQEndDate.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.chkConfirm);
            this.panel3.Controls.Add(this.btnSign);
            this.panel3.Controls.Add(this.cboSTime);
            this.panel3.Controls.Add(this.lblDepartment);
            this.panel3.Controls.Add(this.cboAttState);
            this.panel3.Controls.Add(this.cboDepartment);
            this.panel3.Controls.Add(this.lblSTime);
            this.panel3.Controls.Add(this.lblAttState);
            this.panel3.Location = new System.Drawing.Point(277, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(263, 95);
            this.panel3.TabIndex = 11;
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.White;
            this.btnSign.Location = new System.Drawing.Point(170, 37);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(80, 46);
            this.btnSign.TabIndex = 5;
            this.btnSign.Text = "签卡";
            this.btnSign.UseVisualStyleBackColor = false;
            // 
            // cboSTime
            // 
            this.cboSTime.FormattingEnabled = true;
            this.cboSTime.Location = new System.Drawing.Point(52, 63);
            this.cboSTime.Name = "cboSTime";
            this.cboSTime.Size = new System.Drawing.Size(110, 20);
            this.cboSTime.TabIndex = 10;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(7, 13);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(41, 12);
            this.lblDepartment.TabIndex = 9;
            this.lblDepartment.Text = "部门：";
            // 
            // cboAttState
            // 
            this.cboAttState.FormattingEnabled = true;
            this.cboAttState.Location = new System.Drawing.Point(52, 37);
            this.cboAttState.Name = "cboAttState";
            this.cboAttState.Size = new System.Drawing.Size(110, 20);
            this.cboAttState.TabIndex = 10;
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(52, 10);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(110, 20);
            this.cboDepartment.TabIndex = 10;
            // 
            // lblSTime
            // 
            this.lblSTime.AutoSize = true;
            this.lblSTime.Location = new System.Drawing.Point(7, 66);
            this.lblSTime.Name = "lblSTime";
            this.lblSTime.Size = new System.Drawing.Size(41, 12);
            this.lblSTime.TabIndex = 9;
            this.lblSTime.Text = "时间：";
            // 
            // lblAttState
            // 
            this.lblAttState.AutoSize = true;
            this.lblAttState.Location = new System.Drawing.Point(7, 40);
            this.lblAttState.Name = "lblAttState";
            this.lblAttState.Size = new System.Drawing.Size(41, 12);
            this.lblAttState.TabIndex = 9;
            this.lblAttState.Text = "状态：";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Controls.Add(this.btnBatch);
            this.panel4.Controls.Add(this.cboBTime);
            this.panel4.Controls.Add(this.lblClasses);
            this.panel4.Controls.Add(this.cboTimeName);
            this.panel4.Controls.Add(this.cboShiftName);
            this.panel4.Controls.Add(this.lblBTime);
            this.panel4.Controls.Add(this.lblTimes);
            this.panel4.Location = new System.Drawing.Point(568, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(253, 95);
            this.panel4.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.Blue;
            this.checkBox1.Location = new System.Drawing.Point(167, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 16);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "已处理异常";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnBatch
            // 
            this.btnBatch.BackColor = System.Drawing.Color.White;
            this.btnBatch.Location = new System.Drawing.Point(166, 37);
            this.btnBatch.Name = "btnBatch";
            this.btnBatch.Size = new System.Drawing.Size(80, 46);
            this.btnBatch.TabIndex = 5;
            this.btnBatch.Text = "批量签卡";
            this.btnBatch.UseVisualStyleBackColor = false;
            this.btnBatch.Click += new System.EventHandler(this.btnBatch_Click);
            // 
            // cboBTime
            // 
            this.cboBTime.FormattingEnabled = true;
            this.cboBTime.Location = new System.Drawing.Point(49, 63);
            this.cboBTime.Name = "cboBTime";
            this.cboBTime.Size = new System.Drawing.Size(110, 20);
            this.cboBTime.TabIndex = 10;
            this.cboBTime.SelectedIndexChanged += new System.EventHandler(this.cboTime_SelectedIndexChanged);
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Location = new System.Drawing.Point(4, 13);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(41, 12);
            this.lblClasses.TabIndex = 9;
            this.lblClasses.Text = "班次：";
            // 
            // cboTimeName
            // 
            this.cboTimeName.FormattingEnabled = true;
            this.cboTimeName.Location = new System.Drawing.Point(49, 37);
            this.cboTimeName.Name = "cboTimeName";
            this.cboTimeName.Size = new System.Drawing.Size(110, 20);
            this.cboTimeName.TabIndex = 10;
            this.cboTimeName.SelectedIndexChanged += new System.EventHandler(this.cboTimeName_SelectedIndexChanged);
            // 
            // cboShiftName
            // 
            this.cboShiftName.FormattingEnabled = true;
            this.cboShiftName.Location = new System.Drawing.Point(49, 10);
            this.cboShiftName.Name = "cboShiftName";
            this.cboShiftName.Size = new System.Drawing.Size(110, 20);
            this.cboShiftName.TabIndex = 10;
            this.cboShiftName.SelectedIndexChanged += new System.EventHandler(this.cboClasses_SelectedIndexChanged);
            // 
            // lblBTime
            // 
            this.lblBTime.AutoSize = true;
            this.lblBTime.Location = new System.Drawing.Point(4, 66);
            this.lblBTime.Name = "lblBTime";
            this.lblBTime.Size = new System.Drawing.Size(41, 12);
            this.lblBTime.TabIndex = 9;
            this.lblBTime.Text = "时间：";
            // 
            // lblTimes
            // 
            this.lblTimes.AutoSize = true;
            this.lblTimes.Location = new System.Drawing.Point(4, 40);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(41, 12);
            this.lblTimes.TabIndex = 9;
            this.lblTimes.Text = "时段：";
            // 
            // dgvDayResult
            // 
            this.dgvDayResult.AllowUserToAddRows = false;
            this.dgvDayResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDayResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDayResult.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDayResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDayResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AtDate,
            this.AtWeek,
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
            this.AtSign,
            this.AtOvertime});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDayResult.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDayResult.Location = new System.Drawing.Point(12, 129);
            this.dgvDayResult.Name = "dgvDayResult";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDayResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDayResult.RowHeadersWidth = 30;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDayResult.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDayResult.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDayResult.RowTemplate.Height = 23;
            this.dgvDayResult.Size = new System.Drawing.Size(986, 588);
            this.dgvDayResult.TabIndex = 10;
            // 
            // AtDate
            // 
            this.AtDate.DataPropertyName = "AtDate";
            this.AtDate.HeaderText = "日期";
            this.AtDate.Name = "AtDate";
            this.AtDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AtWeek
            // 
            this.AtWeek.DataPropertyName = "AtWeek";
            this.AtWeek.HeaderText = "星期";
            this.AtWeek.Name = "AtWeek";
            this.AtWeek.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SfId
            // 
            this.SfId.DataPropertyName = "SfId";
            this.SfId.HeaderText = "考勤号";
            this.SfId.Name = "SfId";
            this.SfId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SfName
            // 
            this.SfName.DataPropertyName = "SfName";
            this.SfName.HeaderText = "姓名";
            this.SfName.Name = "SfName";
            this.SfName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SfGroup
            // 
            this.SfGroup.DataPropertyName = "SfGroup";
            this.SfGroup.HeaderText = "部门";
            this.SfGroup.Name = "SfGroup";
            this.SfGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClassesName
            // 
            this.ClassesName.DataPropertyName = "ClassesName";
            this.ClassesName.HeaderText = "班次";
            this.ClassesName.Name = "ClassesName";
            this.ClassesName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // WorkTime1
            // 
            this.WorkTime1.DataPropertyName = "WorkTime1";
            this.WorkTime1.HeaderText = "上班1";
            this.WorkTime1.Name = "WorkTime1";
            this.WorkTime1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OffDutyTime1
            // 
            this.OffDutyTime1.DataPropertyName = "OffDutyTime1";
            this.OffDutyTime1.HeaderText = "下班1";
            this.OffDutyTime1.Name = "OffDutyTime1";
            this.OffDutyTime1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // WorkTime2
            // 
            this.WorkTime2.DataPropertyName = "WorkTime2";
            this.WorkTime2.HeaderText = "上班2";
            this.WorkTime2.Name = "WorkTime2";
            this.WorkTime2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OffDutyTime2
            // 
            this.OffDutyTime2.DataPropertyName = "OffDutyTime2";
            this.OffDutyTime2.HeaderText = "下班2";
            this.OffDutyTime2.Name = "OffDutyTime2";
            this.OffDutyTime2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // WorkTime3
            // 
            this.WorkTime3.DataPropertyName = "WorkTime3";
            this.WorkTime3.HeaderText = "上班3";
            this.WorkTime3.Name = "WorkTime3";
            this.WorkTime3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OffDutyTime3
            // 
            this.OffDutyTime3.DataPropertyName = "OffDutyTime3";
            this.OffDutyTime3.HeaderText = "下班3";
            this.OffDutyTime3.Name = "OffDutyTime3";
            this.OffDutyTime3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AtDay
            // 
            this.AtDay.DataPropertyName = "AtDay";
            this.AtDay.HeaderText = "天数";
            this.AtDay.Name = "AtDay";
            this.AtDay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AtState
            // 
            this.AtState.DataPropertyName = "AtState";
            this.AtState.HeaderText = "考勤状态";
            this.AtState.Name = "AtState";
            this.AtState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AtSign
            // 
            this.AtSign.DataPropertyName = "AtSign";
            this.AtSign.HeaderText = "处理标记";
            this.AtSign.Name = "AtSign";
            this.AtSign.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AtOvertime
            // 
            this.AtOvertime.DataPropertyName = "AtOvertime";
            this.AtOvertime.HeaderText = "加班标记";
            this.AtOvertime.Name = "AtOvertime";
            // 
            // chkConfirm
            // 
            this.chkConfirm.AutoSize = true;
            this.chkConfirm.ForeColor = System.Drawing.Color.Blue;
            this.chkConfirm.Location = new System.Drawing.Point(171, 13);
            this.chkConfirm.Name = "chkConfirm";
            this.chkConfirm.Size = new System.Drawing.Size(84, 16);
            this.chkConfirm.TabIndex = 11;
            this.chkConfirm.Text = "已处理异常";
            this.chkConfirm.UseVisualStyleBackColor = true;
            // 
            // FrmSignCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDayResult);
            this.Name = "FrmSignCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考勤异常";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSignCard_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpQEndDate;
        private System.Windows.Forms.DateTimePicker dtpQBeginDate;
        private System.Windows.Forms.Label lblCEnd;
        private System.Windows.Forms.Label lblCBegin;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.DataGridView dgvDayResult;
        private System.Windows.Forms.ComboBox cboShiftName;
        private System.Windows.Forms.Label lblClasses;
        private System.Windows.Forms.Button btnBatch;
        private System.Windows.Forms.ComboBox cboTimeName;
        private System.Windows.Forms.Label lblTimes;
        private System.Windows.Forms.ComboBox cboBTime;
        private System.Windows.Forms.Label lblBTime;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.ComboBox cboSTime;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cboAttState;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label lblSTime;
        private System.Windows.Forms.Label lblAttState;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtWeek;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn AtOvertime;
        private System.Windows.Forms.CheckBox chkConfirm;
    }
}