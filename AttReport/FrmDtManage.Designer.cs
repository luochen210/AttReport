namespace AttReport
{
    partial class FrmDtManage
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
            this.btnRemove = new System.Windows.Forms.Button();
            this.trvwDepartment = new System.Windows.Forms.TreeView();
            this.lblCompanyTips = new System.Windows.Forms.Label();
            this.lblDepartmentTips = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAgoNode = new System.Windows.Forms.TextBox();
            this.txtNewNode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblInputTips = new System.Windows.Forms.Label();
            this.btnAddDtGroup = new System.Windows.Forms.Button();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtParentNode = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.Location = new System.Drawing.Point(99, 110);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "删除组织";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // trvwDepartment
            // 
            this.trvwDepartment.Location = new System.Drawing.Point(12, 27);
            this.trvwDepartment.Name = "trvwDepartment";
            this.trvwDepartment.Size = new System.Drawing.Size(222, 565);
            this.trvwDepartment.TabIndex = 4;
            this.trvwDepartment.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvwDepartment_NodeMouseClick);
            // 
            // lblCompanyTips
            // 
            this.lblCompanyTips.AutoSize = true;
            this.lblCompanyTips.ForeColor = System.Drawing.Color.Red;
            this.lblCompanyTips.Location = new System.Drawing.Point(314, 33);
            this.lblCompanyTips.Name = "lblCompanyTips";
            this.lblCompanyTips.Size = new System.Drawing.Size(0, 12);
            this.lblCompanyTips.TabIndex = 5;
            // 
            // lblDepartmentTips
            // 
            this.lblDepartmentTips.AutoSize = true;
            this.lblDepartmentTips.ForeColor = System.Drawing.Color.Red;
            this.lblDepartmentTips.Location = new System.Drawing.Point(314, 104);
            this.lblDepartmentTips.Name = "lblDepartmentTips";
            this.lblDepartmentTips.Size = new System.Drawing.Size(0, 12);
            this.lblDepartmentTips.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(10, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "组织信息：";
            // 
            // txtAgoNode
            // 
            this.txtAgoNode.Location = new System.Drawing.Point(15, 26);
            this.txtAgoNode.Name = "txtAgoNode";
            this.txtAgoNode.Size = new System.Drawing.Size(245, 21);
            this.txtAgoNode.TabIndex = 0;
            // 
            // txtNewNode
            // 
            this.txtNewNode.Location = new System.Drawing.Point(15, 63);
            this.txtNewNode.Name = "txtNewNode";
            this.txtNewNode.Size = new System.Drawing.Size(245, 21);
            this.txtNewNode.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtAgoNode);
            this.groupBox2.Controls.Add(this.btnAlter);
            this.groupBox2.Controls.Add(this.lblDepartmentTips);
            this.groupBox2.Controls.Add(this.lblCompanyTips);
            this.groupBox2.Location = new System.Drawing.Point(250, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 129);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "修改组织";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "提示：请先选择左边的节点！";
            // 
            // btnAlter
            // 
            this.btnAlter.AutoSize = true;
            this.btnAlter.Location = new System.Drawing.Point(99, 84);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(75, 23);
            this.btnAlter.TabIndex = 3;
            this.btnAlter.Text = "修改组织";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtParentNode);
            this.groupBox1.Controls.Add(this.lblInputTips);
            this.groupBox1.Controls.Add(this.btnAddDtGroup);
            this.groupBox1.Controls.Add(this.btnAddDepartment);
            this.groupBox1.Controls.Add(this.btnAddCompany);
            this.groupBox1.Controls.Add(this.txtNewNode);
            this.groupBox1.Location = new System.Drawing.Point(250, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 169);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加组织";
            // 
            // lblInputTips
            // 
            this.lblInputTips.AutoSize = true;
            this.lblInputTips.Location = new System.Drawing.Point(13, 97);
            this.lblInputTips.Name = "lblInputTips";
            this.lblInputTips.Size = new System.Drawing.Size(161, 12);
            this.lblInputTips.TabIndex = 6;
            this.lblInputTips.Text = "提示：请输入要添加的信息！";
            // 
            // btnAddDtGroup
            // 
            this.btnAddDtGroup.Location = new System.Drawing.Point(185, 121);
            this.btnAddDtGroup.Name = "btnAddDtGroup";
            this.btnAddDtGroup.Size = new System.Drawing.Size(75, 23);
            this.btnAddDtGroup.TabIndex = 2;
            this.btnAddDtGroup.Text = "添加组别";
            this.btnAddDtGroup.UseVisualStyleBackColor = true;
            this.btnAddDtGroup.Click += new System.EventHandler(this.btnAddDtGroup_Click);
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(99, 121);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(75, 23);
            this.btnAddDepartment.TabIndex = 2;
            this.btnAddDepartment.Text = "添加部门";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Location = new System.Drawing.Point(15, 121);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(75, 23);
            this.btnAddCompany.TabIndex = 2;
            this.btnAddCompany.Text = "添加公司";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnRemove);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(250, 371);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 157);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "删除组织";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 28);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 16);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "我要删除组织信息";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "提示：请先选择左边的节点！";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 21);
            this.textBox1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(314, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(314, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 5;
            // 
            // txtParentNode
            // 
            this.txtParentNode.Location = new System.Drawing.Point(15, 29);
            this.txtParentNode.Name = "txtParentNode";
            this.txtParentNode.ReadOnly = true;
            this.txtParentNode.Size = new System.Drawing.Size(245, 21);
            this.txtParentNode.TabIndex = 7;
            // 
            // FrmDtManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 604);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trvwDepartment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDtManage";
            this.Text = "部门管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAddNode_FormClosed);
            this.Load += new System.EventHandler(this.FrmAddNode_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TreeView trvwDepartment;
        private System.Windows.Forms.Label lblCompanyTips;
        private System.Windows.Forms.Label lblDepartmentTips;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAgoNode;
        private System.Windows.Forms.TextBox txtNewNode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Label lblInputTips;
        private System.Windows.Forms.Button btnAddDtGroup;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtParentNode;
    }
}