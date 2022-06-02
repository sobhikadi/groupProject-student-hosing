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
            this.tbStudentAddress = new System.Windows.Forms.TextBox();
            this.lblStudentAddress = new System.Windows.Forms.Label();
            this.tbStudentEmail = new System.Windows.Forms.TextBox();
            this.lblstudentEmail = new System.Windows.Forms.Label();
            this.lboxUsers = new System.Windows.Forms.ListBox();
            this.lblGetPassword = new System.Windows.Forms.Label();
            this.tbStudentPassword = new System.Windows.Forms.TextBox();
            this.btnGetPassword = new System.Windows.Forms.Button();
            this.lblRemoveUser = new System.Windows.Forms.Label();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.cboxBuildingView = new System.Windows.Forms.ComboBox();
            this.cboxHouseView = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gboxAddUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentName.Location = new System.Drawing.Point(14, 31);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(48, 19);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Name:";
            // 
            // tbStudentName
            // 
            this.tbStudentName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStudentName.Location = new System.Drawing.Point(111, 29);
            this.tbStudentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(372, 25);
            this.tbStudentName.TabIndex = 1;
            // 
            // gboxAddUser
            // 
            this.gboxAddUser.Controls.Add(this.cboxBuildingAdd);
            this.gboxAddUser.Controls.Add(this.cboxHouseAdd);
            this.gboxAddUser.Controls.Add(this.rbAdmin);
            this.gboxAddUser.Controls.Add(this.rbStudent);
            this.gboxAddUser.Controls.Add(this.lblAdminOrStudent);
            this.gboxAddUser.Controls.Add(this.btnAddUser);
            this.gboxAddUser.Controls.Add(this.lblStudentHouse);
            this.gboxAddUser.Controls.Add(this.lblStudentBuilding);
            this.gboxAddUser.Controls.Add(this.tbStudentAddress);
            this.gboxAddUser.Controls.Add(this.lblStudentAddress);
            this.gboxAddUser.Controls.Add(this.tbStudentEmail);
            this.gboxAddUser.Controls.Add(this.lblstudentEmail);
            this.gboxAddUser.Controls.Add(this.tbStudentName);
            this.gboxAddUser.Controls.Add(this.lblStudentName);
            this.gboxAddUser.Location = new System.Drawing.Point(10, 9);
            this.gboxAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxAddUser.Name = "gboxAddUser";
            this.gboxAddUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxAddUser.Size = new System.Drawing.Size(498, 278);
            this.gboxAddUser.TabIndex = 2;
            this.gboxAddUser.TabStop = false;
            this.gboxAddUser.Text = "Add Student";
            // 
            // cboxBuildingAdd
            // 
            this.cboxBuildingAdd.FormattingEnabled = true;
            this.cboxBuildingAdd.Location = new System.Drawing.Point(111, 137);
            this.cboxBuildingAdd.Name = "cboxBuildingAdd";
            this.cboxBuildingAdd.Size = new System.Drawing.Size(373, 23);
            this.cboxBuildingAdd.TabIndex = 16;
            this.cboxBuildingAdd.Text = "Select Building";
            this.cboxBuildingAdd.SelectedIndexChanged += new System.EventHandler(this.cBoxBuildingAdd_SelectedIndexChanged);
            // 
            // cboxHouseAdd
            // 
            this.cboxHouseAdd.FormattingEnabled = true;
            this.cboxHouseAdd.Location = new System.Drawing.Point(111, 173);
            this.cboxHouseAdd.Name = "cboxHouseAdd";
            this.cboxHouseAdd.Size = new System.Drawing.Size(373, 23);
            this.cboxHouseAdd.TabIndex = 15;
            this.cboxHouseAdd.Text = "Select House";
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(295, 208);
            this.rbAdmin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(61, 19);
            this.rbAdmin.TabIndex = 14;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbStudent
            // 
            this.rbStudent.AutoSize = true;
            this.rbStudent.Location = new System.Drawing.Point(412, 208);
            this.rbStudent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(66, 19);
            this.rbStudent.TabIndex = 13;
            this.rbStudent.TabStop = true;
            this.rbStudent.Text = "Student";
            this.rbStudent.UseVisualStyleBackColor = true;
            // 
            // lblAdminOrStudent
            // 
            this.lblAdminOrStudent.AutoSize = true;
            this.lblAdminOrStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdminOrStudent.Location = new System.Drawing.Point(14, 209);
            this.lblAdminOrStudent.Name = "lblAdminOrStudent";
            this.lblAdminOrStudent.Size = new System.Drawing.Size(154, 19);
            this.lblAdminOrStudent.TabIndex = 11;
            this.lblAdminOrStudent.Text = "Choose Admin/student:";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.Location = new System.Drawing.Point(295, 236);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(188, 29);
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // lblStudentHouse
            // 
            this.lblStudentHouse.AutoSize = true;
            this.lblStudentHouse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentHouse.Location = new System.Drawing.Point(14, 173);
            this.lblStudentHouse.Name = "lblStudentHouse";
            this.lblStudentHouse.Size = new System.Drawing.Size(51, 19);
            this.lblStudentHouse.TabIndex = 8;
            this.lblStudentHouse.Text = "House:";
            // 
            // lblStudentBuilding
            // 
            this.lblStudentBuilding.AutoSize = true;
            this.lblStudentBuilding.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentBuilding.Location = new System.Drawing.Point(14, 138);
            this.lblStudentBuilding.Name = "lblStudentBuilding";
            this.lblStudentBuilding.Size = new System.Drawing.Size(61, 19);
            this.lblStudentBuilding.TabIndex = 6;
            this.lblStudentBuilding.Text = "Building:";
            // 
            // tbStudentAddress
            // 
            this.tbStudentAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStudentAddress.Location = new System.Drawing.Point(111, 99);
            this.tbStudentAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStudentAddress.Name = "tbStudentAddress";
            this.tbStudentAddress.Size = new System.Drawing.Size(372, 25);
            this.tbStudentAddress.TabIndex = 5;
            // 
            // lblStudentAddress
            // 
            this.lblStudentAddress.AutoSize = true;
            this.lblStudentAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentAddress.Location = new System.Drawing.Point(14, 101);
            this.lblStudentAddress.Name = "lblStudentAddress";
            this.lblStudentAddress.Size = new System.Drawing.Size(61, 19);
            this.lblStudentAddress.TabIndex = 4;
            this.lblStudentAddress.Text = "Address:";
            // 
            // tbStudentEmail
            // 
            this.tbStudentEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStudentEmail.Location = new System.Drawing.Point(111, 64);
            this.tbStudentEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStudentEmail.Name = "tbStudentEmail";
            this.tbStudentEmail.Size = new System.Drawing.Size(372, 25);
            this.tbStudentEmail.TabIndex = 3;
            // 
            // lblstudentEmail
            // 
            this.lblstudentEmail.AutoSize = true;
            this.lblstudentEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblstudentEmail.Location = new System.Drawing.Point(14, 66);
            this.lblstudentEmail.Name = "lblstudentEmail";
            this.lblstudentEmail.Size = new System.Drawing.Size(44, 19);
            this.lblstudentEmail.TabIndex = 2;
            this.lblstudentEmail.Text = "Email:";
            // 
            // lboxUsers
            // 
            this.lboxUsers.FormattingEnabled = true;
            this.lboxUsers.ItemHeight = 15;
            this.lboxUsers.Location = new System.Drawing.Point(6, 99);
            this.lboxUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lboxUsers.Name = "lboxUsers";
            this.lboxUsers.Size = new System.Drawing.Size(258, 319);
            this.lboxUsers.TabIndex = 0;
            // 
            // lblGetPassword
            // 
            this.lblGetPassword.AutoSize = true;
            this.lblGetPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGetPassword.Location = new System.Drawing.Point(10, 306);
            this.lblGetPassword.Name = "lblGetPassword";
            this.lblGetPassword.Size = new System.Drawing.Size(201, 19);
            this.lblGetPassword.TabIndex = 11;
            this.lblGetPassword.Text = "Select user to get it\'s password:";
            // 
            // tbStudentPassword
            // 
            this.tbStudentPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStudentPassword.Location = new System.Drawing.Point(234, 304);
            this.tbStudentPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStudentPassword.Name = "tbStudentPassword";
            this.tbStudentPassword.ReadOnly = true;
            this.tbStudentPassword.Size = new System.Drawing.Size(260, 25);
            this.tbStudentPassword.TabIndex = 11;
            // 
            // btnGetPassword
            // 
            this.btnGetPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGetPassword.Location = new System.Drawing.Point(276, 340);
            this.btnGetPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetPassword.Name = "btnGetPassword";
            this.btnGetPassword.Size = new System.Drawing.Size(217, 29);
            this.btnGetPassword.TabIndex = 11;
            this.btnGetPassword.Text = "Get student password";
            this.btnGetPassword.UseVisualStyleBackColor = true;
            // 
            // lblRemoveUser
            // 
            this.lblRemoveUser.AutoSize = true;
            this.lblRemoveUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRemoveUser.Location = new System.Drawing.Point(10, 395);
            this.lblRemoveUser.Name = "lblRemoveUser";
            this.lblRemoveUser.Size = new System.Drawing.Size(144, 19);
            this.lblRemoveUser.TabIndex = 14;
            this.lblRemoveUser.Text = "Select user to remove:";
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveUser.Location = new System.Drawing.Point(276, 388);
            this.btnRemoveUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(217, 29);
            this.btnRemoveUser.TabIndex = 12;
            this.btnRemoveUser.Text = "Remove user";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // cboxBuildingView
            // 
            this.cboxBuildingView.FormattingEnabled = true;
            this.cboxBuildingView.Location = new System.Drawing.Point(6, 29);
            this.cboxBuildingView.Name = "cboxBuildingView";
            this.cboxBuildingView.Size = new System.Drawing.Size(258, 23);
            this.cboxBuildingView.TabIndex = 17;
            this.cboxBuildingView.Text = "Select Building";
            this.cboxBuildingView.SelectedIndexChanged += new System.EventHandler(this.cboxBuildingView_SelectedIndexChanged);
            // 
            // cboxHouseView
            // 
            this.cboxHouseView.FormattingEnabled = true;
            this.cboxHouseView.Location = new System.Drawing.Point(6, 64);
            this.cboxHouseView.Name = "cboxHouseView";
            this.cboxHouseView.Size = new System.Drawing.Size(258, 23);
            this.cboxHouseView.TabIndex = 18;
            this.cboxHouseView.Text = "Select House";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxBuildingView);
            this.groupBox1.Controls.Add(this.cboxHouseView);
            this.groupBox1.Controls.Add(this.lboxUsers);
            this.groupBox1.Location = new System.Drawing.Point(514, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 478);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Students";
            // 
            // UserAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 524);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.lblRemoveUser);
            this.Controls.Add(this.btnGetPassword);
            this.Controls.Add(this.tbStudentPassword);
            this.Controls.Add(this.lblGetPassword);
            this.Controls.Add(this.gboxAddUser);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserAdministration";
            this.Text = "UserAdministration";
            this.gboxAddUser.ResumeLayout(false);
            this.gboxAddUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStudentName;
        private TextBox tbStudentName;
        private GroupBox gboxAddUser;
        private ListBox lboxUsers;
        private Button btnAddUser;
        private Label lblStudentHouse;
        private Label lblStudentBuilding;
        private TextBox tbStudentAddress;
        private Label lblStudentAddress;
        private TextBox tbStudentEmail;
        private Label lblstudentEmail;
        private Label lblGetPassword;
        private TextBox tbStudentPassword;
        private Button btnGetPassword;
        private RadioButton rbAdmin;
        private RadioButton rbStudent;
        private Label lblAdminOrStudent;
        private Label lblRemoveUser;
        private Button btnRemoveUser;
        private ComboBox cboxBuildingAdd;
        private ComboBox cboxHouseAdd;
        private ComboBox cboxBuildingView;
        private ComboBox cboxHouseView;
        private GroupBox groupBox1;
    }
}