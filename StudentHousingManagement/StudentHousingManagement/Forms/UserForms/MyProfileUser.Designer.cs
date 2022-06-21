namespace StudentHousingManagementForms
{
    partial class MyProfileUser
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
            this.gboxAddUser = new System.Windows.Forms.GroupBox();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.tbStudentEmail = new System.Windows.Forms.TextBox();
            this.lblstudentEmail = new System.Windows.Forms.Label();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.tbStudentPassword = new System.Windows.Forms.TextBox();
            this.lblStudentPassword = new System.Windows.Forms.Label();
            this.gboxAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxAddUser
            // 
            this.gboxAddUser.Controls.Add(this.tbStudentPassword);
            this.gboxAddUser.Controls.Add(this.lblStudentPassword);
            this.gboxAddUser.Controls.Add(this.btnUpdateInfo);
            this.gboxAddUser.Controls.Add(this.tbStudentEmail);
            this.gboxAddUser.Controls.Add(this.lblstudentEmail);
            this.gboxAddUser.Controls.Add(this.tbStudentName);
            this.gboxAddUser.Controls.Add(this.lblStudentName);
            this.gboxAddUser.Location = new System.Drawing.Point(13, 12);
            this.gboxAddUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxAddUser.Name = "gboxAddUser";
            this.gboxAddUser.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxAddUser.Size = new System.Drawing.Size(711, 414);
            this.gboxAddUser.TabIndex = 3;
            this.gboxAddUser.TabStop = false;
            this.gboxAddUser.Text = "My information";
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateInfo.Location = new System.Drawing.Point(290, 242);
            this.btnUpdateInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(269, 48);
            this.btnUpdateInfo.TabIndex = 4;
            this.btnUpdateInfo.Text = "Update Information";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // tbStudentEmail
            // 
            this.tbStudentEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStudentEmail.Location = new System.Drawing.Point(159, 107);
            this.tbStudentEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbStudentEmail.Name = "tbStudentEmail";
            this.tbStudentEmail.Size = new System.Drawing.Size(530, 34);
            this.tbStudentEmail.TabIndex = 2;
            // 
            // lblstudentEmail
            // 
            this.lblstudentEmail.AutoSize = true;
            this.lblstudentEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblstudentEmail.Location = new System.Drawing.Point(21, 110);
            this.lblstudentEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblstudentEmail.Name = "lblstudentEmail";
            this.lblstudentEmail.Size = new System.Drawing.Size(63, 28);
            this.lblstudentEmail.TabIndex = 2;
            this.lblstudentEmail.Text = "Email:";
            // 
            // tbStudentName
            // 
            this.tbStudentName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStudentName.Location = new System.Drawing.Point(159, 48);
            this.tbStudentName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(530, 34);
            this.tbStudentName.TabIndex = 1;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentName.Location = new System.Drawing.Point(21, 52);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(68, 28);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Name:";
            // 
            // tbStudentPassword
            // 
            this.tbStudentPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStudentPassword.Location = new System.Drawing.Point(159, 169);
            this.tbStudentPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbStudentPassword.Name = "tbStudentPassword";
            this.tbStudentPassword.Size = new System.Drawing.Size(530, 34);
            this.tbStudentPassword.TabIndex = 3;
            // 
            // lblStudentPassword
            // 
            this.lblStudentPassword.AutoSize = true;
            this.lblStudentPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentPassword.Location = new System.Drawing.Point(21, 172);
            this.lblStudentPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentPassword.Name = "lblStudentPassword";
            this.lblStudentPassword.Size = new System.Drawing.Size(97, 28);
            this.lblStudentPassword.TabIndex = 11;
            this.lblStudentPassword.Text = "Password:";
            // 
            // MyProfileUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 874);
            this.Controls.Add(this.gboxAddUser);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MyProfileUser";
            this.Text = "MyProfile";
            this.gboxAddUser.ResumeLayout(false);
            this.gboxAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gboxAddUser;
        private Button btnUpdateInfo;
        private TextBox tbStudentEmail;
        private Label lblstudentEmail;
        private TextBox tbStudentName;
        private Label lblStudentName;
        private TextBox tbStudentPassword;
        private Label lblStudentPassword;
    }
}