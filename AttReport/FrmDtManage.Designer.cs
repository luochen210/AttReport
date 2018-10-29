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
            this.trvwDepartment = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNewNode = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtParentNode = new System.Windows.Forms.TextBox();
            this.lblInputTips = new System.Windows.Forms.Label();
            this.btnAddDtGroup = new System.Windows.Forms.Button();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvwDepartment
            // 
            this.trvwDepartment.Location = new System.Drawing.Point(16, 34);
            this.trvwDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trvwDepartment.Name = "trvwDepartment";
            this.trvwDepartment.Size = new System.Drawing.Size(295, 705);
            this.trvwDepartment.TabIndex = 4;
            this.trvwDepartment.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvwDepartment_NodeMouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(13, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "组织信息：";
            // 
            // txtNewNode
            // 
            this.txtNewNode.Location = new System.Drawing.Point(20, 79);
            this.txtNewNode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNewNode.Name = "txtNewNode";
            this.txtNewNode.Size = new System.Drawing.Size(325, 25);
            this.txtNewNode.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtParentNode);
            this.groupBox1.Controls.Add(this.lblInputTips);
            this.groupBox1.Controls.Add(this.btnAddDtGroup);
            this.groupBox1.Controls.Add(this.btnAddDepartment);
            this.groupBox1.Controls.Add(this.btnAddCompany);
            this.groupBox1.Controls.Add(this.txtNewNode);
            this.groupBox1.Location = new System.Drawing.Point(333, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(367, 211);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加组织";
            // 
            // txtParentNode
            // 
            this.txtParentNode.Location = new System.Drawing.Point(20, 36);
            this.txtParentNode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtParentNode.Name = "txtParentNode";
            this.txtParentNode.ReadOnly = true;
            this.txtParentNode.Size = new System.Drawing.Size(325, 25);
            this.txtParentNode.TabIndex = 7;
            // 
            // lblInputTips
            // 
            this.lblInputTips.AutoSize = true;
            this.lblInputTips.Location = new System.Drawing.Point(17, 121);
            this.lblInputTips.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInputTips.Name = "lblInputTips";
            this.lblInputTips.Size = new System.Drawing.Size(202, 15);
            this.lblInputTips.TabIndex = 6;
            this.lblInputTips.Text = "提示：请输入要添加的信息！";
            // 
            // btnAddDtGroup
            // 
            this.btnAddDtGroup.Location = new System.Drawing.Point(247, 151);
            this.btnAddDtGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddDtGroup.Name = "btnAddDtGroup";
            this.btnAddDtGroup.Size = new System.Drawing.Size(100, 29);
            this.btnAddDtGroup.TabIndex = 2;
            this.btnAddDtGroup.Text = "添加组别";
            this.btnAddDtGroup.UseVisualStyleBackColor = true;
            this.btnAddDtGroup.Click += new System.EventHandler(this.btnAddDtGroup_Click);
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(132, 151);
            this.btnAddDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(100, 29);
            this.btnAddDepartment.TabIndex = 2;
            this.btnAddDepartment.Text = "添加部门";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Location = new System.Drawing.Point(20, 151);
            this.btnAddCompany.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(100, 29);
            this.btnAddCompany.TabIndex = 2;
            this.btnAddCompany.Text = "添加公司";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(333, 281);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(367, 211);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "修改组织";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(325, 25);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 121);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "提示：请输入要添加的信息！";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 151);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "修改组织";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 79);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(325, 25);
            this.textBox2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Location = new System.Drawing.Point(333, 528);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(367, 211);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "删除组织";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(20, 36);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(325, 25);
            this.textBox3.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "提示：请输入要添加的信息！";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(132, 151);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 29);
            this.button5.TabIndex = 2;
            this.button5.Text = "删除组织";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(20, 79);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(325, 25);
            this.textBox4.TabIndex = 1;
            // 
            // FrmDtManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 755);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trvwDepartment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmDtManage";
            this.Text = "部门管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAddNode_FormClosed);
            this.Load += new System.EventHandler(this.FrmAddNode_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView trvwDepartment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNewNode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblInputTips;
        private System.Windows.Forms.Button btnAddDtGroup;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnAddCompany;
        private System.Windows.Forms.TextBox txtParentNode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox4;
    }
}