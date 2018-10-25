namespace AttReport
{
    partial class FrmAddNode
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
            this.lblCompany = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cboCompany = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDtGroup = new System.Windows.Forms.ComboBox();
            this.trvwDepartment = new System.Windows.Forms.TreeView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblCompanyTips = new System.Windows.Forms.Label();
            this.lblDepartmentTips = new System.Windows.Forms.Label();
            this.lblDtGroupTips = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRemoveTips = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(256, 31);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(53, 12);
            this.lblCompany.TabIndex = 0;
            this.lblCompany.Text = "公司名：";
            // 
            // btnRemove
            // 
            this.btnRemove.AutoSize = true;
            this.btnRemove.Location = new System.Drawing.Point(482, 182);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "删除";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cboCompany
            // 
            this.cboCompany.FormattingEnabled = true;
            this.cboCompany.Location = new System.Drawing.Point(315, 27);
            this.cboCompany.Name = "cboCompany";
            this.cboCompany.Size = new System.Drawing.Size(242, 20);
            this.cboCompany.TabIndex = 3;
            this.cboCompany.Text = "东莞市东讯五金电气有限公司";
            this.cboCompany.SelectedIndexChanged += new System.EventHandler(this.DepartmentList_SelectedIndexChanged);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(256, 75);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(53, 12);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "部门名：";
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(315, 71);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(242, 20);
            this.cboDepartment.TabIndex = 3;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.DtGroupList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "组别名：";
            // 
            // cboDtGroup
            // 
            this.cboDtGroup.FormattingEnabled = true;
            this.cboDtGroup.Location = new System.Drawing.Point(315, 115);
            this.cboDtGroup.Name = "cboDtGroup";
            this.cboDtGroup.Size = new System.Drawing.Size(242, 20);
            this.cboDtGroup.TabIndex = 3;
            // 
            // trvwDepartment
            // 
            this.trvwDepartment.Location = new System.Drawing.Point(12, 27);
            this.trvwDepartment.Name = "trvwDepartment";
            this.trvwDepartment.Size = new System.Drawing.Size(222, 565);
            this.trvwDepartment.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Location = new System.Drawing.Point(315, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblCompanyTips
            // 
            this.lblCompanyTips.AutoSize = true;
            this.lblCompanyTips.ForeColor = System.Drawing.Color.Red;
            this.lblCompanyTips.Location = new System.Drawing.Point(663, 31);
            this.lblCompanyTips.Name = "lblCompanyTips";
            this.lblCompanyTips.Size = new System.Drawing.Size(0, 12);
            this.lblCompanyTips.TabIndex = 5;
            // 
            // lblDepartmentTips
            // 
            this.lblDepartmentTips.AutoSize = true;
            this.lblDepartmentTips.ForeColor = System.Drawing.Color.Red;
            this.lblDepartmentTips.Location = new System.Drawing.Point(663, 75);
            this.lblDepartmentTips.Name = "lblDepartmentTips";
            this.lblDepartmentTips.Size = new System.Drawing.Size(0, 12);
            this.lblDepartmentTips.TabIndex = 5;
            // 
            // lblDtGroupTips
            // 
            this.lblDtGroupTips.AutoSize = true;
            this.lblDtGroupTips.ForeColor = System.Drawing.Color.Red;
            this.lblDtGroupTips.Location = new System.Drawing.Point(663, 119);
            this.lblDtGroupTips.Name = "lblDtGroupTips";
            this.lblDtGroupTips.Size = new System.Drawing.Size(0, 12);
            this.lblDtGroupTips.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(10, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "架构展示：";
            // 
            // lblRemoveTips
            // 
            this.lblRemoveTips.AutoSize = true;
            this.lblRemoveTips.ForeColor = System.Drawing.Color.Green;
            this.lblRemoveTips.Location = new System.Drawing.Point(402, 152);
            this.lblRemoveTips.Name = "lblRemoveTips";
            this.lblRemoveTips.Size = new System.Drawing.Size(65, 12);
            this.lblRemoveTips.TabIndex = 7;
            this.lblRemoveTips.Text = "删除成功！";
            // 
            // FrmAddNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 604);
            this.Controls.Add(this.lblRemoveTips);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDtGroupTips);
            this.Controls.Add(this.lblDepartmentTips);
            this.Controls.Add(this.lblCompanyTips);
            this.Controls.Add(this.trvwDepartment);
            this.Controls.Add(this.cboDtGroup);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.cboCompany);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblCompany);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmAddNode";
            this.Text = "部门管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmAddNode_FormClosed);
            this.Load += new System.EventHandler(this.FrmAddNode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cboCompany;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDtGroup;
        private System.Windows.Forms.TreeView trvwDepartment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblCompanyTips;
        private System.Windows.Forms.Label lblDepartmentTips;
        private System.Windows.Forms.Label lblDtGroupTips;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRemoveTips;
    }
}