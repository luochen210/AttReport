namespace AttReport
{
    partial class FrmSfShiftSet
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cboSfGroup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblState = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCheckAll = new System.Windows.Forms.Button();
            this.cboWorkShift = new System.Windows.Forms.ComboBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.lblWorkShift = new System.Windows.Forms.Label();
            this.SfId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfJobName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SfShift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btnQuery);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCheckAll);
            this.panel1.Controls.Add(this.cboSfGroup);
            this.panel1.Controls.Add(this.cboWorkShift);
            this.panel1.Controls.Add(this.lblWorkShift);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 36);
            this.panel1.TabIndex = 0;
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(150, 7);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cboSfGroup
            // 
            this.cboSfGroup.FormattingEnabled = true;
            this.cboSfGroup.Location = new System.Drawing.Point(44, 8);
            this.cboSfGroup.Name = "cboSfGroup";
            this.cboSfGroup.Size = new System.Drawing.Size(87, 20);
            this.cboSfGroup.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "部门：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SfId,
            this.SfDepartment,
            this.SfGroup,
            this.SfJobName,
            this.SfName,
            this.SfGender,
            this.SfStatus,
            this.WorkShift,
            this.SfShift});
            this.dataGridView1.Location = new System.Drawing.Point(2, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(780, 482);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblState);
            this.panel2.Controls.Add(this.lblSelect);
            this.panel2.Location = new System.Drawing.Point(2, 533);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(780, 24);
            this.panel2.TabIndex = 0;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(7, 6);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(53, 12);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "等待选择";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(701, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCheckAll
            // 
            this.btnCheckAll.BackColor = System.Drawing.Color.White;
            this.btnCheckAll.Location = new System.Drawing.Point(383, 6);
            this.btnCheckAll.Name = "btnCheckAll";
            this.btnCheckAll.Size = new System.Drawing.Size(75, 23);
            this.btnCheckAll.TabIndex = 2;
            this.btnCheckAll.Text = "全选";
            this.btnCheckAll.UseVisualStyleBackColor = false;
            // 
            // cboWorkShift
            // 
            this.cboWorkShift.FormattingEnabled = true;
            this.cboWorkShift.Location = new System.Drawing.Point(560, 8);
            this.cboWorkShift.Name = "cboWorkShift";
            this.cboWorkShift.Size = new System.Drawing.Size(121, 20);
            this.cboWorkShift.TabIndex = 1;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(487, 6);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(65, 12);
            this.lblSelect.TabIndex = 0;
            this.lblSelect.Text = "选择班次：";
            // 
            // lblWorkShift
            // 
            this.lblWorkShift.AutoSize = true;
            this.lblWorkShift.Location = new System.Drawing.Point(501, 12);
            this.lblWorkShift.Name = "lblWorkShift";
            this.lblWorkShift.Size = new System.Drawing.Size(65, 12);
            this.lblWorkShift.TabIndex = 0;
            this.lblWorkShift.Text = "设置班次：";
            // 
            // SfId
            // 
            this.SfId.HeaderText = "ID";
            this.SfId.Name = "SfId";
            this.SfId.Width = 50;
            // 
            // SfDepartment
            // 
            this.SfDepartment.HeaderText = "部门";
            this.SfDepartment.Name = "SfDepartment";
            this.SfDepartment.Width = 80;
            // 
            // SfGroup
            // 
            this.SfGroup.HeaderText = "组别";
            this.SfGroup.Name = "SfGroup";
            // 
            // SfJobName
            // 
            this.SfJobName.HeaderText = "职位";
            this.SfJobName.Name = "SfJobName";
            // 
            // SfName
            // 
            this.SfName.HeaderText = "姓名";
            this.SfName.Name = "SfName";
            this.SfName.Width = 80;
            // 
            // SfGender
            // 
            this.SfGender.HeaderText = "性别";
            this.SfGender.Name = "SfGender";
            this.SfGender.Width = 40;
            // 
            // SfStatus
            // 
            this.SfStatus.HeaderText = "在职状态";
            this.SfStatus.Name = "SfStatus";
            this.SfStatus.Width = 80;
            // 
            // WorkShift
            // 
            this.WorkShift.HeaderText = "班次";
            this.WorkShift.Name = "WorkShift";
            // 
            // SfShift
            // 
            this.SfShift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SfShift.HeaderText = "轮班标记";
            this.SfShift.Name = "SfShift";
            // 
            // FrmSfShiftSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSfShiftSet";
            this.Text = "轮班管理";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cboSfGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCheckAll;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboWorkShift;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblWorkShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfJobName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkShift;
        private System.Windows.Forms.DataGridViewTextBoxColumn SfShift;
    }
}