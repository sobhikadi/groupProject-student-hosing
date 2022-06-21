namespace StudentHousingManagementForms
{
    partial class MyProfile
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
            this.tbStudentPassword = new System.Windows.Forms.TextBox();
            this.lblStudentPassword = new System.Windows.Forms.Label();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.tbStudentEmail = new System.Windows.Forms.TextBox();
            this.lblstudentEmail = new System.Windows.Forms.Label();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.lblStudentName = new System.Windows.Forms.Label();
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
            this.gboxAddUser.Location = new System.Drawing.Point(12, 11);
            this.gboxAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxAddUser.Name = "gboxAddUser";
            this.gboxAddUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxAddUser.Size = new System.Drawing.Size(584, 307);
            this.gboxAddUser.TabIndex = 4;
            this.gboxAddUser.TabStop = false;
            this.gboxAddUser.Text = "My information";
            // 
            // tbStudentPassword
            // 
            this.tbStudentPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStudentPassword.Location = new System.Drawing.Point(127, 135);
            this.tbStudentPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStudentPassword.Name = "tbStudentPassword";
            this.tbStudentPassword.Size = new System.Drawing.Size(425, 30);
            this.tbStudentPassword.TabIndex = 3;
            // 
            // lblStudentPassword
            // 
            this.lblStudentPassword.AutoSize = true;
            this.lblStudentPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentPassword.Location = new System.Drawing.Point(17, 137);
            this.lblStudentPassword.Name = "lblStudentPassword";
            this.lblStudentPassword.Size = new System.Drawing.Size(84, 23);
            this.lblStudentPassword.TabIndex = 11;
            this.lblStudentPassword.Text = "Password:";
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateInfo.Location = new System.Drawing.Point(337, 192);
            this.btnUpdateInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(215, 38);
            this.btnUpdateInfo.TabIndex = 4;
            this.btnUpdateInfo.Text = "Update Information";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            // 
            // tbStudentEmail
            // 
            this.tbStudentEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStudentEmail.Location = new System.Drawing.Point(127, 86);
            this.tbStudentEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStudentEmail.Name = "tbStudentEmail";
            this.tbStudentEmail.Size = new System.Drawing.Size(425, 30);
            this.tbStudentEmail.TabIndex = 2;
            // 
            // lblstudentEmail
            // 
            this.lblstudentEmail.AutoSize = true;
            this.lblstudentEmail.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblstudentEmail.Location = new System.Drawing.Point(17, 87);
            this.lblstudentEmail.Name = "lblstudentEmail";
            this.lblstudentEmail.Size = new System.Drawing.Size(55, 23);
            this.lblstudentEmail.TabIndex = 2;
            this.lblstudentEmail.Text = "Email:";
            // 
            // tbStudentName
            // 
            this.tbStudentName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStudentName.Location = new System.Drawing.Point(127, 38);
            this.tbStudentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(425, 30);
            this.tbStudentName.TabIndex = 1;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStudentName.Location = new System.Drawing.Point(17, 41);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(60, 23);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Name:";
            // 
            // MyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(903, 699);
            this.Controls.Add(this.gboxAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyProfile";
            this.Text = "MyProfile";
            this.gboxAddUser.ResumeLayout(false);
            this.gboxAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gboxAddUser;
        private TextBox tbStudentPassword;
        private Label lblStudentPassword;
        private Button btnUpdateInfo;
        private TextBox tbStudentEmail;
        private Label lblstudentEmail;
        private TextBox tbStudentName;
        private Label lblStudentName;
    }
}