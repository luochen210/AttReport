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
            this.班次设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.时段设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人事管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工入职ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.职位信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部门信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入员工ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报表查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日报查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.月报查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.年报查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.考勤管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.签卡ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnGetLog = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.prgDownload = new System.Windows.Forms.ProgressBar();
            this.btnTest = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnConnect1 = new System.Windows.Forms.Button();
            this.dgvAttLog = new System.Windows.Forms.DataGridView();
            this.ClockId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MachineId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerifyMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InOutMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClockRecord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.班次管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.班次维护ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自动轮班ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttLog)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem,
            this.人事管理ToolStripMenuItem,
            this.班次管理ToolStripMenuItem1,
            this.考勤管理ToolStripMenuItem,
            this.报表查询ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.班次设置ToolStripMenuItem,
            this.时段设置ToolStripMenuItem});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // 班次设置ToolStripMenuItem
            // 
            this.班次设置ToolStripMenuItem.Name = "班次设置ToolStripMenuItem";
            this.班次设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.班次设置ToolStripMenuItem.Text = "班次设置";
            this.班次设置ToolStripMenuItem.Click += new System.EventHandler(this.班次管理ToolStripMenuItem_Click);
            // 
            // 时段设置ToolStripMenuItem
            // 
            this.时段设置ToolStripMenuItem.Name = "时段设置ToolStripMenuItem";
            this.时段设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.时段设置ToolStripMenuItem.Text = "时段设置";
            this.时段设置ToolStripMenuItem.Click += new System.EventHandler(this.时段管理ToolStripMenuItem_Click);
            // 
            // 人事管理ToolStripMenuItem
            // 
            this.人事管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工入职ToolStripMenuItem,
            this.员工信息ToolStripMenuItem,
            this.职位信息ToolStripMenuItem,
            this.部门信息ToolStripMenuItem,
            this.导入员工ToolStripMenuItem});
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
            // 职位信息ToolStripMenuItem
            // 
            this.职位信息ToolStripMenuItem.Name = "职位信息ToolStripMenuItem";
            this.职位信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.职位信息ToolStripMenuItem.Text = "职位信息";
            this.职位信息ToolStripMenuItem.Click += new System.EventHandler(this.职位信息ToolStripMenuItem_Click);
            // 
            // 部门信息ToolStripMenuItem
            // 
            this.部门信息ToolStripMenuItem.Name = "部门信息ToolStripMenuItem";
            this.部门信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.部门信息ToolStripMenuItem.Text = "部门信息";
            this.部门信息ToolStripMenuItem.Click += new System.EventHandler(this.部门信息ToolStripMenuItem_Click);
            // 
            // 导入员工ToolStripMenuItem
            // 
            this.导入员工ToolStripMenuItem.Name = "导入员工ToolStripMenuItem";
            this.导入员工ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.导入员工ToolStripMenuItem.Text = "导入员工";
            this.导入员工ToolStripMenuItem.Click += new System.EventHandler(this.导入员工ToolStripMenuItem_Click);
            // 
            // 报表查询ToolStripMenuItem
            // 
            this.报表查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.日报查询ToolStripMenuItem,
            this.月报查询ToolStripMenuItem,
            this.年报查询ToolStripMenuItem});
            this.报表查询ToolStripMenuItem.Name = "报表查询ToolStripMenuItem";
            this.报表查询ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.报表查询ToolStripMenuItem.Text = "报表查询";
            // 
            // 日报查询ToolStripMenuItem
            // 
            this.日报查询ToolStripMenuItem.Name = "日报查询ToolStripMenuItem";
            this.日报查询ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.日报查询ToolStripMenuItem.Text = "日报查询";
            this.日报查询ToolStripMenuItem.Click += new System.EventHandler(this.日报查询ToolStripMenuItem_Click);
            // 
            // 月报查询ToolStripMenuItem
            // 
            this.月报查询ToolStripMenuItem.Name = "月报查询ToolStripMenuItem";
            this.月报查询ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.月报查询ToolStripMenuItem.Text = "月报查询";
            this.月报查询ToolStripMenuItem.Click += new System.EventHandler(this.月报查询ToolStripMenuItem_Click);
            // 
            // 年报查询ToolStripMenuItem
            // 
            this.年报查询ToolStripMenuItem.Name = "年报查询ToolStripMenuItem";
            this.年报查询ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.年报查询ToolStripMenuItem.Text = "年报查询";
            // 
            // 考勤管理ToolStripMenuItem
            // 
            this.考勤管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.签卡ToolStripMenuItem});
            this.考勤管理ToolStripMenuItem.Name = "考勤管理ToolStripMenuItem";
            this.考勤管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.考勤管理ToolStripMenuItem.Text = "考勤管理";
            // 
            // 签卡ToolStripMenuItem
            // 
            this.签卡ToolStripMenuItem.Name = "签卡ToolStripMenuItem";
            this.签卡ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.签卡ToolStripMenuItem.Text = "签卡";
            this.签卡ToolStripMenuItem.Click += new System.EventHandler(this.签卡ToolStripMenuItem_Click);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(11, 39);
            this.lblIP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(17, 12);
            this.lblIP.TabIndex = 1;
            this.lblIP.Text = "IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(32, 35);
            this.txtIP.Margin = new System.Windows.Forms.Padding(2);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 21);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "192.168.1.201";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(155, 39);
            this.lblPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 12);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(189, 35);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(44, 21);
            this.txtPort.TabIndex = 1;
            this.txtPort.Text = "4370";
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.Location = new System.Drawing.Point(241, 34);
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
            this.btnGetLog.Location = new System.Drawing.Point(306, 34);
            this.btnGetLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnGetLog.Name = "btnGetLog";
            this.btnGetLog.Size = new System.Drawing.Size(63, 22);
            this.btnGetLog.TabIndex = 3;
            this.btnGetLog.Text = "下载记录";
            this.btnGetLog.UseVisualStyleBackColor = true;
            this.btnGetLog.Click += new System.EventHandler(this.btnGetLog_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblState.Location = new System.Drawing.Point(735, 39);
            this.lblState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(137, 12);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "设备状态：等待连接……";
            // 
            // prgDownload
            // 
            this.prgDownload.Location = new System.Drawing.Point(378, 34);
            this.prgDownload.Name = "prgDownload";
            this.prgDownload.Size = new System.Drawing.Size(350, 23);
            this.prgDownload.TabIndex = 1;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(34, 55);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(61, 23);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "测试功能";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(12, 66);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnTest);
            this.splitContainer1.Panel1.Controls.Add(this.btnConnect1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvAttLog);
            this.splitContainer1.Size = new System.Drawing.Size(984, 650);
            this.splitContainer1.SplitterDistance = 139;
            this.splitContainer1.TabIndex = 10;
            // 
            // btnConnect1
            // 
            this.btnConnect1.Location = new System.Drawing.Point(19, 11);
            this.btnConnect1.Name = "btnConnect1";
            this.btnConnect1.Size = new System.Drawing.Size(100, 23);
            this.btnConnect1.TabIndex = 0;
            this.btnConnect1.Text = "连接设备";
            this.btnConnect1.UseVisualStyleBackColor = true;
            // 
            // dgvAttLog
            // 
            this.dgvAttLog.AllowUserToAddRows = false;
            this.dgvAttLog.AllowUserToDeleteRows = false;
            this.dgvAttLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAttLog.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvAttLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAttLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttLog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClockId,
            this.MachineId,
            this.VerifyMode,
            this.InOutMode,
            this.ClockRecord});
            this.dgvAttLog.Location = new System.Drawing.Point(0, 0);
            this.dgvAttLog.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAttLog.Name = "dgvAttLog";
            this.dgvAttLog.ReadOnly = true;
            this.dgvAttLog.RowHeadersWidth = 50;
            this.dgvAttLog.RowTemplate.Height = 27;
            this.dgvAttLog.Size = new System.Drawing.Size(841, 650);
            this.dgvAttLog.TabIndex = 0;
            this.dgvAttLog.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvAttLog_RowPostPaint);
            // 
            // ClockId
            // 
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ClockRecord.DefaultCellStyle = dataGridViewCellStyle6;
            this.ClockRecord.HeaderText = "打卡时间";
            this.ClockRecord.Name = "ClockRecord";
            this.ClockRecord.ReadOnly = true;
            // 
            // 班次管理ToolStripMenuItem1
            // 
            this.班次管理ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.班次维护ToolStripMenuItem,
            this.自动轮班ToolStripMenuItem});
            this.班次管理ToolStripMenuItem1.Name = "班次管理ToolStripMenuItem1";
            this.班次管理ToolStripMenuItem1.Size = new System.Drawing.Size(68, 21);
            this.班次管理ToolStripMenuItem1.Text = "班次管理";
            // 
            // 班次维护ToolStripMenuItem
            // 
            this.班次维护ToolStripMenuItem.Name = "班次维护ToolStripMenuItem";
            this.班次维护ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.班次维护ToolStripMenuItem.Text = "班次维护";
            this.班次维护ToolStripMenuItem.Click += new System.EventHandler(this.班次维护ToolStripMenuItem_Click);
            // 
            // 自动轮班ToolStripMenuItem
            // 
            this.自动轮班ToolStripMenuItem.Name = "自动轮班ToolStripMenuItem";
            this.自动轮班ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.自动轮班ToolStripMenuItem.Text = "自动轮班";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.prgDownload);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.btnGetLog);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "考勤系统";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnGetLog;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.ToolStripMenuItem 人事管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工入职ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部门信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班次设置ToolStripMenuItem;
        private System.Windows.Forms.ProgressBar prgDownload;
        private System.Windows.Forms.ToolStripMenuItem 时段设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 职位信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报表查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 年报查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 月报查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日报查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 考勤管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 签卡ToolStripMenuItem;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvAttLog;
        private System.Windows.Forms.Button btnConnect1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClockId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MachineId;
        private System.Windows.Forms.DataGridViewTextBoxColumn VerifyMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn InOutMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClockRecord;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 导入员工ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 班次管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 班次维护ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自动轮班ToolStripMenuItem;
    }
}

