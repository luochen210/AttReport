namespace AttReport
{
    partial class FrmSfWorkTime
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvTimesManage = new System.Windows.Forms.DataGridView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAlter = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dtpEndSignBack = new System.Windows.Forms.DateTimePicker();
            this.dtpStartSignBack = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpEndCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpStartCheckIn = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpOffDutyTime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpWorkTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLeftEarly = new System.Windows.Forms.TextBox();
            this.txtLateTime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimesName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TimesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OffDutyTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartSignBack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndSignBack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftEarly = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimesManage)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvTimesManage);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnRemove);
            this.splitContainer1.Panel2.Controls.Add(this.btnAlter);
            this.splitContainer1.Panel2.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel2.Controls.Add(this.dtpEndSignBack);
            this.splitContainer1.Panel2.Controls.Add(this.dtpStartSignBack);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.dtpEndCheckIn);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.dtpStartCheckIn);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.dtpOffDutyTime);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.dtpWorkTime);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txtLeftEarly);
            this.splitContainer1.Panel2.Controls.Add(this.txtLateTime);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.txtTimesName);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(816, 445);
            this.splitContainer1.SplitterDistance = 594;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvTimesManage
            // 
            this.dgvTimesManage.AllowUserToAddRows = false;
            this.dgvTimesManage.AllowUserToDeleteRows = false;
            this.dgvTimesManage.AllowUserToOrderColumns = true;
            this.dgvTimesManage.AllowUserToResizeColumns = false;
            this.dgvTimesManage.AllowUserToResizeRows = false;
            this.dgvTimesManage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimesManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimesManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TimesName,
            this.WorkTime,
            this.OffDutyTime,
            this.StartCheckIn,
            this.EndCheckIn,
            this.StartSignBack,
            this.EndSignBack,
            this.LateTime,
            this.LeftEarly});
            this.dgvTimesManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTimesManage.Location = new System.Drawing.Point(0, 0);
            this.dgvTimesManage.Name = "dgvTimesManage";
            this.dgvTimesManage.ReadOnly = true;
            this.dgvTimesManage.RowHeadersVisible = false;
            this.dgvTimesManage.RowTemplate.Height = 23;
            this.dgvTimesManage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTimesManage.Size = new System.Drawing.Size(594, 445);
            this.dgvTimesManage.TabIndex = 0;
            this.dgvTimesManage.SelectionChanged += new System.EventHandler(this.dgvTimesManage_SelectionChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(155, 392);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(50, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "删除";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(85, 392);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(50, 23);
            this.btnAlter.TabIndex = 11;
            this.btnAlter.Text = "修改";
            this.btnAlter.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 392);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dtpEndSignBack
            // 
            this.dtpEndSignBack.CustomFormat = "HH:mm:ss";
            this.dtpEndSignBack.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndSignBack.Location = new System.Drawing.Point(82, 258);
            this.dtpEndSignBack.Name = "dtpEndSignBack";
            this.dtpEndSignBack.ShowUpDown = true;
            this.dtpEndSignBack.Size = new System.Drawing.Size(123, 21);
            this.dtpEndSignBack.TabIndex = 7;
            // 
            // dtpStartSignBack
            // 
            this.dtpStartSignBack.CustomFormat = "HH:mm:ss";
            this.dtpStartSignBack.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartSignBack.Location = new System.Drawing.Point(82, 217);
            this.dtpStartSignBack.Name = "dtpStartSignBack";
            this.dtpStartSignBack.ShowUpDown = true;
            this.dtpStartSignBack.Size = new System.Drawing.Size(123, 21);
            this.dtpStartSignBack.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "结束签退：";
            // 
            // dtpEndCheckIn
            // 
            this.dtpEndCheckIn.CustomFormat = "HH:mm:ss";
            this.dtpEndCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndCheckIn.Location = new System.Drawing.Point(82, 176);
            this.dtpEndCheckIn.Name = "dtpEndCheckIn";
            this.dtpEndCheckIn.ShowUpDown = true;
            this.dtpEndCheckIn.Size = new System.Drawing.Size(123, 21);
            this.dtpEndCheckIn.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "开始签退：";
            // 
            // dtpStartCheckIn
            // 
            this.dtpStartCheckIn.CustomFormat = "HH:mm:ss";
            this.dtpStartCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartCheckIn.Location = new System.Drawing.Point(82, 135);
            this.dtpStartCheckIn.Name = "dtpStartCheckIn";
            this.dtpStartCheckIn.ShowUpDown = true;
            this.dtpStartCheckIn.Size = new System.Drawing.Size(123, 21);
            this.dtpStartCheckIn.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "结束签到：";
            // 
            // dtpOffDutyTime
            // 
            this.dtpOffDutyTime.CustomFormat = "HH:mm:ss";
            this.dtpOffDutyTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOffDutyTime.Location = new System.Drawing.Point(82, 94);
            this.dtpOffDutyTime.Name = "dtpOffDutyTime";
            this.dtpOffDutyTime.ShowUpDown = true;
            this.dtpOffDutyTime.Size = new System.Drawing.Size(123, 21);
            this.dtpOffDutyTime.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "开始签到：";
            // 
            // dtpWorkTime
            // 
            this.dtpWorkTime.CustomFormat = "HH:mm:ss";
            this.dtpWorkTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpWorkTime.Location = new System.Drawing.Point(82, 53);
            this.dtpWorkTime.Name = "dtpWorkTime";
            this.dtpWorkTime.ShowUpDown = true;
            this.dtpWorkTime.Size = new System.Drawing.Size(123, 21);
            this.dtpWorkTime.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "下班时间：";
            // 
            // txtLeftEarly
            // 
            this.txtLeftEarly.Location = new System.Drawing.Point(82, 340);
            this.txtLeftEarly.Name = "txtLeftEarly";
            this.txtLeftEarly.Size = new System.Drawing.Size(123, 21);
            this.txtLeftEarly.TabIndex = 9;
            // 
            // txtLateTime
            // 
            this.txtLateTime.Location = new System.Drawing.Point(82, 299);
            this.txtLateTime.Name = "txtLateTime";
            this.txtLateTime.Size = new System.Drawing.Size(123, 21);
            this.txtLateTime.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 344);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "早退分钟：";
            // 
            // txtTimesName
            // 
            this.txtTimesName.Location = new System.Drawing.Point(82, 12);
            this.txtTimesName.Name = "txtTimesName";
            this.txtTimesName.Size = new System.Drawing.Size(123, 21);
            this.txtTimesName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "迟到分钟：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "上班时间：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "时段名称：";
            // 
            // TimesName
            // 
            this.TimesName.DataPropertyName = "TimesName";
            this.TimesName.HeaderText = "时段名称";
            this.TimesName.Name = "TimesName";
            this.TimesName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // WorkTime
            // 
            this.WorkTime.DataPropertyName = "WorkTime";
            this.WorkTime.HeaderText = "上班时间";
            this.WorkTime.Name = "WorkTime";
            this.WorkTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // OffDutyTime
            // 
            this.OffDutyTime.DataPropertyName = "OffDutyTime";
            this.OffDutyTime.HeaderText = "下班时间";
            this.OffDutyTime.Name = "OffDutyTime";
            this.OffDutyTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StartCheckIn
            // 
            this.StartCheckIn.DataPropertyName = "StartCheckIn";
            this.StartCheckIn.HeaderText = "开始签到";
            this.StartCheckIn.Name = "StartCheckIn";
            this.StartCheckIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EndCheckIn
            // 
            this.EndCheckIn.DataPropertyName = "EndCheckIn";
            this.EndCheckIn.HeaderText = "结束签到";
            this.EndCheckIn.Name = "EndCheckIn";
            this.EndCheckIn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // StartSignBack
            // 
            this.StartSignBack.DataPropertyName = "StartSignBack";
            this.StartSignBack.HeaderText = "开始签退";
            this.StartSignBack.Name = "StartSignBack";
            this.StartSignBack.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // EndSignBack
            // 
            this.EndSignBack.DataPropertyName = "EndSignBack";
            this.EndSignBack.HeaderText = "结束签退";
            this.EndSignBack.Name = "EndSignBack";
            this.EndSignBack.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LateTime
            // 
            this.LateTime.DataPropertyName = "LateTime";
            this.LateTime.HeaderText = "迟到分钟";
            this.LateTime.Name = "LateTime";
            this.LateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // LeftEarly
            // 
            this.LeftEarly.DataPropertyName = "LeftEarly";
            this.LeftEarly.HeaderText = "早退分钟";
            this.LeftEarly.Name = "LeftEarly";
            this.LeftEarly.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // FrmTimesManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 469);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmTimesManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "时间段管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmTimesManage_FormClosed);
            this.Load += new System.EventHandler(this.FrmTimesManage_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimesManage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvTimesManage;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dtpEndSignBack;
        private System.Windows.Forms.DateTimePicker dtpStartSignBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpEndCheckIn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpStartCheckIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpOffDutyTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpWorkTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLeftEarly;
        private System.Windows.Forms.TextBox txtLateTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTimesName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn OffDutyTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndCheckIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartSignBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndSignBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn LateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftEarly;
    }
}