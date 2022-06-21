namespace StudentHousingManagementForms
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLogo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.rbUser = new System.Windows.Forms.RadioButton();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLogo
            // 
            this.lblLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.Location = new System.Drawing.Point(219, 97);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(619, 54);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Welcome to Student Housing B.V.";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.rbAdmin);
            this.panel1.Controls.Add(this.rbUser);
            this.panel1.Controls.Add(this.btnLogIn);
            this.panel1.Controls.Add(this.tbPassword);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.tbEmail);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Location = new System.Drawing.Point(258, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(538, 354);
            this.panel1.TabIndex = 1;
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbAdmin.Location = new System.Drawing.Point(404, 219);
            this.rbAdmin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(88, 29);
            this.rbAdmin.TabIndex = 2;
            this.rbAdmin.TabStop = true;
            this.rbAdmin.Text = "Admin";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // rbUser
            // 
            this.rbUser.AutoSize = true;
            this.rbUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbUser.Location = new System.Drawing.Point(315, 219);
            this.rbUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbUser.Name = "rbUser";
            this.rbUser.Size = new System.Drawing.Size(71, 29);
            this.rbUser.TabIndex = 3;
            this.rbUser.TabStop = true;
            this.rbUser.Text = "User";
            this.rbUser.UseVisualStyleBackColor = true;
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Linen;
            this.btnLogIn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogIn.Location = new System.Drawing.Point(152, 277);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(240, 49);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPassword.Location = new System.Drawing.Point(180, 155);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(312, 39);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(60, 158);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(116, 32);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbEmail.Location = new System.Drawing.Point(180, 54);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PlaceholderText = "example@email.nl";
            this.tbEmail.Size = new System.Drawing.Size(312, 39);
            this.tbEmail.TabIndex = 0;
            this.tbEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEmail_KeyPress);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.Location = new System.Drawing.Point(98, 57);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(76, 32);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Email:";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1061, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblLogo);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in - student housing B.V.";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLogo;
        private Panel panel1;
        private Button btnLogIn;
        private TextBox tbPassword;
        private Label lblPassword;
        private TextBox tbEmail;
        private Label lblUserName;
        private RadioButton rbAdmin;
        private RadioButton rbUser;
    }
}