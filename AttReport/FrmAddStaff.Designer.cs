namespace AttReport
{
    partial class FrmAddStaff
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblIDCard = new System.Windows.Forms.Label();
            this.txtIDCard = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtFriend = new System.Windows.Forms.TextBox();
            this.lblNation = new System.Windows.Forms.Label();
            this.lblEntryDate = new System.Windows.Forms.Label();
            this.lblMobilePhone = new System.Windows.Forms.Label();
            this.txtMobilePhone = new System.Windows.Forms.TextBox();
            this.dtpEntryDate = new System.Windows.Forms.DateTimePicker();
            this.lblNativePlace = new System.Windows.Forms.Label();
            this.lblEducation = new System.Windows.Forms.Label();
            this.cboEducation = new System.Windows.Forms.ComboBox();
            this.lblMarriage = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cboMarriage = new System.Windows.Forms.ComboBox();
            this.cboJob = new System.Windows.Forms.ComboBox();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.txtResidence = new System.Windows.Forms.TextBox();
            this.btnSaveStaff = new System.Windows.Forms.Button();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.cboDepartment = new System.Windows.Forms.ComboBox();
            this.lblJobNo = new System.Windows.Forms.Label();
            this.txtJobNo = new System.Windows.Forms.TextBox();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.txtDomicile = new System.Windows.Forms.TextBox();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.lblFriendsPhone = new System.Windows.Forms.Label();
            this.txtFriendPhone = new System.Windows.Forms.TextBox();
            this.lblRelation = new System.Windows.Forms.Label();
            this.txtRelation = new System.Windows.Forms.TextBox();
            this.lblSeniority = new System.Windows.Forms.Label();
            this.txtSeniority = new System.Windows.Forms.TextBox();
            this.txtNativePlace = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblExamineResult = new System.Windows.Forms.Label();
            this.btnExamine = new System.Windows.Forms.Button();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.txtNation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIntroducer = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(59, 120);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 116);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(165, 25);
            this.txtName.TabIndex = 3;
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            // 
            // lblIDCard
            // 
            this.lblIDCard.AutoSize = true;
            this.lblIDCard.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIDCard.Location = new System.Drawing.Point(12, 35);
            this.lblIDCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDCard.Name = "lblIDCard";
            this.lblIDCard.Size = new System.Drawing.Size(71, 15);
            this.lblIDCard.TabIndex = 0;
            this.lblIDCard.Text = "身份证号";
            // 
            // txtIDCard
            // 
            this.txtIDCard.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtIDCard.Location = new System.Drawing.Point(91, 30);
            this.txtIDCard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDCard.Name = "txtIDCard";
            this.txtIDCard.Size = new System.Drawing.Size(228, 25);
            this.txtIDCard.TabIndex = 1;
            this.txtIDCard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnExamine_KeyDown);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(59, 242);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(37, 15);
            this.lblDepartment.TabIndex = 0;
            this.lblDepartment.Text = "部门";
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(27, 454);
            this.lblBirthDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(67, 15);
            this.lblBirthDate.TabIndex = 0;
            this.lblBirthDate.Text = "出生日期";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(27, 496);
            this.lblAddress1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(67, 15);
            this.lblAddress1.TabIndex = 0;
            this.lblAddress1.Text = "户籍地址";
            // 
            // txtFriend
            // 
            this.txtFriend.Location = new System.Drawing.Point(105, 632);
            this.txtFriend.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFriend.Name = "txtFriend";
            this.txtFriend.Size = new System.Drawing.Size(104, 25);
            this.txtFriend.TabIndex = 20;
            this.txtFriend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            // 
            // lblNation
            // 
            this.lblNation.AutoSize = true;
            this.lblNation.Location = new System.Drawing.Point(343, 370);
            this.lblNation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNation.Name = "lblNation";
            this.lblNation.Size = new System.Drawing.Size(37, 15);
            this.lblNation.TabIndex = 0;
            this.lblNation.Text = "民族";
            // 
            // lblEntryDate
            // 
            this.lblEntryDate.AutoSize = true;
            this.lblEntryDate.Location = new System.Drawing.Point(27, 412);
            this.lblEntryDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntryDate.Name = "lblEntryDate";
            this.lblEntryDate.Size = new System.Drawing.Size(67, 15);
            this.lblEntryDate.TabIndex = 0;
            this.lblEntryDate.Text = "入职日期";
            // 
            // lblMobilePhone
            // 
            this.lblMobilePhone.AutoSize = true;
            this.lblMobilePhone.Location = new System.Drawing.Point(343, 411);
            this.lblMobilePhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMobilePhone.Name = "lblMobilePhone";
            this.lblMobilePhone.Size = new System.Drawing.Size(37, 15);
            this.lblMobilePhone.TabIndex = 0;
            this.lblMobilePhone.Text = "手机";
            // 
            // txtMobilePhone
            // 
            this.txtMobilePhone.Location = new System.Drawing.Point(389, 406);
            this.txtMobilePhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMobilePhone.Name = "txtMobilePhone";
            this.txtMobilePhone.Size = new System.Drawing.Size(165, 25);
            this.txtMobilePhone.TabIndex = 15;
            this.txtMobilePhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            // 
            // dtpEntryDate
            // 
            this.dtpEntryDate.Location = new System.Drawing.Point(105, 406);
            this.dtpEntryDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEntryDate.Name = "dtpEntryDate";
            this.dtpEntryDate.Size = new System.Drawing.Size(165, 25);
            this.dtpEntryDate.TabIndex = 14;
            this.dtpEntryDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            // 
            // lblNativePlace
            // 
            this.lblNativePlace.AutoSize = true;
            this.lblNativePlace.Location = new System.Drawing.Point(59, 370);
            this.lblNativePlace.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNativePlace.Name = "lblNativePlace";
            this.lblNativePlace.Size = new System.Drawing.Size(37, 15);
            this.lblNativePlace.TabIndex = 0;
            this.lblNativePlace.Text = "籍贯";
            // 
            // lblEducation
            // 
            this.lblEducation.AutoSize = true;
            this.lblEducation.Location = new System.Drawing.Point(59, 328);
            this.lblEducation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(37, 15);
            this.lblEducation.TabIndex = 0;
            this.lblEducation.Text = "学历";
            // 
            // cboEducation
            // 
            this.cboEducation.FormattingEnabled = true;
            this.cboEducation.Items.AddRange(new object[] {
            "初中",
            "高中",
            "中专",
            "大专",
            "本科",
            "研究生"});
            this.cboEducation.Location = new System.Drawing.Point(105, 322);
            this.cboEducation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboEducation.Name = "cboEducation";
            this.cboEducation.Size = new System.Drawing.Size(165, 23);
            this.cboEducation.TabIndex = 10;
            this.cboEducation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            // 
            // lblMarriage
            // 
            this.lblMarriage.AutoSize = true;
            this.lblMarriage.Location = new System.Drawing.Point(59, 201);
            this.lblMarriage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarriage.Name = "lblMarriage";
            this.lblMarriage.Size = new System.Drawing.Size(37, 15);
            this.lblMarriage.TabIndex = 0;
            this.lblMarriage.Text = "婚姻";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(59, 159);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(37, 15);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "性别";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(59, 286);
            this.lblJob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(37, 15);
            this.lblJob.TabIndex = 0;
            this.lblJob.Text = "职位";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(105, 449);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(165, 25);
            this.dtpBirthDate.TabIndex = 16;
            this.dtpBirthDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            // 
            // cboMarriage
            // 
            this.cboMarriage.FormattingEnabled = true;
            this.cboMarriage.Items.AddRange(new object[] {
            "未婚",
            "已婚"});
            this.cboMarriage.Location = new System.Drawing.Point(105, 196);
            this.cboMarriage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboMarriage.Name = "cboMarriage";
            this.cboMarriage.Size = new System.Drawing.Size(165, 23);
            this.cboMarriage.TabIndex = 5;
            this.cboMarriage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            // 
            // cboJob
            // 
            this.cboJob.FormattingEnabled = true;
            this.cboJob.Location = new System.Drawing.Point(105, 281);
            this.cboJob.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboJob.Name = "cboJob";
            this.cboJob.Size = new System.Drawing.Size(165, 23);
            this.cboJob.TabIndex = 8;
            this.cboJob.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(343, 328);
            this.lblMajor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(37, 15);
            this.lblMajor.TabIndex = 0;
            this.lblMajor.Text = "专业";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(343, 201);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(37, 15);
            this.lblAge.TabIndex = 0;
            this.lblAge.Text = "年龄";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(389, 196);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAge.Name = "txtAge";
            this.txtAge.ReadOnly = true;
            this.txtAge.Size = new System.Drawing.Size(165, 25);
            this.txtAge.TabIndex = 0;
            this.txtAge.TabStop = false;
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(27, 566);
            this.lblAddress2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(67, 15);
            this.lblAddress2.TabIndex = 0;
            this.lblAddress2.Text = "现居地址";
            // 
            // txtResidence
            // 
            this.txtResidence.Location = new System.Drawing.Point(105, 562);
            this.txtResidence.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResidence.Multiline = true;
            this.txtResidence.Name = "txtResidence";
            this.txtResidence.Size = new System.Drawing.Size(449, 49);
            this.txtResidence.TabIndex = 19;
            this.txtResidence.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            // 
            // btnSaveStaff
            // 
            this.btnSaveStaff.AutoSize = true;
            this.btnSaveStaff.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSaveStaff.Location = new System.Drawing.Point(248, 682);
            this.btnSaveStaff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSaveStaff.Name = "btnSaveStaff";
            this.btnSaveStaff.Size = new System.Drawing.Size(100, 29);
            this.btnSaveStaff.TabIndex = 23;
            this.btnSaveStaff.Text = "保存";
            this.btnSaveStaff.UseVisualStyleBackColor = false;
            this.btnSaveStaff.Click += new System.EventHandler(this.btnSaveStaff_Click);
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cboGender.Location = new System.Drawing.Point(105, 156);
            this.cboGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(165, 23);
            this.cboGender.TabIndex = 4;
            this.cboGender.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            // 
            // cboDepartment
            // 
            this.cboDepartment.FormattingEnabled = true;
            this.cboDepartment.Location = new System.Drawing.Point(105, 239);
            this.cboDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboDepartment.Name = "cboDepartment";
            this.cboDepartment.Size = new System.Drawing.Size(165, 23);
            this.cboDepartment.TabIndex = 6;
            this.cboDepartment.SelectedIndexChanged += new System.EventHandler(this.GroupList_SelectedIndexChanged);
            this.cboDepartment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            // 
            // lblJobNo
            // 
            this.lblJobNo.AutoSize = true;
            this.lblJobNo.Location = new System.Drawing.Point(343, 120);
            this.lblJobNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblJobNo.Name = "lblJobNo";
            this.lblJobNo.Size = new System.Drawing.Size(37, 15);
            this.lblJobNo.TabIndex = 0;
            this.lblJobNo.Text = "工号";
            // 
            // txtJobNo
            // 
            this.txtJobNo.Location = new System.Drawing.Point(389, 115);
            this.txtJobNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtJobNo.Name = "txtJobNo";
            this.txtJobNo.ReadOnly = true;
            this.txtJobNo.Size = new System.Drawing.Size(165, 25);
            this.txtJobNo.TabIndex = 0;
            this.txtJobNo.TabStop = false;
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Location = new System.Drawing.Point(343, 286);
            this.lblCardNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(37, 15);
            this.lblCardNo.TabIndex = 0;
            this.lblCardNo.Text = "卡号";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(389, 281);
            this.txtCardNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(165, 25);
            this.txtCardNo.TabIndex = 9;
            this.txtCardNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            // 
            // txtDomicile
            // 
            this.txtDomicile.Location = new System.Drawing.Point(105, 492);
            this.txtDomicile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDomicile.Multiline = true;
            this.txtDomicile.Name = "txtDomicile";
            this.txtDomicile.Size = new System.Drawing.Size(449, 49);
            this.txtDomicile.TabIndex = 18;
            this.txtDomicile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(43, 638);
            this.lblLiaison.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(52, 15);
            this.lblLiaison.TabIndex = 0;
            this.lblLiaison.Text = "联络人";
            // 
            // lblFriendsPhone
            // 
            this.lblFriendsPhone.AutoSize = true;
            this.lblFriendsPhone.Location = new System.Drawing.Point(365, 638);
            this.lblFriendsPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFriendsPhone.Name = "lblFriendsPhone";
            this.lblFriendsPhone.Size = new System.Drawing.Size(37, 15);
            this.lblFriendsPhone.TabIndex = 0;
            this.lblFriendsPhone.Text = "电话";
            // 
            // txtFriendPhone
            // 
            this.txtFriendPhone.Location = new System.Drawing.Point(408, 632);
            this.txtFriendPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFriendPhone.Name = "txtFriendPhone";
            this.txtFriendPhone.Size = new System.Drawing.Size(148, 25);
            this.txtFriendPhone.TabIndex = 22;
            this.txtFriendPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            // 
            // lblRelation
            // 
            this.lblRelation.AutoSize = true;
            this.lblRelation.Location = new System.Drawing.Point(228, 638);
            this.lblRelation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRelation.Name = "lblRelation";
            this.lblRelation.Size = new System.Drawing.Size(37, 15);
            this.lblRelation.TabIndex = 0;
            this.lblRelation.Text = "关系";
            // 
            // txtRelation
            // 
            this.txtRelation.Location = new System.Drawing.Point(271, 632);
            this.txtRelation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRelation.Name = "txtRelation";
            this.txtRelation.Size = new System.Drawing.Size(80, 25);
            this.txtRelation.TabIndex = 21;
            this.txtRelation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            // 
            // lblSeniority
            // 
            this.lblSeniority.AutoSize = true;
            this.lblSeniority.Location = new System.Drawing.Point(343, 161);
            this.lblSeniority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeniority.Name = "lblSeniority";
            this.lblSeniority.Size = new System.Drawing.Size(37, 15);
            this.lblSeniority.TabIndex = 0;
            this.lblSeniority.Text = "工龄";
            // 
            // txtSeniority
            // 
            this.txtSeniority.Location = new System.Drawing.Point(389, 156);
            this.txtSeniority.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSeniority.Name = "txtSeniority";
            this.txtSeniority.ReadOnly = true;
            this.txtSeniority.Size = new System.Drawing.Size(165, 25);
            this.txtSeniority.TabIndex = 0;
            this.txtSeniority.TabStop = false;
            // 
            // txtNativePlace
            // 
            this.txtNativePlace.Location = new System.Drawing.Point(105, 365);
            this.txtNativePlace.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNativePlace.Name = "txtNativePlace";
            this.txtNativePlace.Size = new System.Drawing.Size(165, 25);
            this.txtNativePlace.TabIndex = 12;
            this.txtNativePlace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.lblExamineResult);
            this.groupBox1.Controls.Add(this.btnExamine);
            this.groupBox1.Controls.Add(this.txtIDCard);
            this.groupBox1.Controls.Add(this.lblIDCard);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(29, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(527, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblExamineResult
            // 
            this.lblExamineResult.AutoSize = true;
            this.lblExamineResult.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblExamineResult.ForeColor = System.Drawing.Color.Red;
            this.lblExamineResult.Location = new System.Drawing.Point(436, 35);
            this.lblExamineResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExamineResult.Name = "lblExamineResult";
            this.lblExamineResult.Size = new System.Drawing.Size(67, 15);
            this.lblExamineResult.TabIndex = 7;
            this.lblExamineResult.Text = "请验证！";
            // 
            // btnExamine
            // 
            this.btnExamine.AutoSize = true;
            this.btnExamine.Location = new System.Drawing.Point(328, 29);
            this.btnExamine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExamine.Name = "btnExamine";
            this.btnExamine.Size = new System.Drawing.Size(100, 31);
            this.btnExamine.TabIndex = 2;
            this.btnExamine.Text = "验证";
            this.btnExamine.UseVisualStyleBackColor = true;
            this.btnExamine.Click += new System.EventHandler(this.btnExamine_Click);
            // 
            // txtMajor
            // 
            this.txtMajor.Location = new System.Drawing.Point(389, 322);
            this.txtMajor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(165, 25);
            this.txtMajor.TabIndex = 11;
            this.txtMajor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            // 
            // txtNation
            // 
            this.txtNation.Location = new System.Drawing.Point(389, 365);
            this.txtNation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNation.Name = "txtNation";
            this.txtNation.Size = new System.Drawing.Size(165, 25);
            this.txtNation.TabIndex = 13;
            this.txtNation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 454);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "介绍人";
            // 
            // txtIntroducer
            // 
            this.txtIntroducer.Location = new System.Drawing.Point(389, 449);
            this.txtIntroducer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIntroducer.Name = "txtIntroducer";
            this.txtIntroducer.Size = new System.Drawing.Size(165, 25);
            this.txtIntroducer.TabIndex = 17;
            this.txtIntroducer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(343, 245);
            this.lblGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(37, 15);
            this.lblGroup.TabIndex = 0;
            this.lblGroup.Text = "组别";
            // 
            // cboGroup
            // 
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(389, 239);
            this.cboGroup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(165, 23);
            this.cboGroup.TabIndex = 7;
            this.cboGroup.SelectedIndexChanged += new System.EventHandler(this.JobList_SelectedIndexChanged);
            this.cboGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_KeyDown);
            // 
            // FrmAddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(593, 728);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveStaff);
            this.Controls.Add(this.cboMarriage);
            this.Controls.Add(this.cboDepartment);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.cboGroup);
            this.Controls.Add(this.cboJob);
            this.Controls.Add(this.cboEducation);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.dtpEntryDate);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.txtResidence);
            this.Controls.Add(this.lblAddress2);
            this.Controls.Add(this.txtDomicile);
            this.Controls.Add(this.lblAddress1);
            this.Controls.Add(this.lblEntryDate);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.lblNativePlace);
            this.Controls.Add(this.lblEducation);
            this.Controls.Add(this.lblMarriage);
            this.Controls.Add(this.txtIntroducer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRelation);
            this.Controls.Add(this.txtFriendPhone);
            this.Controls.Add(this.lblRelation);
            this.Controls.Add(this.lblNation);
            this.Controls.Add(this.lblFriendsPhone);
            this.Controls.Add(this.txtMobilePhone);
            this.Controls.Add(this.lblMobilePhone);
            this.Controls.Add(this.txtFriend);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.txtSeniority);
            this.Controls.Add(this.lblSeniority);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblDepartment);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtNation);
            this.Controls.Add(this.txtMajor);
            this.Controls.Add(this.txtNativePlace);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.lblCardNo);
            this.Controls.Add(this.txtJobNo);
            this.Controls.Add(this.lblJobNo);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAddStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工入职";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblIDCard;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.TextBox txtFriend;
        private System.Windows.Forms.Label lblNation;
        private System.Windows.Forms.Label lblEntryDate;
        private System.Windows.Forms.Label lblMobilePhone;
        private System.Windows.Forms.TextBox txtMobilePhone;
        private System.Windows.Forms.DateTimePicker dtpEntryDate;
        private System.Windows.Forms.Label lblNativePlace;
        private System.Windows.Forms.Label lblEducation;
        private System.Windows.Forms.ComboBox cboEducation;
        private System.Windows.Forms.Label lblMarriage;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cboMarriage;
        private System.Windows.Forms.ComboBox cboJob;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtResidence;
        private System.Windows.Forms.Button btnSaveStaff;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.ComboBox cboDepartment;
        private System.Windows.Forms.Label lblJobNo;
        private System.Windows.Forms.TextBox txtJobNo;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.TextBox txtDomicile;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.Label lblFriendsPhone;
        private System.Windows.Forms.TextBox txtFriendPhone;
        private System.Windows.Forms.Label lblRelation;
        private System.Windows.Forms.TextBox txtRelation;
        private System.Windows.Forms.Label lblSeniority;
        private System.Windows.Forms.TextBox txtSeniority;
        private System.Windows.Forms.TextBox txtNativePlace;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnExamine;
        private System.Windows.Forms.Label lblExamineResult;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.TextBox txtNation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIntroducer;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.ComboBox cboGroup;
    }
}