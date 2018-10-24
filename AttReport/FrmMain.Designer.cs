namespace AttReport
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人事管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工入职ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnGetLog = new System.Windows.Forms.Button();
            this.tctlReport = new System.Windows.Forms.TabControl();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.dgvAttLog = new System.Windows.Forms.DataGridView();
            this.ClockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerifyMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InOutMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClockRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabDaily = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabMonthly = new System.Windows.Forms.TabPage();
            this.tabAnnual = new System.Windows.Forms.TabPage();
            this.lblState = new System.Windows.Forms.Label();
            this.部门信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tctlReport.SuspendLayout();
            this.tabLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttLog)).BeginInit();
            this.tabDaily.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem,
            this.人事管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(754, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 人事管理ToolStripMenuItem
            // 
            this.人事管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工入职ToolStripMenuItem,
            this.员工信息ToolStripMenuItem,
            this.部门信息ToolStripMenuItem});
            this.人事管理ToolStripMenuItem.Name = "人事管理ToolStripMenuItem";
            this.人事管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.人事管理ToolStripMenuItem.Text = "人事管理";
            // 
            // 员工入职ToolStripMenuItem
            // 
            this.员工入职ToolStripMenuItem.Name = "员工入职ToolStripMenuItem";
            this.员工入职ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.员工入职ToolStripMenuItem.Text = "员工入职";
            this.员工入职ToolStripMenuItem.Click += new System.EventHandler(this.员工入职ToolStripMenuItem_Click);
            // 
            // 员工信息ToolStripMenuItem
            // 
            this.员工信息ToolStripMenuItem.Name = "员工信息ToolStripMenuItem";
            this.员工信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.员工信息ToolStripMenuItem.Text = "员工信息";
            this.员工信息ToolStripMenuItem.Click += new System.EventHandler(this.员工信息ToolStripMenuItem_Click);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(11, 38);
            this.lblIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(17, 12);
            this.lblIP.TabIndex = 1;
            this.lblIP.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(33, 34);
            this.txtIP.Margin = new System.Windows.Forms.Padding(2);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(96, 21);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "192.168.1.201";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(150, 38);
            this.lblPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 12);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(184, 34);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(44, 21);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "4370";
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.Location = new System.Drawing.Point(250, 32);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(56, 22);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnGetLog
            // 
            this.btnGetLog.AutoSize = true;
            this.btnGetLog.Location = new System.Drawing.Point(331, 32);
            this.btnGetLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetLog.Name = "btnGetLog";
            this.btnGetLog.Size = new System.Drawing.Size(63, 22);
            this.btnGetLog.TabIndex = 3;
            this.btnGetLog.Text = "下载记录";
            this.btnGetLog.UseVisualStyleBackColor = true;
            this.btnGetLog.Click += new System.EventHandler(this.btnGetLog_Click);
            // 
            // tctlReport
            // 
            this.tctlReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tctlReport.Controls.Add(this.tabLog);
            this.tctlReport.Controls.Add(this.tabDaily);
            this.tctlReport.Controls.Add(this.tabMonthly);
            this.tctlReport.Controls.Add(this.tabAnnual);
            this.tctlReport.Location = new System.Drawing.Point(8, 71);
            this.tctlReport.Margin = new System.Windows.Forms.Padding(2);
            this.tctlReport.Name = "tctlReport";
            this.tctlReport.SelectedIndex = 0;
            this.tctlReport.Size = new System.Drawing.Size(740, 497);
            this.tctlReport.TabIndex = 6;
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.dgvAttLog);
            this.tabLog.Location = new System.Drawing.Point(4, 22);
            this.tabLog.Margin = new System.Windows.Forms.Padding(2);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(2);
            this.tabLog.Size = new System.Drawing.Size(732, 471);
            this.tabLog.TabIndex = 0;
            this.tabLog.Text = "打卡记录";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // dgvAttLog
            // 
            this.dgvAttLog.AllowUserToAddRows = false;
            this.dgvAttLog.AllowUserToDeleteRows = false;
            this.dgvAttLog.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAttLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClockId,
            this.MachineId,
            this.VerifyMode,
            this.InOutMode,
            this.ClockRecord});
            this.dgvAttLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAttLog.Location = new System.Drawing.Point(2, 2);
            this.dgvAttLog.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAttLog.Name = "dgvAttLog";
            this.dgvAttLog.ReadOnly = true;
            this.dgvAttLog.RowHeadersWidth = 70;
            this.dgvAttLog.RowTemplate.Height = 27;
            this.dgvAttLog.Size = new System.Drawing.Size(728, 467);
            this.dgvAttLog.TabIndex = 0;
            this.dgvAttLog.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvStudentList_RowPostPaint);
            // 
            // ClockId
            // 
            this.ClockId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ClockId.DataPropertyName = "ClockId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClockId.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClockId.HeaderText = "考勤号码";
            this.ClockId.Name = "ClockId";
            this.ClockId.ReadOnly = true;
            this.ClockId.Width = 78;
            // 
            // MachineId
            // 
            this.MachineId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.MachineId.DataPropertyName = "MachineId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MachineId.DefaultCellStyle = dataGridViewCellStyle3;
            this.MachineId.HeaderText = "机器号";
            this.MachineId.Name = "MachineId";
            this.MachineId.ReadOnly = true;
            this.MachineId.Width = 66;
            // 
            // VerifyMode
            // 
            this.VerifyMode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.VerifyMode.DataPropertyName = "VerifyMode";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.VerifyMode.DefaultCellStyle = dataGridViewCellStyle4;
            this.VerifyMode.HeaderText = "验证方式";
            this.VerifyMode.Name = "VerifyMode";
            this.VerifyMode.ReadOnly = true;
            this.VerifyMode.Width = 78;
            // 
            // InOutMode
            // 
            this.InOutMode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.InOutMode.DataPropertyName = "InOutMode";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.InOutMode.DefaultCellStyle = dataGridViewCellStyle5;
            this.InOutMode.HeaderText = "考勤状态";
            this.InOutMode.Name = "InOutMode";
            this.InOutMode.ReadOnly = true;
            this.InOutMode.Width = 78;
            // 
            // ClockRecord
            // 
            this.ClockRecord.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ClockRecord.DataPropertyName = "ClockRecord";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClockRecord.DefaultCellStyle = dataGridViewCellStyle6;
            this.ClockRecord.HeaderText = "打卡时间";
            this.ClockRecord.Name = "ClockRecord";
            this.ClockRecord.ReadOnly = true;
            // 
            // tabDaily
            // 
            this.tabDaily.Controls.Add(this.dataGridView1);
            this.tabDaily.Location = new System.Drawing.Point(4, 22);
            this.tabDaily.Margin = new System.Windows.Forms.Padding(2);
            this.tabDaily.Name = "tabDaily";
            this.tabDaily.Padding = new System.Windows.Forms.Padding(2);
            this.tabDaily.Size = new System.Drawing.Size(732, 471);
            this.tabDaily.TabIndex = 1;
            this.tabDaily.Text = "日报表";
            this.tabDaily.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(728, 467);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabMonthly
            // 
            this.tabMonthly.Location = new System.Drawing.Point(4, 22);
            this.tabMonthly.Name = "tabMonthly";
            this.tabMonthly.Padding = new System.Windows.Forms.Padding(3);
            this.tabMonthly.Size = new System.Drawing.Size(732, 471);
            this.tabMonthly.TabIndex = 2;
            this.tabMonthly.Text = "月报表";
            this.tabMonthly.UseVisualStyleBackColor = true;
            // 
            // tabAnnual
            // 
            this.tabAnnual.Location = new System.Drawing.Point(4, 22);
            this.tabAnnual.Name = "tabAnnual";
            this.tabAnnual.Padding = new System.Windows.Forms.Padding(3);
            this.tabAnnual.Size = new System.Drawing.Size(732, 471);
            this.tabAnnual.TabIndex = 3;
            this.tabAnnual.Text = "年报表";
            this.tabAnnual.UseVisualStyleBackColor = true;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblState.Location = new System.Drawing.Point(412, 38);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(137, 12);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "设备状态：等待连接……";
            // 
            // 部门信息ToolStripMenuItem
            // 
            this.部门信息ToolStripMenuItem.Name = "部门信息ToolStripMenuItem";
            this.部门信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.部门信息ToolStripMenuItem.Text = "部门信息";
            this.部门信息ToolStripMenuItem.Click += new System.EventHandler(this.部门信息ToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(754, 577);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.tctlReport);
            this.Controls.Add(this.btnGetLog);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考勤系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tctlReport.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttLog)).EndInit();
            this.tabDaily.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnGetLog;
        private System.Windows.Forms.TabControl tctlReport;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.TabPage tabDaily;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.DataGridView dgvAttLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VerifyMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn InOutMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClockRecord;
        private System.Windows.Forms.TabPage tabMonthly;
        private System.Windows.Forms.TabPage tabAnnual;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem 人事管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工入职ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部门信息ToolStripMenuItem;
    }
}

