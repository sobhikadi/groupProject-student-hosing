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
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbStudent = new System.Windows.Forms.RadioButton();
            this.lblAdminOrStudent = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.lblStudentHouse = new System.Windows.Forms.Label();
            this.lblStudentBuilding = new System.Windows.Forms.Label();
            this.tbStudentEmail = new System.Windows.Forms.TextBox();
            this.lblstudentEmail = new System.Windows.Forms.Label();
            this.lboxUsers = new System.Windows.Forms.ListBox();
            this.btnGetPassword = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.cboxBuildingView = new System.Windows.Forms.ComboBox();
            this.cboxHouseView = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.cBoxHouseUpdate = new System.Windows.Forms.ComboBox();
            this.cboxBuildingUpdate = new System.Windows.Forms.ComboBox();
            this.gboxAddUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(60, 23);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Name:";
            // 
            // tbStudentName
            // 
            this.tbStudentName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStudentName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStudentName.Location = new System.Drawing.Point(127, 38);
            this.tbStudentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(425, 30);
            this.tbStudentName.TabIndex = 1;
            // 
            // gboxAddUser
            // 
            this.gboxAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxAddUser.Controls.Add(this.cboxBuildingAdd);
            this.gboxAddUser.Controls.Add(this.cboxHouseAdd);
            this.gboxAddUser.Controls.Add(this.rbAdmin);
            this.gboxAddUser.Controls.Add(this.rbStudent);
            this.gboxAddUser.Controls.Add(this.lblAdminOrStudent);
            this.gboxAddUser.Controls.Add(this.btnAddUser);
            this.gboxAddUser.Controls.Add(this.lblStudentHouse);
            this.gboxAddUser.Controls.Add(this.lblStudentBuilding);
            this.gboxAddUser.Controls.Add(this.tbStudentEmail);
            this.gboxAddUser.Controls.Add(this.lblstudentEmail);
            this.gboxAddUser.Controls.Add(this.tbStudentName);
            this.gboxAddUser.Controls.Add(this.lblStudentName);
            this.gboxAddUser.Location = new System.Drawing.Point(11, 0);
            this.gboxAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxAddUser.Name = "gboxAddUser";
            this.gboxAddUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxAddUser.Size = new System.Drawing.Size(569, 343);
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
            this.cboxBuildingAdd.Location = new System.Drawing.Point(127, 132);
            this.cboxBuildingAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxBuildingAdd.Name = "cboxBuildingAdd";
            this.cboxBuildingAdd.Size = new System.Drawing.Size(426, 28);
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
            this.cboxHouseAdd.Location = new System.Drawing.Point(126, 184);
            this.cboxHouseAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxHouseAdd.Name = "cboxHouseAdd";
            this.cboxHouseAdd.Size = new System.Drawing.Size(426, 28);
            this.cboxHouseAdd.TabIndex = 15;
            this.cboxHouseAdd.Text = "Select House";
            // 
            // rbAdmin
            // 
            this.rbAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(337, 239);
            this.rbAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(74, 24);
            this.rbAdmin.TabIndex = 14;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbStudent
            // 
            this.rbStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbStudent.AutoSize = true;
            this.rbStudent.Location = new System.Drawing.Point(474, 239);
            this.rbStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(81, 24);
            this.rbStudent.TabIndex = 13;
            this.rbStudent.TabStop = true;
            this.rbStudent.Text = "Student";
            this.rbStudent.UseVisualStyleBackColor = true;
            // 
            // lblAdminOrStudent
            // 
            this.lblAdminOrStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAdminOrStudent.AutoSize = true;
            this.lblAdminOrStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdminOrStudent.Location = new System.Drawing.Point(16, 238);
            this.lblAdminOrStudent.Name = "lblAdminOrStudent";
            this.lblAdminOrStudent.Size = new System.Drawing.Size(191, 23);
            this.lblAdminOrStudent.TabIndex = 11;
            this.lblAdminOrStudent.Text = "Choose Admin/student:";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.Location = new System.Drawing.Point(336, 276);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(215, 38);
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
            this.lblStudentHouse.Location = new System.Drawing.Point(16, 184);
            this.lblStudentHouse.Name = "lblStudentHouse";
            this.lblStudentHouse.Size = new System.Drawing.Size(62, 23);
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
            this.lblStudentBuilding.Name = "lblStudentBuilding";
            this.lblStudentBuilding.Size = new System.Drawing.Size(76, 23);
            this.lblStudentBuilding.TabIndex = 6;
            this.lblStudentBuilding.Text = "Building:";
            // 
            // tbStudentEmail
            // 
            this.tbStudentEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStudentEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStudentEmail.Location = new System.Drawing.Point(127, 86);
            this.tbStudentEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStudentEmail.Name = "tbStudentEmail";
            this.tbStudentEmail.Size = new System.Drawing.Size(425, 30);
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
            this.lblstudentEmail.Name = "lblstudentEmail";
            this.lblstudentEmail.Size = new System.Drawing.Size(55, 23);
            this.lblstudentEmail.TabIndex = 2;
            this.lblstudentEmail.Text = "Email:";
            // 
            // lboxUsers
            // 
            this.lboxUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lboxUsers.FormattingEnabled = true;
            this.lboxUsers.ItemHeight = 20;
            this.lboxUsers.Location = new System.Drawing.Point(7, 132);
            this.lboxUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lboxUsers.Name = "lboxUsers";
            this.lboxUsers.Size = new System.Drawing.Size(294, 544);
            this.lboxUsers.TabIndex = 0;
            // 
            // btnGetPassword
            // 
            this.btnGetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGetPassword.Location = new System.Drawing.Point(332, 585);
            this.btnGetPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetPassword.Name = "btnGetPassword";
            this.btnGetPassword.Size = new System.Drawing.Size(248, 38);
            this.btnGetPassword.TabIndex = 11;
            this.btnGetPassword.Text = "Login Information";
            this.btnGetPassword.UseVisualStyleBackColor = true;
            // 
            // lblRemoveUser
            // 
            this.lblRemoveUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRemoveUser.AutoSize = true;
            this.lblRemoveUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRemoveUser.Location = new System.Drawing.Point(28, 657);
            this.lblRemoveUser.Name = "lblRemoveUser";
            this.lblRemoveUser.Size = new System.Drawing.Size(179, 23);
            this.lblRemoveUser.TabIndex = 14;
            this.lblRemoveUser.Text = "Select user to remove:";
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemoveUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveUser.Location = new System.Drawing.Point(332, 649);
            this.btnRemoveUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(248, 38);
            this.btnRemoveUser.TabIndex = 12;
            this.btnRemoveUser.Text = "Remove user";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // cboxBuildingView
            // 
            this.cboxBuildingView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxBuildingView.FormattingEnabled = true;
            this.cboxBuildingView.Location = new System.Drawing.Point(7, 38);
            this.cboxBuildingView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxBuildingView.Name = "cboxBuildingView";
            this.cboxBuildingView.Size = new System.Drawing.Size(294, 28);
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
            this.cboxHouseView.Location = new System.Drawing.Point(7, 86);
            this.cboxHouseView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboxHouseView.Name = "cboxHouseView";
            this.cboxHouseView.Size = new System.Drawing.Size(294, 28);
            this.cboxHouseView.TabIndex = 18;
            this.cboxHouseView.Text = "Select House";
            this.cboxHouseView.SelectedIndexChanged += new System.EventHandler(this.cboxHouseView_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxBuildingView);
            this.groupBox1.Controls.Add(this.btnGetPassword);
            this.groupBox1.Controls.Add(this.btnRemoveUser);
            this.groupBox1.Controls.Add(this.cboxHouseView);
            this.groupBox1.Controls.Add(this.lboxUsers);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(591, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(312, 698);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Students";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnUpdateInfo);
            this.groupBox2.Controls.Add(this.cBoxHouseUpdate);
            this.groupBox2.Controls.Add(this.cboxBuildingUpdate);
            this.groupBox2.Location = new System.Drawing.Point(14, 457);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 267);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Student House";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "House:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 28);
            this.label1.TabIndex = 21;
            this.label1.Text = "Building:";
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateInfo.Location = new System.Drawing.Point(308, 172);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(269, 48);
            this.btnUpdateInfo.TabIndex = 20;
            this.btnUpdateInfo.Text = "Update Info";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // cBoxHouseUpdate
            // 
            this.cBoxHouseUpdate.FormattingEnabled = true;
            this.cBoxHouseUpdate.Location = new System.Drawing.Point(159, 102);
            this.cBoxHouseUpdate.Name = "cBoxHouseUpdate";
            this.cBoxHouseUpdate.Size = new System.Drawing.Size(418, 33);
            this.cBoxHouseUpdate.TabIndex = 18;
            this.cBoxHouseUpdate.Text = "Select House";
            // 
            // cboxBuildingUpdate
            // 
            this.cboxBuildingUpdate.FormattingEnabled = true;
            this.cboxBuildingUpdate.Location = new System.Drawing.Point(159, 49);
            this.cboxBuildingUpdate.Name = "cboxBuildingUpdate";
            this.cboxBuildingUpdate.Size = new System.Drawing.Size(418, 33);
            this.cboxBuildingUpdate.TabIndex = 17;
            this.cboxBuildingUpdate.Text = "Select Building";
            this.cboxBuildingUpdate.SelectedIndexChanged += new System.EventHandler(this.cboxBuildingUpdate_SelectedIndexChanged);
            // 
            // UserAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 698);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserAdministration";
            this.Text = "UserAdministration";
            this.SizeChanged += new System.EventHandler(this.UserAdministration_SizeChanged);
            this.gboxAddUser.ResumeLayout(false);
            this.gboxAddUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private Button btnGetPassword;
        private RadioButton rbAdmin;
        private RadioButton rbStudent;
        private Label lblAdminOrStudent;
        private Button btnRemoveUser;
        private ComboBox cboxBuildingAdd;
        private ComboBox cboxHouseAdd;
        private ComboBox cboxBuildingView;
        private ComboBox cboxHouseView;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label1;
        private Button btnUpdateInfo;
        private ComboBox cBoxHouseUpdate;
        private ComboBox cboxBuildingUpdate;
    }
}