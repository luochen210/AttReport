namespace AttReport
{
    partial class FrmClassesTimes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvClassses = new System.Windows.Forms.DataGridView();
            this.ClassesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimesName1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimesName2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimesName3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.chkMonday = new System.Windows.Forms.CheckBox();
            this.chkTuesday = new System.Windows.Forms.CheckBox();
            this.chkWednesday = new System.Windows.Forms.CheckBox();
            this.chkThursday = new System.Windows.Forms.CheckBox();
            this.chkFriday = new System.Windows.Forms.CheckBox();
            this.chkSaturday = new System.Windows.Forms.CheckBox();
            this.chkSunday = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClassesName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClassesAdd = new System.Windows.Forms.Button();
            this.cboTimes3 = new System.Windows.Forms.ComboBox();
            this.cboTimes2 = new System.Windows.Forms.ComboBox();
            this.cboTimes1 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassses)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvClassses
            // 
            this.dgvClassses.AllowUserToAddRows = false;
            this.dgvClassses.AllowUserToOrderColumns = true;
            this.dgvClassses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClassses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClassses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClassses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassesName,
            this.TimesName1,
            this.TimesName2,
            this.TimesName3,
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.Saturday,
            this.Sunday});
            this.dgvClassses.Location = new System.Drawing.Point(12, 161);
            this.dgvClassses.Name = "dgvClassses";
            this.dgvClassses.ReadOnly = true;
            this.dgvClassses.RowHeadersVisible = false;
            this.dgvClassses.RowTemplate.Height = 23;
            this.dgvClassses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClassses.Size = new System.Drawing.Size(923, 293);
            this.dgvClassses.TabIndex = 0;
            this.dgvClassses.SelectionChanged += new System.EventHandler(this.dgvClassses_SelectionChanged);
            // 
            // ClassesName
            // 
            this.ClassesName.DataPropertyName = "ClassesName";
            this.ClassesName.HeaderText = "班次名称";
            this.ClassesName.Name = "ClassesName";
            this.ClassesName.ReadOnly = true;
            this.ClassesName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TimesName1
            // 
            this.TimesName1.DataPropertyName = "TimesName1";
            this.TimesName1.HeaderText = "时段1";
            this.TimesName1.Name = "TimesName1";
            this.TimesName1.ReadOnly = true;
            this.TimesName1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TimesName2
            // 
            this.TimesName2.DataPropertyName = "TimesName2";
            dataGridViewCellStyle4.NullValue = null;
            this.TimesName2.DefaultCellStyle = dataGridViewCellStyle4;
            this.TimesName2.HeaderText = "时段2";
            this.TimesName2.Name = "TimesName2";
            this.TimesName2.ReadOnly = true;
            this.TimesName2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TimesName3
            // 
            this.TimesName3.DataPropertyName = "TimesName3";
            this.TimesName3.HeaderText = "时段3";
            this.TimesName3.Name = "TimesName3";
            this.TimesName3.ReadOnly = true;
            this.TimesName3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Monday
            // 
            this.Monday.DataPropertyName = "Monday";
            this.Monday.HeaderText = "周一";
            this.Monday.Name = "Monday";
            this.Monday.ReadOnly = true;
            this.Monday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Tuesday
            // 
            this.Tuesday.DataPropertyName = "Tuesday";
            this.Tuesday.HeaderText = "周二";
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.ReadOnly = true;
            this.Tuesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Wednesday
            // 
            this.Wednesday.DataPropertyName = "Wednesday";
            this.Wednesday.HeaderText = "周三";
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.ReadOnly = true;
            this.Wednesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Thursday
            // 
            this.Thursday.DataPropertyName = "Thursday";
            this.Thursday.HeaderText = "周四";
            this.Thursday.Name = "Thursday";
            this.Thursday.ReadOnly = true;
            this.Thursday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Friday
            // 
            this.Friday.DataPropertyName = "Friday";
            this.Friday.HeaderText = "周五";
            this.Friday.Name = "Friday";
            this.Friday.ReadOnly = true;
            this.Friday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Saturday
            // 
            this.Saturday.DataPropertyName = "Saturday";
            this.Saturday.HeaderText = "周六";
            this.Saturday.Name = "Saturday";
            this.Saturday.ReadOnly = true;
            this.Saturday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Sunday
            // 
            this.Sunday.DataPropertyName = "Sunday";
            this.Sunday.HeaderText = "周日";
            this.Sunday.Name = "Sunday";
            this.Sunday.ReadOnly = true;
            this.Sunday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(267, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "时段1：";
            // 
            // chkMonday
            // 
            this.chkMonday.AutoSize = true;
            this.chkMonday.Location = new System.Drawing.Point(21, 85);
            this.chkMonday.Name = "chkMonday";
            this.chkMonday.Size = new System.Drawing.Size(48, 16);
            this.chkMonday.TabIndex = 7;
            this.chkMonday.Text = "周一";
            this.chkMonday.UseVisualStyleBackColor = true;
            // 
            // chkTuesday
            // 
            this.chkTuesday.AutoSize = true;
            this.chkTuesday.Location = new System.Drawing.Point(85, 85);
            this.chkTuesday.Name = "chkTuesday";
            this.chkTuesday.Size = new System.Drawing.Size(48, 16);
            this.chkTuesday.TabIndex = 7;
            this.chkTuesday.Text = "周二";
            this.chkTuesday.UseVisualStyleBackColor = true;
            // 
            // chkWednesday
            // 
            this.chkWednesday.AutoSize = true;
            this.chkWednesday.Location = new System.Drawing.Point(149, 85);
            this.chkWednesday.Name = "chkWednesday";
            this.chkWednesday.Size = new System.Drawing.Size(48, 16);
            this.chkWednesday.TabIndex = 7;
            this.chkWednesday.Text = "周三";
            this.chkWednesday.UseVisualStyleBackColor = true;
            // 
            // chkThursday
            // 
            this.chkThursday.AutoSize = true;
            this.chkThursday.Location = new System.Drawing.Point(213, 85);
            this.chkThursday.Name = "chkThursday";
            this.chkThursday.Size = new System.Drawing.Size(48, 16);
            this.chkThursday.TabIndex = 7;
            this.chkThursday.Text = "周四";
            this.chkThursday.UseVisualStyleBackColor = true;
            // 
            // chkFriday
            // 
            this.chkFriday.AutoSize = true;
            this.chkFriday.Location = new System.Drawing.Point(277, 85);
            this.chkFriday.Name = "chkFriday";
            this.chkFriday.Size = new System.Drawing.Size(48, 16);
            this.chkFriday.TabIndex = 7;
            this.chkFriday.Text = "周五";
            this.chkFriday.UseVisualStyleBackColor = true;
            // 
            // chkSaturday
            // 
            this.chkSaturday.AutoSize = true;
            this.chkSaturday.ForeColor = System.Drawing.Color.Red;
            this.chkSaturday.Location = new System.Drawing.Point(341, 85);
            this.chkSaturday.Name = "chkSaturday";
            this.chkSaturday.Size = new System.Drawing.Size(48, 16);
            this.chkSaturday.TabIndex = 7;
            this.chkSaturday.Text = "周六";
            this.chkSaturday.UseVisualStyleBackColor = true;
            // 
            // chkSunday
            // 
            this.chkSunday.AutoSize = true;
            this.chkSunday.ForeColor = System.Drawing.Color.Red;
            this.chkSunday.Location = new System.Drawing.Point(409, 85);
            this.chkSunday.Name = "chkSunday";
            this.chkSunday.Size = new System.Drawing.Size(48, 16);
            this.chkSunday.TabIndex = 7;
            this.chkSunday.Text = "周日";
            this.chkSunday.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClassesName);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.chkThursday);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnClassesAdd);
            this.groupBox1.Controls.Add(this.chkSunday);
            this.groupBox1.Controls.Add(this.chkSaturday);
            this.groupBox1.Controls.Add(this.chkWednesday);
            this.groupBox1.Controls.Add(this.chkFriday);
            this.groupBox1.Controls.Add(this.chkTuesday);
            this.groupBox1.Controls.Add(this.chkMonday);
            this.groupBox1.Controls.Add(this.cboTimes3);
            this.groupBox1.Controls.Add(this.cboTimes2);
            this.groupBox1.Controls.Add(this.cboTimes1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(923, 130);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "班次时间修改";
            // 
            // txtClassesName
            // 
            this.txtClassesName.Location = new System.Drawing.Point(90, 36);
            this.txtClassesName.Name = "txtClassesName";
            this.txtClassesName.Size = new System.Drawing.Size(121, 21);
            this.txtClassesName.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(490, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "清除";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(826, 82);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "删除";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(714, 82);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClassesAdd
            // 
            this.btnClassesAdd.Location = new System.Drawing.Point(602, 82);
            this.btnClassesAdd.Name = "btnClassesAdd";
            this.btnClassesAdd.Size = new System.Drawing.Size(75, 23);
            this.btnClassesAdd.TabIndex = 1;
            this.btnClassesAdd.Text = "添加";
            this.btnClassesAdd.UseVisualStyleBackColor = true;
            this.btnClassesAdd.Click += new System.EventHandler(this.btnClassesAdd_Click);
            // 
            // cboTimes3
            // 
            this.cboTimes3.FormattingEnabled = true;
            this.cboTimes3.Location = new System.Drawing.Point(780, 36);
            this.cboTimes3.Name = "cboTimes3";
            this.cboTimes3.Size = new System.Drawing.Size(121, 20);
            this.cboTimes3.TabIndex = 6;
            // 
            // cboTimes2
            // 
            this.cboTimes2.FormattingEnabled = true;
            this.cboTimes2.Location = new System.Drawing.Point(550, 36);
            this.cboTimes2.Name = "cboTimes2";
            this.cboTimes2.Size = new System.Drawing.Size(121, 20);
            this.cboTimes2.TabIndex = 6;
            this.cboTimes2.SelectedIndexChanged += new System.EventHandler(this.cboTimes2_SelectedIndexChanged);
            // 
            // cboTimes1
            // 
            this.cboTimes1.FormattingEnabled = true;
            this.cboTimes1.Location = new System.Drawing.Point(320, 36);
            this.cboTimes1.Name = "cboTimes1";
            this.cboTimes1.Size = new System.Drawing.Size(121, 20);
            this.cboTimes1.TabIndex = 6;
            this.cboTimes1.SelectedIndexChanged += new System.EventHandler(this.cboTimes1_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = "班次名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(727, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "时段3：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "时段2：";
            // 
            // FrmClassesTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 466);
            this.Controls.Add(this.dgvClassses);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmClassesTimes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "班次管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmClassesTimes_FormClosed);
            this.Load += new System.EventHandler(this.FrmClassesTimes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvClassses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkMonday;
        private System.Windows.Forms.CheckBox chkTuesday;
        private System.Windows.Forms.CheckBox chkWednesday;
        private System.Windows.Forms.CheckBox chkThursday;
        private System.Windows.Forms.CheckBox chkFriday;
        private System.Windows.Forms.CheckBox chkSaturday;
        private System.Windows.Forms.CheckBox chkSunday;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClassesAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboTimes3;
        private System.Windows.Forms.ComboBox cboTimes2;
        private System.Windows.Forms.ComboBox cboTimes1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClassesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimesName1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimesName2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimesName3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sunday;
    }
}