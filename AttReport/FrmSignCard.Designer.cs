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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblCBegin = new System.Windows.Forms.Label();
            this.lblCEnd = new System.Windows.Forms.Label();
            this.dtpQBeginDate = new System.Windows.Forms.DateTimePicker();
            this.dtpQEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnSign = new System.Windows.Forms.Button();
            this.cboSTime = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cboAttState = new System.Windows.Forms.ComboBox();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.lblSTime = new System.Windows.Forms.Label();
            this.lblAttState = new System.Windows.Forms.Label();
            this.btnBatch = new System.Windows.Forms.Button();
            this.lblClasses = new System.Windows.Forms.Label();
            this.cboTimeName = new System.Windows.Forms.ComboBox();
            this.cboShiftName = new System.Windows.Forms.ComboBox();
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkConfirm2 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkConfirm1 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(51, 70);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询异常";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // lblCBegin
            // 
            this.lblCBegin.AutoSize = true;
            this.lblCBegin.Location = new System.Drawing.Point(22, 21);
            this.lblCBegin.Name = "lblCBegin";
            this.lblCBegin.Size = new System.Drawing.Size(29, 12);
            this.lblCBegin.TabIndex = 0;
            this.lblCBegin.Text = "从：";
            // 
            // lblCEnd
            // 
            this.lblCEnd.AutoSize = true;
            this.lblCEnd.Location = new System.Drawing.Point(22, 48);
            this.lblCEnd.Name = "lblCEnd";
            this.lblCEnd.Size = new System.Drawing.Size(29, 12);
            this.lblCEnd.TabIndex = 0;
            this.lblCEnd.Text = "到：";
            // 
            // dtpQBeginDate
            // 
            this.dtpQBeginDate.CustomFormat = "";
            this.dtpQBeginDate.Location = new System.Drawing.Point(52, 17);
            this.dtpQBeginDate.Name = "dtpQBeginDate";
            this.dtpQBeginDate.Size = new System.Drawing.Size(110, 21);
            this.dtpQBeginDate.TabIndex = 8;
            // 
            // dtpQEndDate
            // 
            this.dtpQEndDate.CustomFormat = "";
            this.dtpQEndDate.Location = new System.Drawing.Point(52, 44);
            this.dtpQEndDate.Name = "dtpQEndDate";
            this.dtpQEndDate.Size = new System.Drawing.Size(110, 21);
            this.dtpQEndDate.TabIndex = 8;
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.White;
            this.btnSign.Location = new System.Drawing.Point(52, 130);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(80, 23);
            this.btnSign.TabIndex = 5;
            this.btnSign.Text = "签卡";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // cboSTime
            // 
            this.cboSTime.FormattingEnabled = true;
            this.cboSTime.Location = new System.Drawing.Point(53, 73);
            this.cboSTime.Name = "cboSTime";
            this.cboSTime.Size = new System.Drawing.Size(110, 20);
            this.cboSTime.TabIndex = 10;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(8, 23);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(41, 12);
            this.lblDepartment.TabIndex = 9;
            this.lblDepartment.Text = "部门：";
            // 
            // cboAttState
            // 
            this.cboAttState.FormattingEnabled = true;
            this.cboAttState.Location = new System.Drawing.Point(53, 47);
            this.cboAttState.Name = "cboAttState";
            this.cboAttState.Size = new System.Drawing.Size(110, 20);
            this.cboAttState.TabIndex = 10;
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(53, 20);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(110, 20);
            this.cboDepartment.TabIndex = 10;
            // 
            // lblSTime
            // 
            this.lblSTime.AutoSize = true;
            this.lblSTime.Location = new System.Drawing.Point(8, 76);
            this.lblSTime.Name = "lblSTime";
            this.lblSTime.Size = new System.Drawing.Size(41, 12);
            this.lblSTime.TabIndex = 9;
            this.lblSTime.Text = "时间：";
            // 
            // lblAttState
            // 
            this.lblAttState.AutoSize = true;
            this.lblAttState.Location = new System.Drawing.Point(8, 50);
            this.lblAttState.Name = "lblAttState";
            this.lblAttState.Size = new System.Drawing.Size(41, 12);
            this.lblAttState.TabIndex = 9;
            this.lblAttState.Text = "状态：";
            // 
            // btnBatch
            // 
            this.btnBatch.BackColor = System.Drawing.Color.White;
            this.btnBatch.Location = new System.Drawing.Point(53, 107);
            this.btnBatch.Name = "btnBatch";
            this.btnBatch.Size = new System.Drawing.Size(80, 23);
            this.btnBatch.TabIndex = 5;
            this.btnBatch.Text = "批量签卡";
            this.btnBatch.UseVisualStyleBackColor = false;
            this.btnBatch.Click += new System.EventHandler(this.btnBatch_Click);
            // 
            // lblClasses
            // 
            this.lblClasses.AutoSize = true;
            this.lblClasses.Location = new System.Drawing.Point(9, 26);
            this.lblClasses.Name = "lblClasses";
            this.lblClasses.Size = new System.Drawing.Size(41, 12);
            this.lblClasses.TabIndex = 9;
            this.lblClasses.Text = "班次：";
            // 
            // cboTimeName
            // 
            this.cboTimeName.FormattingEnabled = true;
            this.cboTimeName.Location = new System.Drawing.Point(54, 50);
            this.cboTimeName.Name = "cboTimeName";
            this.cboTimeName.Size = new System.Drawing.Size(110, 20);
            this.cboTimeName.TabIndex = 10;
            // 
            // cboShiftName
            // 
            this.cboShiftName.FormattingEnabled = true;
            this.cboShiftName.Location = new System.Drawing.Point(54, 23);
            this.cboShiftName.Name = "cboShiftName";
            this.cboShiftName.Size = new System.Drawing.Size(110, 20);
            this.cboShiftName.TabIndex = 10;
            this.cboShiftName.SelectedIndexChanged += new System.EventHandler(this.cboClasses_SelectedIndexChanged);
            // 
            // lblTimes
            // 
            this.lblTimes.AutoSize = true;
            this.lblTimes.Location = new System.Drawing.Point(9, 53);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDayResult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDayResult.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDayResult.Location = new System.Drawing.Point(5, 6);
            this.dgvDayResult.Name = "dgvDayResult";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDayResult.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDayResult.RowHeadersWidth = 30;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDayResult.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDayResult.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDayResult.RowTemplate.Height = 23;
            this.dgvDayResult.Size = new System.Drawing.Size(822, 718);
            this.dgvDayResult.TabIndex = 10;
            // 
            // AtDate
            // 
            this.AtDate.DataPropertyName = "AtDate";
            this.AtDate.FillWeight = 98.11322F;
            this.AtDate.HeaderText = "日期";
            this.AtDate.Name = "AtDate";
            this.AtDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AtWeek
            // 
            this.AtWeek.DataPropertyName = "AtWeek";
            this.AtWeek.FillWeight = 100.6741F;
            this.AtWeek.HeaderText = "星期";
            this.AtWeek.Name = "AtWeek";
            this.AtWeek.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SfId
            // 
            this.SfId.DataPropertyName = "SfId";
            this.SfId.FillWeight = 98.04416F;
            this.SfId.HeaderText = "考勤号";
            this.SfId.Name = "SfId";
            this.SfId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SfName
            // 
            this.SfName.DataPropertyName = "SfName";
            this.SfName.FillWeight = 83.00127F;
            this.SfName.HeaderText = "姓名";
            this.SfName.Name = "SfName";
            this.SfName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SfGroup
            // 
            this.SfGroup.DataPropertyName = "SfGroup";
            this.SfGroup.FillWeight = 99.06306F;
            this.SfGroup.HeaderText = "部门";
            this.SfGroup.Name = "SfGroup";
            this.SfGroup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ClassesName
            // 
            this.ClassesName.DataPropertyName = "ClassesName";
            this.ClassesName.FillWeight = 101.5885F;
            this.ClassesName.HeaderText = "班次";
            this.ClassesName.Name = "ClassesName";
            this.ClassesName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // WorkTime1
            // 
            this.WorkTime1.DataPropertyName = "WorkTime1";
            this.WorkTime1.FillWeight = 103.9505F;
            this.WorkTime1.HeaderText = "上班1";
            this.WorkTime1.Name = "WorkTime1";
            this.WorkTime1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OffDutyTime1
            // 
            this.OffDutyTime1.DataPropertyName = "OffDutyTime1";
            this.OffDutyTime1.FillWeight = 101.0931F;
            this.OffDutyTime1.HeaderText = "下班1";
            this.OffDutyTime1.Name = "OffDutyTime1";
            this.OffDutyTime1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // WorkTime2
            // 
            this.WorkTime2.DataPropertyName = "WorkTime2";
            this.WorkTime2.FillWeight = 103.4745F;
            this.WorkTime2.HeaderText = "上班2";
            this.WorkTime2.Name = "WorkTime2";
            this.WorkTime2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OffDutyTime2
            // 
            this.OffDutyTime2.DataPropertyName = "OffDutyTime2";
            this.OffDutyTime2.FillWeight = 100.6587F;
            this.OffDutyTime2.HeaderText = "下班2";
            this.OffDutyTime2.Name = "OffDutyTime2";
            this.OffDutyTime2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // WorkTime3
            // 
            this.WorkTime3.DataPropertyName = "WorkTime3";
            this.WorkTime3.FillWeight = 103.0573F;
            this.WorkTime3.HeaderText = "上班3";
            this.WorkTime3.Name = "WorkTime3";
            this.WorkTime3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OffDutyTime3
            // 
            this.OffDutyTime3.DataPropertyName = "OffDutyTime3";
            this.OffDutyTime3.FillWeight = 100.2779F;
            this.OffDutyTime3.HeaderText = "下班3";
            this.OffDutyTime3.Name = "OffDutyTime3";
            this.OffDutyTime3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AtDay
            // 
            this.AtDay.DataPropertyName = "AtDay";
            this.AtDay.FillWeight = 102.6916F;
            this.AtDay.HeaderText = "天数";
            this.AtDay.Name = "AtDay";
            this.AtDay.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AtState
            // 
            this.AtState.DataPropertyName = "AtState";
            this.AtState.FillWeight = 102.4427F;
            this.AtState.HeaderText = "考勤状态";
            this.AtState.Name = "AtState";
            this.AtState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AtSign
            // 
            this.AtSign.DataPropertyName = "AtSign";
            this.AtSign.FillWeight = 99.7169F;
            this.AtSign.HeaderText = "处理标记";
            this.AtSign.Name = "AtSign";
            this.AtSign.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AtOvertime
            // 
            this.AtOvertime.DataPropertyName = "AtOvertime";
            this.AtOvertime.FillWeight = 102.1527F;
            this.AtOvertime.HeaderText = "加班标记";
            this.AtOvertime.Name = "AtOvertime";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel1.Controls.Add(this.dgvDayResult);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox4);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 729);
            this.splitContainer1.SplitterDistance = 831;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.MintCream;
            this.groupBox4.Controls.Add(this.btnQuery);
            this.groupBox4.Controls.Add(this.dtpQEndDate);
            this.groupBox4.Controls.Add(this.lblCBegin);
            this.groupBox4.Controls.Add(this.dtpQBeginDate);
            this.groupBox4.Controls.Add(this.lblCEnd);
            this.groupBox4.Location = new System.Drawing.Point(5, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 100);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "查询异常";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.MintCream;
            this.groupBox3.Controls.Add(this.chkConfirm2);
            this.groupBox3.Controls.Add(this.btnBatch);
            this.groupBox3.Controls.Add(this.lblTimes);
            this.groupBox3.Controls.Add(this.lblClasses);
            this.groupBox3.Controls.Add(this.cboShiftName);
            this.groupBox3.Controls.Add(this.cboTimeName);
            this.groupBox3.Location = new System.Drawing.Point(5, 586);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 139);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "批量签卡";
            // 
            // chkConfirm2
            // 
            this.chkConfirm2.AutoSize = true;
            this.chkConfirm2.ForeColor = System.Drawing.Color.Blue;
            this.chkConfirm2.Location = new System.Drawing.Point(54, 85);
            this.chkConfirm2.Name = "chkConfirm2";
            this.chkConfirm2.Size = new System.Drawing.Size(84, 16);
            this.chkConfirm2.TabIndex = 11;
            this.chkConfirm2.Text = "已处理异常";
            this.chkConfirm2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MintCream;
            this.groupBox2.Controls.Add(this.chkConfirm1);
            this.groupBox2.Controls.Add(this.btnSign);
            this.groupBox2.Controls.Add(this.lblAttState);
            this.groupBox2.Controls.Add(this.cboSTime);
            this.groupBox2.Controls.Add(this.lblSTime);
            this.groupBox2.Controls.Add(this.lblDepartment);
            this.groupBox2.Controls.Add(this.cboDepartment);
            this.groupBox2.Controls.Add(this.cboAttState);
            this.groupBox2.Location = new System.Drawing.Point(5, 407);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 164);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "签卡";
            // 
            // chkConfirm1
            // 
            this.chkConfirm1.AutoSize = true;
            this.chkConfirm1.ForeColor = System.Drawing.Color.Blue;
            this.chkConfirm1.Location = new System.Drawing.Point(53, 108);
            this.chkConfirm1.Name = "chkConfirm1";
            this.chkConfirm1.Size = new System.Drawing.Size(84, 16);
            this.chkConfirm1.TabIndex = 11;
            this.chkConfirm1.Text = "已处理异常";
            this.chkConfirm1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MintCream;
            this.groupBox1.Controls.Add(this.btnConfirm);
            this.groupBox1.Controls.Add(this.btnClean);
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.dateTimePicker5);
            this.groupBox1.Controls.Add(this.dateTimePicker3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "异常处理";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(111, 233);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(53, 23);
            this.btnConfirm.TabIndex = 22;
            this.btnConfirm.Text = "确认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(9, 233);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(53, 23);
            this.btnClean.TabIndex = 22;
            this.btnClean.Text = "清除";
            this.btnClean.UseVisualStyleBackColor = true;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(53, 79);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(110, 20);
            this.comboBox3.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "从：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "状态：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "到：";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(53, 50);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(110, 20);
            this.comboBox2.TabIndex = 19;
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.CustomFormat = "";
            this.dateTimePicker5.Location = new System.Drawing.Point(53, 111);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(110, 21);
            this.dateTimePicker5.TabIndex = 13;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(53, 139);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(110, 21);
            this.dateTimePicker3.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "姓名：";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Location = new System.Drawing.Point(53, 173);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(110, 21);
            this.dateTimePicker2.TabIndex = 14;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker4.Location = new System.Drawing.Point(53, 201);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(110, 21);
            this.dateTimePicker4.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(53, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 20);
            this.comboBox1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "部门：";
            // 
            // FrmSignCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmSignCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考勤异常";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSignCard_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDayResult)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.ComboBox cboSTime;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cboAttState;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label lblSTime;
        private System.Windows.Forms.Label lblAttState;
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.CheckBox chkConfirm2;
        private System.Windows.Forms.CheckBox chkConfirm1;
    }
}