namespace StudentHousingManagementForms
{
    partial class UserAdministration
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
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStudentName = new System.Windows.Forms.Label();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.gboxAddUser = new System.Windows.Forms.GroupBox();
            this.cboxBuildingAdd = new System.Windows.Forms.ComboBox();
            this.cboxHouseAdd = new System.Windows.Forms.ComboBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblStudentHouse = new System.Windows.Forms.Label();
            this.lblStudentBuilding = new System.Windows.Forms.Label();
            this.tbStudentEmail = new System.Windows.Forms.TextBox();
            this.lblstudentEmail = new System.Windows.Forms.Label();
            this.lboxUsers = new System.Windows.Forms.ListBox();
            this.cboxBuildingView = new System.Windows.Forms.ComboBox();
            this.cboxHouseView = new System.Windows.Forms.ComboBox();
            this.gboxStudents = new System.Windows.Forms.GroupBox();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbNoOfResidents = new System.Windows.Forms.TextBox();
            this.lblNoOfResidents = new System.Windows.Forms.Label();
            this.gboxUpdateInfo = new System.Windows.Forms.GroupBox();
            this.lblUpdateHouse = new System.Windows.Forms.Label();
            this.lblUpdateBuilding = new System.Windows.Forms.Label();
            this.btnUpdateHouse = new System.Windows.Forms.Button();
            this.cboxHouseUpdate = new System.Windows.Forms.ComboBox();
            this.cboxBuildingUpdate = new System.Windows.Forms.ComboBox();
            this.gboxAddAdmin = new System.Windows.Forms.GroupBox();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.tbAdminEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAdminName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gboxAddUser.SuspendLayout();
            this.gboxStudents.SuspendLayout();
            this.gboxUpdateInfo.SuspendLayout();
            this.gboxAddAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentName.Location = new System.Drawing.Point(16, 42);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(68, 28);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Name:";
            // 
            // tbStudentName
            // 
            this.tbStudentName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStudentName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStudentName.Location = new System.Drawing.Point(128, 38);
            this.tbStudentName.Margin = new System.Windows.Forms.Padding(2);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(540, 34);
            this.tbStudentName.TabIndex = 1;
            // 
            // gboxAddUser
            // 
            this.gboxAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxAddUser.Controls.Add(this.cboxBuildingAdd);
            this.gboxAddUser.Controls.Add(this.cboxHouseAdd);
            this.gboxAddUser.Controls.Add(this.btnAddUser);
            this.gboxAddUser.Controls.Add(this.lblStudentHouse);
            this.gboxAddUser.Controls.Add(this.lblStudentBuilding);
            this.gboxAddUser.Controls.Add(this.tbStudentEmail);
            this.gboxAddUser.Controls.Add(this.lblstudentEmail);
            this.gboxAddUser.Controls.Add(this.tbStudentName);
            this.gboxAddUser.Controls.Add(this.lblStudentName);
            this.gboxAddUser.Location = new System.Drawing.Point(11, 0);
            this.gboxAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.gboxAddUser.Name = "gboxAddUser";
            this.gboxAddUser.Padding = new System.Windows.Forms.Padding(2);
            this.gboxAddUser.Size = new System.Drawing.Size(684, 281);
            this.gboxAddUser.TabIndex = 2;
            this.gboxAddUser.TabStop = false;
            this.gboxAddUser.Text = "Add Student";
            // 
            // cboxBuildingAdd
            // 
            this.cboxBuildingAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxBuildingAdd.FormattingEnabled = true;
            this.cboxBuildingAdd.Location = new System.Drawing.Point(128, 132);
            this.cboxBuildingAdd.Margin = new System.Windows.Forms.Padding(2);
            this.cboxBuildingAdd.Name = "cboxBuildingAdd";
            this.cboxBuildingAdd.Size = new System.Drawing.Size(540, 33);
            this.cboxBuildingAdd.TabIndex = 16;
            this.cboxBuildingAdd.Text = "Select Building";
            this.cboxBuildingAdd.SelectedIndexChanged += new System.EventHandler(this.cBoxBuildingAdd_SelectedIndexChanged);
            // 
            // cboxHouseAdd
            // 
            this.cboxHouseAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxHouseAdd.FormattingEnabled = true;
            this.cboxHouseAdd.Location = new System.Drawing.Point(126, 182);
            this.cboxHouseAdd.Margin = new System.Windows.Forms.Padding(2);
            this.cboxHouseAdd.Name = "cboxHouseAdd";
            this.cboxHouseAdd.Size = new System.Drawing.Size(540, 33);
            this.cboxHouseAdd.TabIndex = 15;
            this.cboxHouseAdd.Text = "Select House";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.Location = new System.Drawing.Point(452, 219);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(214, 46);
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblStudentHouse
            // 
            this.lblStudentHouse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentHouse.AutoSize = true;
            this.lblStudentHouse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentHouse.Location = new System.Drawing.Point(16, 182);
            this.lblStudentHouse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentHouse.Name = "lblStudentHouse";
            this.lblStudentHouse.Size = new System.Drawing.Size(71, 28);
            this.lblStudentHouse.TabIndex = 8;
            this.lblStudentHouse.Text = "House:";
            // 
            // lblStudentBuilding
            // 
            this.lblStudentBuilding.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentBuilding.AutoSize = true;
            this.lblStudentBuilding.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentBuilding.Location = new System.Drawing.Point(16, 132);
            this.lblStudentBuilding.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentBuilding.Name = "lblStudentBuilding";
            this.lblStudentBuilding.Size = new System.Drawing.Size(88, 28);
            this.lblStudentBuilding.TabIndex = 6;
            this.lblStudentBuilding.Text = "Building:";
            // 
            // tbStudentEmail
            // 
            this.tbStudentEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStudentEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStudentEmail.Location = new System.Drawing.Point(128, 88);
            this.tbStudentEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbStudentEmail.Name = "tbStudentEmail";
            this.tbStudentEmail.Size = new System.Drawing.Size(540, 34);
            this.tbStudentEmail.TabIndex = 3;
            // 
            // lblstudentEmail
            // 
            this.lblstudentEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblstudentEmail.AutoSize = true;
            this.lblstudentEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblstudentEmail.Location = new System.Drawing.Point(16, 88);
            this.lblstudentEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblstudentEmail.Name = "lblstudentEmail";
            this.lblstudentEmail.Size = new System.Drawing.Size(63, 28);
            this.lblstudentEmail.TabIndex = 2;
            this.lblstudentEmail.Text = "Email:";
            // 
            // lboxUsers
            // 
            this.lboxUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxUsers.FormattingEnabled = true;
            this.lboxUsers.ItemHeight = 25;
            this.lboxUsers.Location = new System.Drawing.Point(8, 182);
            this.lboxUsers.Margin = new System.Windows.Forms.Padding(2);
            this.lboxUsers.Name = "lboxUsers";
            this.lboxUsers.Size = new System.Drawing.Size(434, 529);
            this.lboxUsers.TabIndex = 0;
            // 
            // cboxBuildingView
            // 
            this.cboxBuildingView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxBuildingView.FormattingEnabled = true;
            this.cboxBuildingView.Location = new System.Drawing.Point(8, 38);
            this.cboxBuildingView.Margin = new System.Windows.Forms.Padding(2);
            this.cboxBuildingView.Name = "cboxBuildingView";
            this.cboxBuildingView.Size = new System.Drawing.Size(434, 33);
            this.cboxBuildingView.TabIndex = 17;
            this.cboxBuildingView.Text = "Select Building";
            this.cboxBuildingView.SelectedIndexChanged += new System.EventHandler(this.cboxBuildingView_SelectedIndexChanged);
            // 
            // cboxHouseView
            // 
            this.cboxHouseView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxHouseView.FormattingEnabled = true;
            this.cboxHouseView.Location = new System.Drawing.Point(8, 88);
            this.cboxHouseView.Margin = new System.Windows.Forms.Padding(2);
            this.cboxHouseView.Name = "cboxHouseView";
            this.cboxHouseView.Size = new System.Drawing.Size(434, 33);
            this.cboxHouseView.TabIndex = 18;
            this.cboxHouseView.Text = "Select House";
            this.cboxHouseView.SelectedIndexChanged += new System.EventHandler(this.cboxHouseView_SelectedIndexChanged);
            // 
            // gboxStudents
            // 
            this.gboxStudents.Controls.Add(this.btnRemoveUser);
            this.gboxStudents.Controls.Add(this.button1);
            this.gboxStudents.Controls.Add(this.tbNoOfResidents);
            this.gboxStudents.Controls.Add(this.lblNoOfResidents);
            this.gboxStudents.Controls.Add(this.cboxBuildingView);
            this.gboxStudents.Controls.Add(this.cboxHouseView);
            this.gboxStudents.Controls.Add(this.lboxUsers);
            this.gboxStudents.Dock = System.Windows.Forms.DockStyle.Right;
            this.gboxStudents.Location = new System.Drawing.Point(700, 0);
            this.gboxStudents.Margin = new System.Windows.Forms.Padding(2);
            this.gboxStudents.Name = "gboxStudents";
            this.gboxStudents.Padding = new System.Windows.Forms.Padding(2);
            this.gboxStudents.Size = new System.Drawing.Size(451, 932);
            this.gboxStudents.TabIndex = 19;
            this.gboxStudents.TabStop = false;
            this.gboxStudents.Text = "Students";
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveUser.Location = new System.Drawing.Point(235, 731);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(204, 57);
            this.btnRemoveUser.TabIndex = 22;
            this.btnRemoveUser.Text = "Remove User";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(8, 731);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 57);
            this.button1.TabIndex = 21;
            this.button1.Text = "Login Information";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbNoOfResidents
            // 
            this.tbNoOfResidents.Location = new System.Drawing.Point(151, 132);
            this.tbNoOfResidents.Margin = new System.Windows.Forms.Padding(2);
            this.tbNoOfResidents.Name = "tbNoOfResidents";
            this.tbNoOfResidents.ReadOnly = true;
            this.tbNoOfResidents.Size = new System.Drawing.Size(150, 31);
            this.tbNoOfResidents.TabIndex = 20;
            // 
            // lblNoOfResidents
            // 
            this.lblNoOfResidents.AutoSize = true;
            this.lblNoOfResidents.Location = new System.Drawing.Point(8, 132);
            this.lblNoOfResidents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoOfResidents.Name = "lblNoOfResidents";
            this.lblNoOfResidents.Size = new System.Drawing.Size(126, 25);
            this.lblNoOfResidents.TabIndex = 19;
            this.lblNoOfResidents.Text = "No Of Rooms:";
            // 
            // gboxUpdateInfo
            // 
            this.gboxUpdateInfo.Controls.Add(this.lblUpdateHouse);
            this.gboxUpdateInfo.Controls.Add(this.lblUpdateBuilding);
            this.gboxUpdateInfo.Controls.Add(this.btnUpdateHouse);
            this.gboxUpdateInfo.Controls.Add(this.cboxHouseUpdate);
            this.gboxUpdateInfo.Controls.Add(this.cboxBuildingUpdate);
            this.gboxUpdateInfo.Location = new System.Drawing.Point(12, 285);
            this.gboxUpdateInfo.Margin = new System.Windows.Forms.Padding(2);
            this.gboxUpdateInfo.Name = "gboxUpdateInfo";
            this.gboxUpdateInfo.Padding = new System.Windows.Forms.Padding(2);
            this.gboxUpdateInfo.Size = new System.Drawing.Size(684, 210);
            this.gboxUpdateInfo.TabIndex = 20;
            this.gboxUpdateInfo.TabStop = false;
            this.gboxUpdateInfo.Text = "Update Student House";
            // 
            // lblUpdateHouse
            // 
            this.lblUpdateHouse.AutoSize = true;
            this.lblUpdateHouse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpdateHouse.Location = new System.Drawing.Point(18, 102);
            this.lblUpdateHouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateHouse.Name = "lblUpdateHouse";
            this.lblUpdateHouse.Size = new System.Drawing.Size(71, 28);
            this.lblUpdateHouse.TabIndex = 22;
            this.lblUpdateHouse.Text = "House:";
            // 
            // lblUpdateBuilding
            // 
            this.lblUpdateBuilding.AutoSize = true;
            this.lblUpdateBuilding.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUpdateBuilding.Location = new System.Drawing.Point(18, 48);
            this.lblUpdateBuilding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateBuilding.Name = "lblUpdateBuilding";
            this.lblUpdateBuilding.Size = new System.Drawing.Size(88, 28);
            this.lblUpdateBuilding.TabIndex = 21;
            this.lblUpdateBuilding.Text = "Building:";
            // 
            // btnUpdateHouse
            // 
            this.btnUpdateHouse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateHouse.Location = new System.Drawing.Point(275, 149);
            this.btnUpdateHouse.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateHouse.Name = "btnUpdateHouse";
            this.btnUpdateHouse.Size = new System.Drawing.Size(269, 48);
            this.btnUpdateHouse.TabIndex = 20;
            this.btnUpdateHouse.Text = "Update House";
            this.btnUpdateHouse.UseVisualStyleBackColor = true;
            this.btnUpdateHouse.Click += new System.EventHandler(this.btnUpdateHouse_Click);
            // 
            // cboxHouseUpdate
            // 
            this.cboxHouseUpdate.FormattingEnabled = true;
            this.cboxHouseUpdate.Location = new System.Drawing.Point(126, 100);
            this.cboxHouseUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.cboxHouseUpdate.Name = "cboxHouseUpdate";
            this.cboxHouseUpdate.Size = new System.Drawing.Size(418, 33);
            this.cboxHouseUpdate.TabIndex = 18;
            this.cboxHouseUpdate.Text = "Select House";
            // 
            // cboxBuildingUpdate
            // 
            this.cboxBuildingUpdate.FormattingEnabled = true;
            this.cboxBuildingUpdate.Location = new System.Drawing.Point(128, 48);
            this.cboxBuildingUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.cboxBuildingUpdate.Name = "cboxBuildingUpdate";
            this.cboxBuildingUpdate.Size = new System.Drawing.Size(418, 33);
            this.cboxBuildingUpdate.TabIndex = 17;
            this.cboxBuildingUpdate.Text = "Select Building";
            this.cboxBuildingUpdate.SelectedIndexChanged += new System.EventHandler(this.cboxBuildingUpdate_SelectedIndexChanged);
            // 
            // gboxAddAdmin
            // 
            this.gboxAddAdmin.Controls.Add(this.btnAddAdmin);
            this.gboxAddAdmin.Controls.Add(this.tbAdminEmail);
            this.gboxAddAdmin.Controls.Add(this.label1);
            this.gboxAddAdmin.Controls.Add(this.tbAdminName);
            this.gboxAddAdmin.Controls.Add(this.label2);
            this.gboxAddAdmin.Location = new System.Drawing.Point(12, 500);
            this.gboxAddAdmin.Name = "gboxAddAdmin";
            this.gboxAddAdmin.Size = new System.Drawing.Size(683, 213);
            this.gboxAddAdmin.TabIndex = 21;
            this.gboxAddAdmin.TabStop = false;
            this.gboxAddAdmin.Text = "Add Admin";
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddAdmin.Location = new System.Drawing.Point(453, 121);
            this.btnAddAdmin.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.Size = new System.Drawing.Size(214, 46);
            this.btnAddAdmin.TabIndex = 11;
            this.btnAddAdmin.Text = "Add Admin";
            this.btnAddAdmin.UseVisualStyleBackColor = true;
            this.btnAddAdmin.Click += new System.EventHandler(this.btnAddAdmin_Click);
            // 
            // tbAdminEmail
            // 
            this.tbAdminEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdminEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAdminEmail.Location = new System.Drawing.Point(127, 83);
            this.tbAdminEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbAdminEmail.Name = "tbAdminEmail";
            this.tbAdminEmail.Size = new System.Drawing.Size(540, 34);
            this.tbAdminEmail.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 83);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email:";
            // 
            // tbAdminName
            // 
            this.tbAdminName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAdminName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAdminName.Location = new System.Drawing.Point(127, 33);
            this.tbAdminName.Margin = new System.Windows.Forms.Padding(2);
            this.tbAdminName.Name = "tbAdminName";
            this.tbAdminName.Size = new System.Drawing.Size(540, 34);
            this.tbAdminName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // UserAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1151, 932);
            this.Controls.Add(this.gboxAddAdmin);
            this.Controls.Add(this.gboxUpdateInfo);
            this.Controls.Add(this.gboxStudents);
            this.Controls.Add(this.gboxAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserAdministration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserAdministration";
            this.gboxAddUser.ResumeLayout(false);
            this.gboxAddUser.PerformLayout();
            this.gboxStudents.ResumeLayout(false);
            this.gboxStudents.PerformLayout();
            this.gboxUpdateInfo.ResumeLayout(false);
            this.gboxUpdateInfo.PerformLayout();
            this.gboxAddAdmin.ResumeLayout(false);
            this.gboxAddAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblStudentName;
        private TextBox tbStudentName;
        private GroupBox gboxAddUser;
        private ListBox lboxUsers;
        private Button btnAddUser;
        private Label lblStudentHouse;
        private Label lblStudentBuilding;
        private TextBox tbStudentEmail;
        private Label lblstudentEmail;
        private ComboBox cboxBuildingAdd;
        private ComboBox cboxHouseAdd;
        private ComboBox cboxBuildingView;
        private ComboBox cboxHouseView;
        private GroupBox gboxStudents;
        private GroupBox gboxUpdateInfo;
        private Label lblUpdateHouse;
        private Label lblUpdateBuilding;
        private Button btnUpdateHouse;
        private ComboBox cboxHouseUpdate;
        private ComboBox cboxBuildingUpdate;
        private TextBox tbNoOfResidents;
        private Label lblNoOfResidents;
        private GroupBox gboxAddAdmin;
        private Button btnAddAdmin;
        private TextBox tbAdminEmail;
        private Label label1;
        private TextBox tbAdminName;
        private Label label2;
        private Button btnRemoveUser;
        private Button button1;
    }
}