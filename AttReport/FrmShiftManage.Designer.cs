namespace AttReport
{
    partial class FrmShiftManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvClassses = new System.Windows.Forms.DataGridView();
            this.ClassesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OffDutyTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartSignBack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndSignBack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftEarly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DayNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimesName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLateTime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLeftEarly = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDayNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.CboClassName = new System.Windows.Forms.ComboBox();
            this.chkMonday = new System.Windows.Forms.CheckBox();
            this.chkTuesday = new System.Windows.Forms.CheckBox();
            this.chkWednesday = new System.Windows.Forms.CheckBox();
            this.chkThursday = new System.Windows.Forms.CheckBox();
            this.chkFriday = new System.Windows.Forms.CheckBox();
            this.chkSaturday = new System.Windows.Forms.CheckBox();
            this.chkSunday = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpEndSignBack = new System.Windows.Forms.DateTimePicker();
            this.dtpEndCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpStartSignBack = new System.Windows.Forms.DateTimePicker();
            this.dtpStartCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpOffDutyTime = new System.Windows.Forms.DateTimePicker();
            this.dtpWorkTime = new System.Windows.Forms.DateTimePicker();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClassesAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassses)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClassses
            // 
            this.dgvClassses.AllowUserToOrderColumns = true;
            this.dgvClassses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClassses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClassses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvClassses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassesName,
            this.TimesName,
            this.WorkTime,
            this.OffDutyTime,
            this.StartCheckIn,
            this.EndCheckIn,
            this.StartSignBack,
            this.EndSignBack,
            this.LateTime,
            this.LeftEarly,
            this.DayNumber,
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.Saturday,
            this.Sunday});
            this.dgvClassses.Location = new System.Drawing.Point(12, 337);
            this.dgvClassses.Name = "dgvClassses";
            this.dgvClassses.RowHeadersVisible = false;
            this.dgvClassses.RowTemplate.Height = 23;
            this.dgvClassses.Size = new System.Drawing.Size(984, 380);
            this.dgvClassses.TabIndex = 0;
            // 
            // ClassesName
            // 
            this.ClassesName.DataPropertyName = "ClassesName";
            this.ClassesName.HeaderText = "班次名称";
            this.ClassesName.Name = "ClassesName";
            this.ClassesName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TimesName
            // 
            this.TimesName.DataPropertyName = "TimesName";
            this.TimesName.HeaderText = "时段名称";
            this.TimesName.Name = "TimesName";
            this.TimesName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // WorkTime
            // 
            this.WorkTime.DataPropertyName = "WorkTime";
            dataGridViewCellStyle8.NullValue = null;
            this.WorkTime.DefaultCellStyle = dataGridViewCellStyle8;
            this.WorkTime.HeaderText = "上班时间";
            this.WorkTime.Name = "WorkTime";
            this.WorkTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OffDutyTime
            // 
            this.OffDutyTime.DataPropertyName = "OffDutyTime";
            this.OffDutyTime.HeaderText = "下班时间";
            this.OffDutyTime.Name = "OffDutyTime";
            this.OffDutyTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StartCheckIn
            // 
            this.StartCheckIn.DataPropertyName = "StartCheckIn";
            this.StartCheckIn.HeaderText = "开始签到";
            this.StartCheckIn.Name = "StartCheckIn";
            this.StartCheckIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EndCheckIn
            // 
            this.EndCheckIn.DataPropertyName = "EndCheckIn";
            this.EndCheckIn.HeaderText = "结束签到";
            this.EndCheckIn.Name = "EndCheckIn";
            this.EndCheckIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StartSignBack
            // 
            this.StartSignBack.DataPropertyName = "StartSignBack";
            this.StartSignBack.HeaderText = "天始签退";
            this.StartSignBack.Name = "StartSignBack";
            this.StartSignBack.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EndSignBack
            // 
            this.EndSignBack.DataPropertyName = "EndSignBack";
            this.EndSignBack.HeaderText = "结束签退";
            this.EndSignBack.Name = "EndSignBack";
            this.EndSignBack.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LateTime
            // 
            this.LateTime.DataPropertyName = "LateTime";
            this.LateTime.HeaderText = "迟到";
            this.LateTime.Name = "LateTime";
            this.LateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LeftEarly
            // 
            this.LeftEarly.DataPropertyName = "LeftEarly";
            this.LeftEarly.HeaderText = "早退";
            this.LeftEarly.Name = "LeftEarly";
            this.LeftEarly.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DayNumber
            // 
            this.DayNumber.DataPropertyName = "DayNumber";
            this.DayNumber.HeaderText = "天数";
            this.DayNumber.Name = "DayNumber";
            this.DayNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Monday
            // 
            this.Monday.DataPropertyName = "Monday";
            this.Monday.HeaderText = "周一";
            this.Monday.Name = "Monday";
            this.Monday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tuesday
            // 
            this.Tuesday.DataPropertyName = "Tuesday";
            this.Tuesday.HeaderText = "周二";
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Wednesday
            // 
            this.Wednesday.DataPropertyName = "Wednesday";
            this.Wednesday.HeaderText = "周三";
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Thursday
            // 
            this.Thursday.DataPropertyName = "Thursday";
            this.Thursday.HeaderText = "周四";
            this.Thursday.Name = "Thursday";
            this.Thursday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Friday
            // 
            this.Friday.DataPropertyName = "Friday";
            this.Friday.HeaderText = "周五";
            this.Friday.Name = "Friday";
            this.Friday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Saturday
            // 
            this.Saturday.DataPropertyName = "Saturday";
            this.Saturday.HeaderText = "周六";
            this.Saturday.Name = "Saturday";
            this.Saturday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Sunday
            // 
            this.Sunday.DataPropertyName = "Sunday";
            this.Sunday.HeaderText = "周日";
            this.Sunday.Name = "Sunday";
            this.Sunday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "时段名称：";
            // 
            // txtTimesName
            // 
            this.txtTimesName.Location = new System.Drawing.Point(358, 35);
            this.txtTimesName.Name = "txtTimesName";
            this.txtTimesName.Size = new System.Drawing.Size(121, 21);
            this.txtTimesName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "上班时间：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "下班时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "迟到分钟数：";
            // 
            // txtLateTime
            // 
            this.txtLateTime.Location = new System.Drawing.Point(117, 121);
            this.txtLateTime.Name = "txtLateTime";
            this.txtLateTime.Size = new System.Drawing.Size(121, 21);
            this.txtLateTime.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(275, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "早退分钟数：";
            // 
            // txtLeftEarly
            // 
            this.txtLeftEarly.Location = new System.Drawing.Point(358, 121);
            this.txtLeftEarly.Name = "txtLeftEarly";
            this.txtLeftEarly.Size = new System.Drawing.Size(121, 21);
            this.txtLeftEarly.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "开始签到时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(263, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "结束签到时间：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 2;
            this.label8.Text = "开始签退时间：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(263, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 2;
            this.label9.Text = "结束签退时间：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(574, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "记多少个工作日：";
            // 
            // txtDayNumber
            // 
            this.txtDayNumber.Location = new System.Drawing.Point(681, 79);
            this.txtDayNumber.Name = "txtDayNumber";
            this.txtDayNumber.Size = new System.Drawing.Size(121, 21);
            this.txtDayNumber.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "班次名称：";
            // 
            // CboClassName
            // 
            this.CboClassName.FormattingEnabled = true;
            this.CboClassName.Location = new System.Drawing.Point(117, 36);
            this.CboClassName.Name = "CboClassName";
            this.CboClassName.Size = new System.Drawing.Size(121, 20);
            this.CboClassName.TabIndex = 6;
            // 
            // chkMonday
            // 
            this.chkMonday.AutoSize = true;
            this.chkMonday.Location = new System.Drawing.Point(576, 134);
            this.chkMonday.Name = "chkMonday";
            this.chkMonday.Size = new System.Drawing.Size(48, 16);
            this.chkMonday.TabIndex = 7;
            this.chkMonday.Text = "周一";
            this.chkMonday.UseVisualStyleBackColor = true;
            // 
            // chkTuesday
            // 
            this.chkTuesday.AutoSize = true;
            this.chkTuesday.Location = new System.Drawing.Point(630, 134);
            this.chkTuesday.Name = "chkTuesday";
            this.chkTuesday.Size = new System.Drawing.Size(48, 16);
            this.chkTuesday.TabIndex = 7;
            this.chkTuesday.Text = "周二";
            this.chkTuesday.UseVisualStyleBackColor = true;
            // 
            // chkWednesday
            // 
            this.chkWednesday.AutoSize = true;
            this.chkWednesday.Location = new System.Drawing.Point(684, 134);
            this.chkWednesday.Name = "chkWednesday";
            this.chkWednesday.Size = new System.Drawing.Size(48, 16);
            this.chkWednesday.TabIndex = 7;
            this.chkWednesday.Text = "周三";
            this.chkWednesday.UseVisualStyleBackColor = true;
            // 
            // chkThursday
            // 
            this.chkThursday.AutoSize = true;
            this.chkThursday.Location = new System.Drawing.Point(738, 134);
            this.chkThursday.Name = "chkThursday";
            this.chkThursday.Size = new System.Drawing.Size(48, 16);
            this.chkThursday.TabIndex = 7;
            this.chkThursday.Text = "周四";
            this.chkThursday.UseVisualStyleBackColor = true;
            // 
            // chkFriday
            // 
            this.chkFriday.AutoSize = true;
            this.chkFriday.Location = new System.Drawing.Point(792, 134);
            this.chkFriday.Name = "chkFriday";
            this.chkFriday.Size = new System.Drawing.Size(48, 16);
            this.chkFriday.TabIndex = 7;
            this.chkFriday.Text = "周五";
            this.chkFriday.UseVisualStyleBackColor = true;
            // 
            // chkSaturday
            // 
            this.chkSaturday.AutoSize = true;
            this.chkSaturday.ForeColor = System.Drawing.Color.Red;
            this.chkSaturday.Location = new System.Drawing.Point(576, 161);
            this.chkSaturday.Name = "chkSaturday";
            this.chkSaturday.Size = new System.Drawing.Size(48, 16);
            this.chkSaturday.TabIndex = 7;
            this.chkSaturday.Text = "周六";
            this.chkSaturday.UseVisualStyleBackColor = true;
            // 
            // chkSunday
            // 
            this.chkSunday.AutoSize = true;
            this.chkSunday.ForeColor = System.Drawing.Color.Red;
            this.chkSunday.Location = new System.Drawing.Point(630, 161);
            this.chkSunday.Name = "chkSunday";
            this.chkSunday.Size = new System.Drawing.Size(48, 16);
            this.chkSunday.TabIndex = 7;
            this.chkSunday.Text = "周日";
            this.chkSunday.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpEndSignBack);
            this.groupBox1.Controls.Add(this.dtpEndCheckIn);
            this.groupBox1.Controls.Add(this.dtpStartSignBack);
            this.groupBox1.Controls.Add(this.dtpStartCheckIn);
            this.groupBox1.Controls.Add(this.dtpOffDutyTime);
            this.groupBox1.Controls.Add(this.dtpWorkTime);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.chkThursday);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnClassesAdd);
            this.groupBox1.Controls.Add(this.chkSunday);
            this.groupBox1.Controls.Add(this.chkSaturday);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkWednesday);
            this.groupBox1.Controls.Add(this.txtLateTime);
            this.groupBox1.Controls.Add(this.chkFriday);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkTuesday);
            this.groupBox1.Controls.Add(this.chkMonday);
            this.groupBox1.Controls.Add(this.CboClassName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtDayNumber);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTimesName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtLeftEarly);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 306);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "班次时间修改";
            // 
            // dtpEndSignBack
            // 
            this.dtpEndSignBack.CustomFormat = "HH:mm:ss";
            this.dtpEndSignBack.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndSignBack.Location = new System.Drawing.Point(358, 206);
            this.dtpEndSignBack.Name = "dtpEndSignBack";
            this.dtpEndSignBack.ShowUpDown = true;
            this.dtpEndSignBack.Size = new System.Drawing.Size(121, 21);
            this.dtpEndSignBack.TabIndex = 8;
            // 
            // dtpEndCheckIn
            // 
            this.dtpEndCheckIn.CustomFormat = "HH:mm:ss";
            this.dtpEndCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpEndCheckIn.Location = new System.Drawing.Point(358, 163);
            this.dtpEndCheckIn.Name = "dtpEndCheckIn";
            this.dtpEndCheckIn.ShowUpDown = true;
            this.dtpEndCheckIn.Size = new System.Drawing.Size(121, 21);
            this.dtpEndCheckIn.TabIndex = 8;
            // 
            // dtpStartSignBack
            // 
            this.dtpStartSignBack.CustomFormat = "HH:mm:ss";
            this.dtpStartSignBack.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartSignBack.Location = new System.Drawing.Point(117, 206);
            this.dtpStartSignBack.Name = "dtpStartSignBack";
            this.dtpStartSignBack.ShowUpDown = true;
            this.dtpStartSignBack.Size = new System.Drawing.Size(121, 21);
            this.dtpStartSignBack.TabIndex = 8;
            // 
            // dtpStartCheckIn
            // 
            this.dtpStartCheckIn.CustomFormat = "HH:mm:ss";
            this.dtpStartCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpStartCheckIn.Location = new System.Drawing.Point(117, 163);
            this.dtpStartCheckIn.Name = "dtpStartCheckIn";
            this.dtpStartCheckIn.ShowUpDown = true;
            this.dtpStartCheckIn.Size = new System.Drawing.Size(121, 21);
            this.dtpStartCheckIn.TabIndex = 8;
            // 
            // dtpOffDutyTime
            // 
            this.dtpOffDutyTime.CustomFormat = "HH:mm:ss";
            this.dtpOffDutyTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpOffDutyTime.Location = new System.Drawing.Point(358, 79);
            this.dtpOffDutyTime.Name = "dtpOffDutyTime";
            this.dtpOffDutyTime.ShowUpDown = true;
            this.dtpOffDutyTime.Size = new System.Drawing.Size(121, 21);
            this.dtpOffDutyTime.TabIndex = 8;
            // 
            // dtpWorkTime
            // 
            this.dtpWorkTime.CustomFormat = "HH:mm:ss";
            this.dtpWorkTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpWorkTime.Location = new System.Drawing.Point(117, 79);
            this.dtpWorkTime.Name = "dtpWorkTime";
            this.dtpWorkTime.ShowUpDown = true;
            this.dtpWorkTime.Size = new System.Drawing.Size(121, 21);
            this.dtpWorkTime.TabIndex = 8;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(404, 261);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "删除";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(276, 261);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnClassesAdd
            // 
            this.btnClassesAdd.Location = new System.Drawing.Point(150, 261);
            this.btnClassesAdd.Name = "btnClassesAdd";
            this.btnClassesAdd.Size = new System.Drawing.Size(75, 23);
            this.btnClassesAdd.TabIndex = 1;
            this.btnClassesAdd.Text = "添加";
            this.btnClassesAdd.UseVisualStyleBackColor = true;
            this.btnClassesAdd.Click += new System.EventHandler(this.btnClassesAdd_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "清除";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmShiftManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.dgvClassses);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmShiftManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "班次管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmShiftManage_FormClosed);
            this.Load += new System.EventHandler(this.FrmShiftManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvClassses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimesName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLeftEarly;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDayNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox CboClassName;
        private System.Windows.Forms.CheckBox chkMonday;
        private System.Windows.Forms.CheckBox chkTuesday;
        private System.Windows.Forms.CheckBox chkWednesday;
        private System.Windows.Forms.CheckBox chkThursday;
        private System.Windows.Forms.CheckBox chkFriday;
        private System.Windows.Forms.CheckBox chkSaturday;
        private System.Windows.Forms.CheckBox chkSunday;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClassesAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn OffDutyTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartSignBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndSignBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn LateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftEarly;
        private System.Windows.Forms.DataGridViewTextBoxColumn DayNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sunday;
        private System.Windows.Forms.DateTimePicker dtpWorkTime;
        private System.Windows.Forms.DateTimePicker dtpEndSignBack;
        private System.Windows.Forms.DateTimePicker dtpEndCheckIn;
        private System.Windows.Forms.DateTimePicker dtpStartSignBack;
        private System.Windows.Forms.DateTimePicker dtpStartCheckIn;
        private System.Windows.Forms.DateTimePicker dtpOffDutyTime;
        private System.Windows.Forms.Button button1;
    }
}