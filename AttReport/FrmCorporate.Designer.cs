namespace AttReport
{
    partial class FrmCorporate
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
            this.components = new System.ComponentModel.Container();
            this.trvwCompany = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.员工入职ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.异动记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCompany = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.修改公司ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加公司ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除公司ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.cmsCompany.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvwCompany
            // 
            this.trvwCompany.Location = new System.Drawing.Point(4, 44);
            this.trvwCompany.Name = "trvwCompany";
            this.trvwCompany.Size = new System.Drawing.Size(199, 665);
            this.trvwCompany.TabIndex = 0;
            this.trvwCompany.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvwCompany_NodeMouseClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 704);
            this.splitContainer1.SplitterDistance = 208;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTest);
            this.groupBox1.Controls.Add(this.trvwCompany);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 686);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "组织架构";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(9, 21);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(65, 12);
            this.lblTest.TabIndex = 1;
            this.lblTest.Text = "待输出……";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column9,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column10,
            this.Column7,
            this.Column8});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(796, 704);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "部门";
            this.Column1.Name = "Column1";
            this.Column1.Width = 54;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "子部门";
            this.Column2.Name = "Column2";
            this.Column2.Width = 66;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "职位";
            this.Column9.Name = "Column9";
            this.Column9.Width = 54;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "工号";
            this.Column3.Name = "Column3";
            this.Column3.Width = 54;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "姓名";
            this.Column4.Name = "Column4";
            this.Column4.Width = 54;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "性别";
            this.Column5.Name = "Column5";
            this.Column5.Width = 54;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "年龄";
            this.Column6.Name = "Column6";
            this.Column6.Width = 54;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "学历";
            this.Column10.Name = "Column10";
            this.Column10.Width = 54;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "籍贯";
            this.Column7.Name = "Column7";
            this.Column7.Width = 54;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "工龄";
            this.Column8.Name = "Column8";
            this.Column8.Width = 54;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工入职ToolStripMenuItem,
            this.异动记录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 员工入职ToolStripMenuItem
            // 
            this.员工入职ToolStripMenuItem.Name = "员工入职ToolStripMenuItem";
            this.员工入职ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.员工入职ToolStripMenuItem.Text = "员工入职";
            this.员工入职ToolStripMenuItem.Click += new System.EventHandler(this.员工入职ToolStripMenuItem_Click);
            // 
            // 异动记录ToolStripMenuItem
            // 
            this.异动记录ToolStripMenuItem.Name = "异动记录ToolStripMenuItem";
            this.异动记录ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.异动记录ToolStripMenuItem.Text = "异动记录";
            this.异动记录ToolStripMenuItem.Click += new System.EventHandler(this.异动记录ToolStripMenuItem_Click);
            // 
            // cmsCompany
            // 
            this.cmsCompany.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.修改公司ToolStripMenuItem,
            this.增加公司ToolStripMenuItem,
            this.删除公司ToolStripMenuItem});
            this.cmsCompany.Name = "cmsTreeView1";
            this.cmsCompany.Size = new System.Drawing.Size(125, 70);
            // 
            // 修改公司ToolStripMenuItem
            // 
            this.修改公司ToolStripMenuItem.Name = "修改公司ToolStripMenuItem";
            this.修改公司ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改公司ToolStripMenuItem.Text = "修改公司";
            this.修改公司ToolStripMenuItem.Click += new System.EventHandler(this.修改公司ToolStripMenuItem_Click);
            // 
            // 增加公司ToolStripMenuItem
            // 
            this.增加公司ToolStripMenuItem.Name = "增加公司ToolStripMenuItem";
            this.增加公司ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.增加公司ToolStripMenuItem.Text = "增加公司";
            this.增加公司ToolStripMenuItem.Click += new System.EventHandler(this.增加公司ToolStripMenuItem_Click);
            // 
            // 删除公司ToolStripMenuItem
            // 
            this.删除公司ToolStripMenuItem.Name = "删除公司ToolStripMenuItem";
            this.删除公司ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.删除公司ToolStripMenuItem.Text = "删除公司";
            this.删除公司ToolStripMenuItem.Click += new System.EventHandler(this.删除公司ToolStripMenuItem_Click);
            // 
            // FrmCorporate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmCorporate";
            this.Text = "员工信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCorporate_FormClosed);
            this.Load += new System.EventHandler(this.FrmCorporate_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmsCompany.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView trvwCompany;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 员工入职ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 异动记录ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip cmsCompany;
        private System.Windows.Forms.ToolStripMenuItem 修改公司ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加公司ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除公司ToolStripMenuItem;
        private System.Windows.Forms.Label lblTest;
    }
}