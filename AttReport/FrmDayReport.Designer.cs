namespace AttReport
{
    partial class FrmDayReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.lblDep = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpQEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpQBeginDate = new System.Windows.Forms.DateTimePicker();
            this.dtpCBeginDate = new System.Windows.Forms.DateTimePicker();
            this.lblQEnd = new System.Windows.Forms.Label();
            this.lblCEnd = new System.Windows.Forms.Label();
            this.lblQBegin = new System.Windows.Forms.Label();
            this.lblCBegin = new System.Windows.Forms.Label();
            this.btnExactQuery = new System.Windows.Forms.Button();
            this.btnQueryLog = new System.Windows.Forms.Button();
            this.btnCreateLog = new System.Windows.Forms.Button();
            this.dgvDailyReport = new System.Windows.Forms.DataGridView();
            this.SfId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfShifts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OffDutyTime1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkTime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OffDutyTime2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkTime3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OffDutyTime3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AtSign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.Controls.Add(this.cboName);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.cboDepartment);
            this.panel1.Controls.Add(this.lblDep);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpQEndDate);
            this.panel1.Controls.Add(this.dtpCEndDate);
            this.panel1.Controls.Add(this.dtpQBeginDate);
            this.panel1.Controls.Add(this.dtpCBeginDate);
            this.panel1.Controls.Add(this.lblQEnd);
            this.panel1.Controls.Add(this.lblCEnd);
            this.panel1.Controls.Add(this.lblQBegin);
            this.panel1.Controls.Add(this.lblCBegin);
            this.panel1.Controls.Add(this.btnExactQuery);
            this.panel1.Controls.Add(this.btnQueryLog);
            this.panel1.Controls.Add(this.btnCreateLog);
            this.panel1.Location = new System.Drawing.Point(13, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 63);
            this.panel1.TabIndex = 9;
            // 
            // cboName
            // 
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(552, 35);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(121, 20);
            this.cboName.TabIndex = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(507, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "姓名：";
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(552, 8);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(121, 20);
            this.cboDepartment.TabIndex = 10;
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Location = new System.Drawing.Point(507, 11);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(41, 12);
            this.lblDep.TabIndex = 9;
            this.lblDep.Text = "部门：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(552, 8);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(507, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "部门：";
            // 
            // dtpQEndDate
            // 
            this.dtpQEndDate.CustomFormat = "";
            this.dtpQEndDate.Location = new System.Drawing.Point(292, 35);
            this.dtpQEndDate.Name = "dtpQEndDate";
            this.dtpQEndDate.Size = new System.Drawing.Size(110, 21);
            this.dtpQEndDate.TabIndex = 8;
            // 
            // dtpCEndDate
            // 
            this.dtpCEndDate.CustomFormat = "";
            this.dtpCEndDate.Location = new System.Drawing.Point(39, 35);
            this.dtpCEndDate.Name = "dtpCEndDate";
            this.dtpCEndDate.Size = new System.Drawing.Size(110, 21);
            this.dtpCEndDate.TabIndex = 8;
            // 
            // dtpQBeginDate
            // 
            this.dtpQBeginDate.CustomFormat = "";
            this.dtpQBeginDate.Location = new System.Drawing.Point(292, 8);
            this.dtpQBeginDate.Name = "dtpQBeginDate";
            this.dtpQBeginDate.Size = new System.Drawing.Size(110, 21);
            this.dtpQBeginDate.TabIndex = 8;
            // 
            // dtpCBeginDate
            // 
            this.dtpCBeginDate.CustomFormat = "";
            this.dtpCBeginDate.Location = new System.Drawing.Point(39, 8);
            this.dtpCBeginDate.Name = "dtpCBeginDate";
            this.dtpCBeginDate.Size = new System.Drawing.Size(110, 21);
            this.dtpCBeginDate.TabIndex = 8;
            // 
            // lblQEnd
            // 
            this.lblQEnd.AutoSize = true;
            this.lblQEnd.Location = new System.Drawing.Point(262, 39);
            this.lblQEnd.Name = "lblQEnd";
            this.lblQEnd.Size = new System.Drawing.Size(29, 12);
            this.lblQEnd.TabIndex = 0;
            this.lblQEnd.Text = "到：";
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
            // lblQBegin
            // 
            this.lblQBegin.AutoSize = true;
            this.lblQBegin.Location = new System.Drawing.Point(262, 12);
            this.lblQBegin.Name = "lblQBegin";
            this.lblQBegin.Size = new System.Drawing.Size(29, 12);
            this.lblQBegin.TabIndex = 0;
            this.lblQBegin.Text = "从：";
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
            this.btnExactQuery.Location = new System.Drawing.Point(679, 8);
            this.btnExactQuery.Name = "btnExactQuery";
            this.btnExactQuery.Size = new System.Drawing.Size(75, 48);
            this.btnExactQuery.TabIndex = 5;
            this.btnExactQuery.Text = "精确查询";
            this.btnExactQuery.UseVisualStyleBackColor = false;
            // 
            // btnQueryLog
            // 
            this.btnQueryLog.BackColor = System.Drawing.Color.White;
            this.btnQueryLog.Location = new System.Drawing.Point(408, 8);
            this.btnQueryLog.Name = "btnQueryLog";
            this.btnQueryLog.Size = new System.Drawing.Size(75, 48);
            this.btnQueryLog.TabIndex = 5;
            this.btnQueryLog.Text = "查询日报";
            this.btnQueryLog.UseVisualStyleBackColor = false;
            // 
            // btnCreateLog
            // 
            this.btnCreateLog.BackColor = System.Drawing.Color.White;
            this.btnCreateLog.Location = new System.Drawing.Point(155, 8);
            this.btnCreateLog.Name = "btnCreateLog";
            this.btnCreateLog.Size = new System.Drawing.Size(75, 48);
            this.btnCreateLog.TabIndex = 5;
            this.btnCreateLog.Text = "生成日报";
            this.btnCreateLog.UseVisualStyleBackColor = false;
            this.btnCreateLog.Click += new System.EventHandler(this.btnCreateLog_Click);
            // 
            // dgvDailyReport
            // 
            this.dgvDailyReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDailyReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDailyReport.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDailyReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDailyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDailyReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SfId,
            this.SfName,
            this.SfGroup,
            this.SfShifts,
            this.WorkTime1,
            this.OffDutyTime1,
            this.WorkTime2,
            this.OffDutyTime2,
            this.WorkTime3,
            this.OffDutyTime3,
            this.AtDay,
            this.AtState,
            this.AtSign});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDailyReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDailyReport.Location = new System.Drawing.Point(13, 93);
            this.dgvDailyReport.Name = "dgvDailyReport";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDailyReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDailyReport.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDailyReport.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDailyReport.RowTemplate.Height = 23;
            this.dgvDailyReport.Size = new System.Drawing.Size(799, 506);
            this.dgvDailyReport.TabIndex = 8;
            // 
            // SfId
            // 
            this.SfId.DataPropertyName = "SfId";
            this.SfId.HeaderText = "考勤号";
            this.SfId.Name = "SfId";
            // 
            // SfName
            // 
            this.SfName.DataPropertyName = "SfName";
            this.SfName.HeaderText = "姓名";
            this.SfName.Name = "SfName";
            // 
            // SfGroup
            // 
            this.SfGroup.DataPropertyName = "SfGroup";
            this.SfGroup.HeaderText = "部门";
            this.SfGroup.Name = "SfGroup";
            // 
            // SfShifts
            // 
            this.SfShifts.DataPropertyName = "SfShifts";
            this.SfShifts.HeaderText = "班次";
            this.SfShifts.Name = "SfShifts";
            // 
            // WorkTime1
            // 
            this.WorkTime1.DataPropertyName = "WorkTime1";
            this.WorkTime1.HeaderText = "上班1";
            this.WorkTime1.Name = "WorkTime1";
            // 
            // OffDutyTime1
            // 
            this.OffDutyTime1.DataPropertyName = "OffDutyTime1";
            this.OffDutyTime1.HeaderText = "下班1";
            this.OffDutyTime1.Name = "OffDutyTime1";
            // 
            // WorkTime2
            // 
            this.WorkTime2.DataPropertyName = "WorkTime2";
            this.WorkTime2.HeaderText = "上班2";
            this.WorkTime2.Name = "WorkTime2";
            // 
            // OffDutyTime2
            // 
            this.OffDutyTime2.DataPropertyName = "OffDutyTime2";
            this.OffDutyTime2.HeaderText = "下班2";
            this.OffDutyTime2.Name = "OffDutyTime2";
            // 
            // WorkTime3
            // 
            this.WorkTime3.DataPropertyName = "WorkTime3";
            this.WorkTime3.HeaderText = "上班3";
            this.WorkTime3.Name = "WorkTime3";
            // 
            // OffDutyTime3
            // 
            this.OffDutyTime3.DataPropertyName = "OffDutyTime3";
            this.OffDutyTime3.HeaderText = "下班3";
            this.OffDutyTime3.Name = "OffDutyTime3";
            // 
            // AtDay
            // 
            this.AtDay.DataPropertyName = "AtDay";
            this.AtDay.HeaderText = "天数";
            this.AtDay.Name = "AtDay";
            // 
            // AtState
            // 
            this.AtState.DataPropertyName = "AtState";
            this.AtState.HeaderText = "考勤状态";
            this.AtState.Name = "AtState";
            // 
            // AtSign
            // 
            this.AtSign.DataPropertyName = "AtSign";
            this.AtSign.HeaderText = "处理标记";
            this.AtSign.Name = "AtSign";
            // 
            // FrmDayReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDailyReport);
            this.Name = "FrmDayReport";
            this.Text = "考勤日报";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDailyReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpCBeginDate;
        private System.Windows.Forms.Label lblCBegin;
        private System.Windows.Forms.Button btnCreateLog;
        private System.Windows.Forms.DataGridView dgvDailyReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfShifts;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkTime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OffDutyTime1;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkTime2;
        private System.Windows.Forms.DataGridViewTextBoxColumn OffDutyTime2;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkTime3;
        private System.Windows.Forms.DataGridViewTextBoxColumn OffDutyTime3;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtState;
        private System.Windows.Forms.DataGridViewTextBoxColumn AtSign;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpQEndDate;
        private System.Windows.Forms.DateTimePicker dtpCEndDate;
        private System.Windows.Forms.DateTimePicker dtpQBeginDate;
        private System.Windows.Forms.Label lblQEnd;
        private System.Windows.Forms.Label lblCEnd;
        private System.Windows.Forms.Label lblQBegin;
        private System.Windows.Forms.Button btnExactQuery;
        private System.Windows.Forms.Button btnQueryLog;
    }
}