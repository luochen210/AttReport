namespace AttReport
{
    partial class FrmMonthReport
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
            this.btnQuery = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblQueryTips = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvRecord = new System.Windows.Forms.DataGridView();
            this.SfDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfJob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfShouldAtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfLegalHoliday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfActualAtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfLeave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfRest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfFuneral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfAnnual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfAbsenteeism = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfAccidents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfFullAtt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfSeniorityAward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfSubsidy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfSleepover = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfOutpatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfRetirementInsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfHousingFund = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfOvertime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfOvertime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfOvertime3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfReward = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfUtilities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfOther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfEntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfSalaryMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfAutograph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfLnsurance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMonthly = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(145, 19);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 0;
            this.btnQuery.Text = "查询生成";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(859, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "导出为Excel表格";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(238, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(176, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // lblQueryTips
            // 
            this.lblQueryTips.AutoSize = true;
            this.lblQueryTips.Location = new System.Drawing.Point(420, 24);
            this.lblQueryTips.Name = "lblQueryTips";
            this.lblQueryTips.Size = new System.Drawing.Size(77, 12);
            this.lblQueryTips.TabIndex = 2;
            this.lblQueryTips.Text = "等待查询……";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvRecord);
            this.groupBox1.Location = new System.Drawing.Point(13, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(983, 637);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "考勤月报";
            // 
            // dgvRecord
            // 
            this.dgvRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecord.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SfDepartment,
            this.SfId,
            this.StaffName,
            this.SfJob,
            this.SfShouldAtt,
            this.SfLegalHoliday,
            this.SfActualAtt,
            this.SfLeave,
            this.SfRest,
            this.SfFuneral,
            this.SfAnnual,
            this.SfAbsenteeism,
            this.SfAccidents,
            this.SfFullAtt,
            this.SfSeniorityAward,
            this.SfSubsidy,
            this.SfSleepover,
            this.SfOutpatient,
            this.SfRetirementInsurance,
            this.SfHousingFund,
            this.SfOvertime1,
            this.SfOvertime2,
            this.SfOvertime3,
            this.SfReward,
            this.SfUtilities,
            this.SfOther,
            this.SfEntryDate,
            this.SfSalaryMethod,
            this.SfRemarks,
            this.SfAutograph,
            this.SfLnsurance});
            this.dgvRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecord.Location = new System.Drawing.Point(3, 17);
            this.dgvRecord.Name = "dgvRecord";
            this.dgvRecord.RowTemplate.Height = 23;
            this.dgvRecord.Size = new System.Drawing.Size(977, 617);
            this.dgvRecord.TabIndex = 0;
            // 
            // SfDepartment
            // 
            this.SfDepartment.DataPropertyName = "SfDepartment";
            this.SfDepartment.HeaderText = "部门";
            this.SfDepartment.Name = "SfDepartment";
            // 
            // SfId
            // 
            this.SfId.DataPropertyName = "SfId";
            this.SfId.HeaderText = "工号";
            this.SfId.Name = "SfId";
            // 
            // StaffName
            // 
            this.StaffName.DataPropertyName = "StaffName";
            this.StaffName.HeaderText = "姓名";
            this.StaffName.Name = "StaffName";
            // 
            // SfJob
            // 
            this.SfJob.DataPropertyName = "SfJob";
            this.SfJob.HeaderText = "职位";
            this.SfJob.Name = "SfJob";
            // 
            // SfShouldAtt
            // 
            this.SfShouldAtt.DataPropertyName = "SfShouldAtt";
            this.SfShouldAtt.HeaderText = "应出勤";
            this.SfShouldAtt.Name = "SfShouldAtt";
            // 
            // SfLegalHoliday
            // 
            this.SfLegalHoliday.DataPropertyName = "SfLegalHoliday";
            this.SfLegalHoliday.HeaderText = "法定假";
            this.SfLegalHoliday.Name = "SfLegalHoliday";
            // 
            // SfActualAtt
            // 
            this.SfActualAtt.DataPropertyName = "SfActualAtt";
            this.SfActualAtt.HeaderText = "实出勤";
            this.SfActualAtt.Name = "SfActualAtt";
            // 
            // SfLeave
            // 
            this.SfLeave.DataPropertyName = "SfLeave";
            this.SfLeave.HeaderText = "事假";
            this.SfLeave.Name = "SfLeave";
            // 
            // SfRest
            // 
            this.SfRest.DataPropertyName = "SfRest";
            this.SfRest.HeaderText = "调休";
            this.SfRest.Name = "SfRest";
            // 
            // SfFuneral
            // 
            this.SfFuneral.DataPropertyName = "SfFuneral";
            this.SfFuneral.HeaderText = "丧假";
            this.SfFuneral.Name = "SfFuneral";
            // 
            // SfAnnual
            // 
            this.SfAnnual.DataPropertyName = "SfAnnual";
            this.SfAnnual.HeaderText = "年假";
            this.SfAnnual.Name = "SfAnnual";
            // 
            // SfAbsenteeism
            // 
            this.SfAbsenteeism.DataPropertyName = "SfAbsenteeism";
            this.SfAbsenteeism.HeaderText = "旷工";
            this.SfAbsenteeism.Name = "SfAbsenteeism";
            // 
            // SfAccidents
            // 
            this.SfAccidents.DataPropertyName = "SfAccidents";
            this.SfAccidents.HeaderText = "工伤";
            this.SfAccidents.Name = "SfAccidents";
            // 
            // SfFullAtt
            // 
            this.SfFullAtt.DataPropertyName = "SfFullAtt";
            this.SfFullAtt.HeaderText = "全勤";
            this.SfFullAtt.Name = "SfFullAtt";
            // 
            // SfSeniorityAward
            // 
            this.SfSeniorityAward.DataPropertyName = "SfSeniorityAward";
            this.SfSeniorityAward.HeaderText = "年资";
            this.SfSeniorityAward.Name = "SfSeniorityAward";
            // 
            // SfSubsidy
            // 
            this.SfSubsidy.DataPropertyName = "SfSubsidy";
            this.SfSubsidy.HeaderText = "补贴";
            this.SfSubsidy.Name = "SfSubsidy";
            // 
            // SfSleepover
            // 
            this.SfSleepover.DataPropertyName = "SfSleepover";
            this.SfSleepover.HeaderText = "外宿";
            this.SfSleepover.Name = "SfSleepover";
            // 
            // SfOutpatient
            // 
            this.SfOutpatient.DataPropertyName = "SfOutpatient";
            this.SfOutpatient.HeaderText = "门诊医疗";
            this.SfOutpatient.Name = "SfOutpatient";
            // 
            // SfRetirementInsurance
            // 
            this.SfRetirementInsurance.DataPropertyName = "SfRetirementInsurance";
            this.SfRetirementInsurance.HeaderText = "养老保险";
            this.SfRetirementInsurance.Name = "SfRetirementInsurance";
            // 
            // SfHousingFund
            // 
            this.SfHousingFund.DataPropertyName = "SfHousingFund";
            this.SfHousingFund.HeaderText = "住房公积金";
            this.SfHousingFund.Name = "SfHousingFund";
            // 
            // SfOvertime1
            // 
            this.SfOvertime1.DataPropertyName = "SfOvertime1";
            this.SfOvertime1.HeaderText = "1倍";
            this.SfOvertime1.Name = "SfOvertime1";
            // 
            // SfOvertime2
            // 
            this.SfOvertime2.DataPropertyName = "SfOvertime2";
            this.SfOvertime2.HeaderText = "2倍";
            this.SfOvertime2.Name = "SfOvertime2";
            // 
            // SfOvertime3
            // 
            this.SfOvertime3.DataPropertyName = "SfOvertime3";
            this.SfOvertime3.HeaderText = "3倍";
            this.SfOvertime3.Name = "SfOvertime3";
            // 
            // SfReward
            // 
            this.SfReward.DataPropertyName = "SfReward";
            this.SfReward.HeaderText = "奖励";
            this.SfReward.Name = "SfReward";
            // 
            // SfUtilities
            // 
            this.SfUtilities.DataPropertyName = "SfUtilities";
            this.SfUtilities.HeaderText = "水电扣款";
            this.SfUtilities.Name = "SfUtilities";
            // 
            // SfOther
            // 
            this.SfOther.DataPropertyName = "SfOther";
            this.SfOther.HeaderText = "其它扣款";
            this.SfOther.Name = "SfOther";
            // 
            // SfEntryDate
            // 
            this.SfEntryDate.DataPropertyName = "SfEntryDate";
            this.SfEntryDate.HeaderText = "入职日期";
            this.SfEntryDate.Name = "SfEntryDate";
            // 
            // SfSalaryMethod
            // 
            this.SfSalaryMethod.DataPropertyName = "SfSalaryMethod";
            this.SfSalaryMethod.HeaderText = "计薪方式";
            this.SfSalaryMethod.Name = "SfSalaryMethod";
            // 
            // SfRemarks
            // 
            this.SfRemarks.DataPropertyName = "SfRemarks";
            this.SfRemarks.HeaderText = "备注";
            this.SfRemarks.Name = "SfRemarks";
            // 
            // SfAutograph
            // 
            this.SfAutograph.DataPropertyName = "SfAutograph";
            this.SfAutograph.HeaderText = "本人签名";
            this.SfAutograph.Name = "SfAutograph";
            // 
            // SfLnsurance
            // 
            this.SfLnsurance.DataPropertyName = "SfLnsurance";
            this.SfLnsurance.HeaderText = "险种";
            this.SfLnsurance.Name = "SfLnsurance";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(578, 13);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "功能暂停";
            // 
            // comboBox2
            // 
            this.comboBox2.Enabled = false;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(578, 50);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 20);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "功能暂停";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(530, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "部门：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(530, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "员工：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "月度：";
            // 
            // cboMonthly
            // 
            this.cboMonthly.FormattingEnabled = true;
            this.cboMonthly.Items.AddRange(new object[] {
            "",
            "1月",
            "2月",
            "3月",
            "4月",
            "5月",
            "6月",
            "7月",
            "8月",
            "9月",
            "10月",
            "11月",
            "12月"});
            this.cboMonthly.Location = new System.Drawing.Point(56, 22);
            this.cboMonthly.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMonthly.Name = "cboMonthly";
            this.cboMonthly.Size = new System.Drawing.Size(62, 20);
            this.cboMonthly.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.cboMonthly);
            this.groupBox2.Controls.Add(this.btnQuery);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblQueryTips);
            this.groupBox2.Location = new System.Drawing.Point(13, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(508, 56);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "批量查询";
            // 
            // FrmMonthReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "FrmMonthReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "月报查询";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMonthlyReport_FormClosed);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecord)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblQueryTips;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvRecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfJob;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfShouldAtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfLegalHoliday;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfActualAtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfLeave;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfRest;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfFuneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfAnnual;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfAbsenteeism;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfAccidents;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfFullAtt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfSeniorityAward;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfSubsidy;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfSleepover;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfOutpatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfRetirementInsurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfHousingFund;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfOvertime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfOvertime2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfOvertime3;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfReward;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfUtilities;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfOther;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfEntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfSalaryMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfRemarks;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfAutograph;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfLnsurance;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboMonthly;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}