﻿namespace AttReport
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
            this.chkCompany = new System.Windows.Forms.CheckBox();
            this.txtParentNode = new System.Windows.Forms.TextBox();
            this.lblInputTips = new System.Windows.Forms.Label();
            this.btnAddDtGroup = new System.Windows.Forms.Button();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnAddCompany = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtParentNode1 = new System.Windows.Forms.TextBox();
            this.lblInputTips1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNewNode1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtParentNode2 = new System.Windows.Forms.TextBox();
            this.lblInputTips2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // trvwDepartment
            // 
            this.trvwDepartment.Location = new System.Drawing.Point(12, 27);
            this.trvwDepartment.Name = "trvwDepartment";
            this.trvwDepartment.Size = new System.Drawing.Size(222, 565);
            this.trvwDepartment.TabIndex = 0;
            this.trvwDepartment.TabStop = false;
            this.trvwDepartment.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvwDepartment_NodeMouseClick);
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
            // txtNewNode
            // 
            this.txtNewNode.Location = new System.Drawing.Point(15, 63);
            this.txtNewNode.Name = "txtNewNode";
            this.txtNewNode.Size = new System.Drawing.Size(245, 21);
            this.txtNewNode.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkCompany);
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
            // chkCompany
            // 
            this.chkCompany.AutoSize = true;
            this.chkCompany.Location = new System.Drawing.Point(198, 94);
            this.chkCompany.Margin = new System.Windows.Forms.Padding(2);
            this.chkCompany.Name = "chkCompany";
            this.chkCompany.Size = new System.Drawing.Size(72, 16);
            this.chkCompany.TabIndex = 3;
            this.chkCompany.Text = "添加公司";
            this.chkCompany.UseVisualStyleBackColor = true;
            this.chkCompany.CheckedChanged += new System.EventHandler(this.chkCompany_CheckedChanged);
            // 
            // txtParentNode
            // 
            this.txtParentNode.Location = new System.Drawing.Point(15, 29);
            this.txtParentNode.Name = "txtParentNode";
            this.txtParentNode.ReadOnly = true;
            this.txtParentNode.Size = new System.Drawing.Size(245, 21);
            this.txtParentNode.TabIndex = 0;
            // 
            // lblInputTips
            // 
            this.lblInputTips.AutoSize = true;
            this.lblInputTips.Location = new System.Drawing.Point(13, 95);
            this.lblInputTips.Name = "lblInputTips";
            this.lblInputTips.Size = new System.Drawing.Size(0, 12);
            this.lblInputTips.TabIndex = 6;
            // 
            // btnAddDtGroup
            // 
            this.btnAddDtGroup.Location = new System.Drawing.Point(185, 121);
            this.btnAddDtGroup.Name = "btnAddDtGroup";
            this.btnAddDtGroup.Size = new System.Drawing.Size(75, 23);
            this.btnAddDtGroup.TabIndex = 6;
            this.btnAddDtGroup.Text = "添加组别";
            this.btnAddDtGroup.UseVisualStyleBackColor = true;
            this.btnAddDtGroup.Click += new System.EventHandler(this.btnAddDtGroup_Click);
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(99, 121);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(75, 23);
            this.btnAddDepartment.TabIndex = 5;
            this.btnAddDepartment.Text = "添加部门";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // btnAddCompany
            // 
            this.btnAddCompany.Location = new System.Drawing.Point(15, 121);
            this.btnAddCompany.Name = "btnAddCompany";
            this.btnAddCompany.Size = new System.Drawing.Size(75, 23);
            this.btnAddCompany.TabIndex = 4;
            this.btnAddCompany.Text = "添加公司";
            this.btnAddCompany.UseVisualStyleBackColor = true;
            this.btnAddCompany.Click += new System.EventHandler(this.btnAddCompany_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtParentNode1);
            this.groupBox2.Controls.Add(this.lblInputTips1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtNewNode1);
            this.groupBox2.Location = new System.Drawing.Point(250, 225);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 169);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "修改组织";
            // 
            // txtParentNode1
            // 
            this.txtParentNode1.Location = new System.Drawing.Point(15, 29);
            this.txtParentNode1.Name = "txtParentNode1";
            this.txtParentNode1.ReadOnly = true;
            this.txtParentNode1.Size = new System.Drawing.Size(245, 21);
            this.txtParentNode1.TabIndex = 7;
            // 
            // lblInputTips1
            // 
            this.lblInputTips1.AutoSize = true;
            this.lblInputTips1.Location = new System.Drawing.Point(13, 97);
            this.lblInputTips1.Name = "lblInputTips1";
            this.lblInputTips1.Size = new System.Drawing.Size(0, 12);
            this.lblInputTips1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "修改组织";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // txtNewNode1
            // 
            this.txtNewNode1.Location = new System.Drawing.Point(15, 63);
            this.txtNewNode1.Name = "txtNewNode1";
            this.txtNewNode1.Size = new System.Drawing.Size(245, 21);
            this.txtNewNode1.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtParentNode2);
            this.groupBox3.Controls.Add(this.lblInputTips2);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Location = new System.Drawing.Point(250, 422);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 169);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "删除组织";
            // 
            // txtParentNode2
            // 
            this.txtParentNode2.Location = new System.Drawing.Point(15, 43);
            this.txtParentNode2.Name = "txtParentNode2";
            this.txtParentNode2.ReadOnly = true;
            this.txtParentNode2.Size = new System.Drawing.Size(245, 21);
            this.txtParentNode2.TabIndex = 7;
            // 
            // lblInputTips2
            // 
            this.lblInputTips2.AutoSize = true;
            this.lblInputTips2.Location = new System.Drawing.Point(13, 97);
            this.lblInputTips2.Name = "lblInputTips2";
            this.lblInputTips2.Size = new System.Drawing.Size(0, 12);
            this.lblInputTips2.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(99, 121);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "删除组织";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // FrmDtManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 604);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trvwDepartment);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmDtManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox txtParentNode1;
        private System.Windows.Forms.Label lblInputTips1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtNewNode1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtParentNode2;
        private System.Windows.Forms.Label lblInputTips2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox chkCompany;
    }
}