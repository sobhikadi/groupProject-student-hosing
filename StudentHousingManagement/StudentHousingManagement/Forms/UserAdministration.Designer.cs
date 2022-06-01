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
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbStudent = new System.Windows.Forms.RadioButton();
            this.lblAdminOrStudent = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.tbStudentRoom = new System.Windows.Forms.TextBox();
            this.lblStudentHouse = new System.Windows.Forms.Label();
            this.tbStudentBuilding = new System.Windows.Forms.TextBox();
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
            this.gboxAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentName.Location = new System.Drawing.Point(20, 52);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(68, 28);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Name:";
            // 
            // tbStudentName
            // 
            this.tbStudentName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStudentName.Location = new System.Drawing.Point(159, 49);
            this.tbStudentName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(530, 34);
            this.tbStudentName.TabIndex = 1;
            // 
            // gboxAddUser
            // 
            this.gboxAddUser.Controls.Add(this.rbAdmin);
            this.gboxAddUser.Controls.Add(this.rbStudent);
            this.gboxAddUser.Controls.Add(this.lblAdminOrStudent);
            this.gboxAddUser.Controls.Add(this.btnAddUser);
            this.gboxAddUser.Controls.Add(this.tbStudentRoom);
            this.gboxAddUser.Controls.Add(this.lblStudentHouse);
            this.gboxAddUser.Controls.Add(this.tbStudentBuilding);
            this.gboxAddUser.Controls.Add(this.lblStudentBuilding);
            this.gboxAddUser.Controls.Add(this.tbStudentAddress);
            this.gboxAddUser.Controls.Add(this.lblStudentAddress);
            this.gboxAddUser.Controls.Add(this.tbStudentEmail);
            this.gboxAddUser.Controls.Add(this.lblstudentEmail);
            this.gboxAddUser.Controls.Add(this.tbStudentName);
            this.gboxAddUser.Controls.Add(this.lblStudentName);
            this.gboxAddUser.Location = new System.Drawing.Point(15, 15);
            this.gboxAddUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxAddUser.Name = "gboxAddUser";
            this.gboxAddUser.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gboxAddUser.Size = new System.Drawing.Size(711, 464);
            this.gboxAddUser.TabIndex = 2;
            this.gboxAddUser.TabStop = false;
            this.gboxAddUser.Text = "Add Student";
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(422, 346);
            this.rbAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(90, 29);
            this.rbAdmin.TabIndex = 14;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbStudent
            // 
            this.rbStudent.AutoSize = true;
            this.rbStudent.Location = new System.Drawing.Point(589, 346);
            this.rbStudent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(98, 29);
            this.rbStudent.TabIndex = 13;
            this.rbStudent.TabStop = true;
            this.rbStudent.Text = "Student";
            this.rbStudent.UseVisualStyleBackColor = true;
            // 
            // lblAdminOrStudent
            // 
            this.lblAdminOrStudent.AutoSize = true;
            this.lblAdminOrStudent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdminOrStudent.Location = new System.Drawing.Point(20, 348);
            this.lblAdminOrStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdminOrStudent.Name = "lblAdminOrStudent";
            this.lblAdminOrStudent.Size = new System.Drawing.Size(218, 28);
            this.lblAdminOrStudent.TabIndex = 11;
            this.lblAdminOrStudent.Text = "Choose Admin/student:";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.Location = new System.Drawing.Point(422, 394);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(268, 49);
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            // 
            // tbStudentRoom
            // 
            this.tbStudentRoom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStudentRoom.Location = new System.Drawing.Point(159, 285);
            this.tbStudentRoom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStudentRoom.Name = "tbStudentRoom";
            this.tbStudentRoom.Size = new System.Drawing.Size(530, 34);
            this.tbStudentRoom.TabIndex = 9;
            // 
            // lblStudentHouse
            // 
            this.lblStudentHouse.AutoSize = true;
            this.lblStudentHouse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentHouse.Location = new System.Drawing.Point(20, 289);
            this.lblStudentHouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentHouse.Name = "lblStudentHouse";
            this.lblStudentHouse.Size = new System.Drawing.Size(71, 28);
            this.lblStudentHouse.TabIndex = 8;
            this.lblStudentHouse.Text = "House:";
            // 
            // tbStudentBuilding
            // 
            this.tbStudentBuilding.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStudentBuilding.Location = new System.Drawing.Point(159, 226);
            this.tbStudentBuilding.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStudentBuilding.Name = "tbStudentBuilding";
            this.tbStudentBuilding.Size = new System.Drawing.Size(530, 34);
            this.tbStudentBuilding.TabIndex = 7;
            // 
            // lblStudentBuilding
            // 
            this.lblStudentBuilding.AutoSize = true;
            this.lblStudentBuilding.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentBuilding.Location = new System.Drawing.Point(20, 230);
            this.lblStudentBuilding.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentBuilding.Name = "lblStudentBuilding";
            this.lblStudentBuilding.Size = new System.Drawing.Size(88, 28);
            this.lblStudentBuilding.TabIndex = 6;
            this.lblStudentBuilding.Text = "Building:";
            // 
            // tbStudentAddress
            // 
            this.tbStudentAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStudentAddress.Location = new System.Drawing.Point(159, 165);
            this.tbStudentAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStudentAddress.Name = "tbStudentAddress";
            this.tbStudentAddress.Size = new System.Drawing.Size(530, 34);
            this.tbStudentAddress.TabIndex = 5;
            // 
            // lblStudentAddress
            // 
            this.lblStudentAddress.AutoSize = true;
            this.lblStudentAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentAddress.Location = new System.Drawing.Point(20, 169);
            this.lblStudentAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentAddress.Name = "lblStudentAddress";
            this.lblStudentAddress.Size = new System.Drawing.Size(86, 28);
            this.lblStudentAddress.TabIndex = 4;
            this.lblStudentAddress.Text = "Address:";
            // 
            // tbStudentEmail
            // 
            this.tbStudentEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStudentEmail.Location = new System.Drawing.Point(159, 106);
            this.tbStudentEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStudentEmail.Name = "tbStudentEmail";
            this.tbStudentEmail.Size = new System.Drawing.Size(530, 34);
            this.tbStudentEmail.TabIndex = 3;
            // 
            // lblstudentEmail
            // 
            this.lblstudentEmail.AutoSize = true;
            this.lblstudentEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblstudentEmail.Location = new System.Drawing.Point(20, 110);
            this.lblstudentEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentEmail.Name = "lblstudentEmail";
            this.lblstudentEmail.Size = new System.Drawing.Size(63, 28);
            this.lblstudentEmail.TabIndex = 2;
            this.lblstudentEmail.Text = "Email:";
            // 
            // lboxUsers
            // 
            this.lboxUsers.FormattingEnabled = true;
            this.lboxUsers.ItemHeight = 25;
            this.lboxUsers.Location = new System.Drawing.Point(734, 15);
            this.lboxUsers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lboxUsers.Name = "lboxUsers";
            this.lboxUsers.Size = new System.Drawing.Size(388, 854);
            this.lboxUsers.TabIndex = 0;
            // 
            // lblGetPassword
            // 
            this.lblGetPassword.AutoSize = true;
            this.lblGetPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGetPassword.Location = new System.Drawing.Point(15, 510);
            this.lblGetPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGetPassword.Name = "lblGetPassword";
            this.lblGetPassword.Size = new System.Drawing.Size(285, 28);
            this.lblGetPassword.TabIndex = 11;
            this.lblGetPassword.Text = "Select user to get it\'s password:";
            // 
            // tbStudentPassword
            // 
            this.tbStudentPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStudentPassword.Location = new System.Drawing.Point(334, 506);
            this.tbStudentPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStudentPassword.Name = "tbStudentPassword";
            this.tbStudentPassword.ReadOnly = true;
            this.tbStudentPassword.Size = new System.Drawing.Size(370, 34);
            this.tbStudentPassword.TabIndex = 11;
            // 
            // btnGetPassword
            // 
            this.btnGetPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGetPassword.Location = new System.Drawing.Point(395, 566);
            this.btnGetPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetPassword.Name = "btnGetPassword";
            this.btnGetPassword.Size = new System.Drawing.Size(310, 49);
            this.btnGetPassword.TabIndex = 11;
            this.btnGetPassword.Text = "Get student password";
            this.btnGetPassword.UseVisualStyleBackColor = true;
            // 
            // lblRemoveUser
            // 
            this.lblRemoveUser.AutoSize = true;
            this.lblRemoveUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRemoveUser.Location = new System.Drawing.Point(15, 659);
            this.lblRemoveUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemoveUser.Name = "lblRemoveUser";
            this.lblRemoveUser.Size = new System.Drawing.Size(204, 28);
            this.lblRemoveUser.TabIndex = 14;
            this.lblRemoveUser.Text = "Select user to remove:";
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRemoveUser.Location = new System.Drawing.Point(395, 646);
            this.btnRemoveUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(310, 49);
            this.btnRemoveUser.TabIndex = 12;
            this.btnRemoveUser.Text = "Remove user";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            // 
            // UserAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 874);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.lblRemoveUser);
            this.Controls.Add(this.btnGetPassword);
            this.Controls.Add(this.tbStudentPassword);
            this.Controls.Add(this.lblGetPassword);
            this.Controls.Add(this.lboxUsers);
            this.Controls.Add(this.gboxAddUser);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UserAdministration";
            this.Text = "UserAdministration";
            this.gboxAddUser.ResumeLayout(false);
            this.gboxAddUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblStudentName;
        private TextBox tbStudentName;
        private GroupBox gboxAddUser;
        private ListBox lboxUsers;
        private Button btnAddUser;
        private TextBox tbStudentRoom;
        private Label lblStudentHouse;
        private TextBox tbStudentBuilding;
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
    }
}