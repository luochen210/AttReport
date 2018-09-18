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
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("总经办");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("管理部");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("财务部");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("采购部");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("客服部");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("销售部");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("模房车间");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("工程部", new System.Windows.Forms.TreeNode[] {
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("仓库");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("物控部", new System.Windows.Forms.TreeNode[] {
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("测量组");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("全检组");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("品保部", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29});
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("组装车间");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("冲压车间");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("生产部", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("东莞市东讯五金电气有限公司", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode25,
            treeNode27,
            treeNode30,
            treeNode33});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.员工入职ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.异动记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加公司ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加部门ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加组别ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(4, 44);
            this.treeView1.Name = "treeView1";
            treeNode18.ContextMenuStrip = this.contextMenuStrip1;
            treeNode18.Name = "总经办";
            treeNode18.Text = "总经办";
            treeNode19.ContextMenuStrip = this.contextMenuStrip1;
            treeNode19.Name = "管理部";
            treeNode19.Text = "管理部";
            treeNode20.ContextMenuStrip = this.contextMenuStrip1;
            treeNode20.Name = "财务部";
            treeNode20.Text = "财务部";
            treeNode21.ContextMenuStrip = this.contextMenuStrip1;
            treeNode21.Name = "采购部";
            treeNode21.Text = "采购部";
            treeNode22.ContextMenuStrip = this.contextMenuStrip1;
            treeNode22.Name = "客服部";
            treeNode22.Text = "客服部";
            treeNode23.ContextMenuStrip = this.contextMenuStrip1;
            treeNode23.Name = "销售部";
            treeNode23.Text = "销售部";
            treeNode24.Name = "模房车间";
            treeNode24.Text = "模房车间";
            treeNode25.ContextMenuStrip = this.contextMenuStrip1;
            treeNode25.Name = "工程部";
            treeNode25.Text = "工程部";
            treeNode26.Name = "仓库";
            treeNode26.Text = "仓库";
            treeNode27.ContextMenuStrip = this.contextMenuStrip1;
            treeNode27.Name = "物控部";
            treeNode27.Text = "物控部";
            treeNode28.Name = "测量组";
            treeNode28.Text = "测量组";
            treeNode29.Name = "全检组";
            treeNode29.Text = "全检组";
            treeNode30.ContextMenuStrip = this.contextMenuStrip1;
            treeNode30.Name = "品保部";
            treeNode30.Text = "品保部";
            treeNode31.Name = "组装车间";
            treeNode31.Text = "组装车间";
            treeNode32.Name = "冲压车间";
            treeNode32.Text = "冲压车间";
            treeNode33.ContextMenuStrip = this.contextMenuStrip1;
            treeNode33.Name = "生产部";
            treeNode33.Text = "生产部";
            treeNode34.ContextMenuStrip = this.contextMenuStrip1;
            treeNode34.Name = "东莞市东讯五金电气有限公司";
            treeNode34.Text = "东莞市东讯五金电气有限公司";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode34});
            this.treeView1.Size = new System.Drawing.Size(199, 665);
            this.treeView1.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(5, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 22);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.Location = new System.Drawing.Point(75, 16);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 22);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
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
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(144, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "保存";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.treeView1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 686);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "组织架构";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加公司ToolStripMenuItem,
            this.添加部门ToolStripMenuItem,
            this.添加组别ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 70);
            // 
            // 添加公司ToolStripMenuItem
            // 
            this.添加公司ToolStripMenuItem.Name = "添加公司ToolStripMenuItem";
            this.添加公司ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加公司ToolStripMenuItem.Text = "添加公司";
            // 
            // 添加部门ToolStripMenuItem
            // 
            this.添加部门ToolStripMenuItem.Name = "添加部门ToolStripMenuItem";
            this.添加部门ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加部门ToolStripMenuItem.Text = "添加部门";
            // 
            // 添加组别ToolStripMenuItem
            // 
            this.添加组别ToolStripMenuItem.Name = "添加组别ToolStripMenuItem";
            this.添加组别ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.添加组别ToolStripMenuItem.Text = "添加组别";
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
            this.Load += new System.EventHandler(this.FrmCorporate_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 添加公司ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加部门ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加组别ToolStripMenuItem;
    }
}