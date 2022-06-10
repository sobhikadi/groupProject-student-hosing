namespace StudentHousingManagementForms
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.pContainer = new System.Windows.Forms.Panel();
            this.pMenu = new System.Windows.Forms.Panel();
            this.btnBuildingRules = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.btnUserAdmin = new System.Windows.Forms.Button();
            this.btnCreateAnnoucement = new System.Windows.Forms.Button();
            this.btnComplaints = new System.Windows.Forms.Button();
            this.btnBuildingAdmin = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.pLogo = new System.Windows.Forms.Panel();
            this.lblLogoName = new System.Windows.Forms.Label();
            this.pboxLogo = new System.Windows.Forms.PictureBox();
            this.pMenu.SuspendLayout();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pContainer
            // 
            this.pContainer.AutoSize = true;
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.Location = new System.Drawing.Point(273, 0);
            this.pContainer.MinimumSize = new System.Drawing.Size(921, 746);
            this.pContainer.Name = "pContainer";
            this.pContainer.Size = new System.Drawing.Size(921, 746);
            this.pContainer.TabIndex = 3;
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.btnBuildingRules);
            this.pMenu.Controls.Add(this.btnLogOut);
            this.pMenu.Controls.Add(this.btnMyProfile);
            this.pMenu.Controls.Add(this.btnUserAdmin);
            this.pMenu.Controls.Add(this.btnCreateAnnoucement);
            this.pMenu.Controls.Add(this.btnComplaints);
            this.pMenu.Controls.Add(this.btnBuildingAdmin);
            this.pMenu.Controls.Add(this.btnDashboard);
            this.pMenu.Controls.Add(this.pLogo);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(273, 746);
            this.pMenu.TabIndex = 2;
            // 
            // btnBuildingRules
            // 
            this.btnBuildingRules.FlatAppearance.BorderSize = 0;
            this.btnBuildingRules.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuildingRules.Location = new System.Drawing.Point(3, 515);
            this.btnBuildingRules.Name = "btnBuildingRules";
            this.btnBuildingRules.Size = new System.Drawing.Size(264, 49);
            this.btnBuildingRules.TabIndex = 7;
            this.btnBuildingRules.Text = "Building Rules";
            this.btnBuildingRules.UseVisualStyleBackColor = true;
            this.btnBuildingRules.Click += new System.EventHandler(this.btnBuildingRules_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.Location = new System.Drawing.Point(3, 666);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(264, 49);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.FlatAppearance.BorderSize = 0;
            this.btnMyProfile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMyProfile.Location = new System.Drawing.Point(3, 592);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(264, 49);
            this.btnMyProfile.TabIndex = 5;
            this.btnMyProfile.Text = "My profile";
            this.btnMyProfile.UseVisualStyleBackColor = true;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // btnUserAdmin
            // 
            this.btnUserAdmin.FlatAppearance.BorderSize = 0;
            this.btnUserAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUserAdmin.Location = new System.Drawing.Point(3, 267);
            this.btnUserAdmin.Name = "btnUserAdmin";
            this.btnUserAdmin.Size = new System.Drawing.Size(264, 49);
            this.btnUserAdmin.TabIndex = 4;
            this.btnUserAdmin.Text = "User Administration";
            this.btnUserAdmin.UseVisualStyleBackColor = true;
            this.btnUserAdmin.Click += new System.EventHandler(this.btnUserAdmin_Click);
            // 
            // btnCreateAnnoucement
            // 
            this.btnCreateAnnoucement.FlatAppearance.BorderSize = 0;
            this.btnCreateAnnoucement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateAnnoucement.Location = new System.Drawing.Point(3, 349);
            this.btnCreateAnnoucement.Name = "btnCreateAnnoucement";
            this.btnCreateAnnoucement.Size = new System.Drawing.Size(264, 49);
            this.btnCreateAnnoucement.TabIndex = 3;
            this.btnCreateAnnoucement.Text = "Create Announcement";
            this.btnCreateAnnoucement.UseVisualStyleBackColor = true;
            this.btnCreateAnnoucement.Click += new System.EventHandler(this.btnCreateAnnoucement_Click);
            // 
            // btnComplaints
            // 
            this.btnComplaints.FlatAppearance.BorderSize = 0;
            this.btnComplaints.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnComplaints.Location = new System.Drawing.Point(3, 434);
            this.btnComplaints.Name = "btnComplaints";
            this.btnComplaints.Size = new System.Drawing.Size(264, 49);
            this.btnComplaints.TabIndex = 2;
            this.btnComplaints.Text = "Complaints";
            this.btnComplaints.UseVisualStyleBackColor = true;
            this.btnComplaints.Click += new System.EventHandler(this.btnComplaints_Click);
            // 
            // btnBuildingAdmin
            // 
            this.btnBuildingAdmin.FlatAppearance.BorderSize = 0;
            this.btnBuildingAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuildingAdmin.Location = new System.Drawing.Point(3, 184);
            this.btnBuildingAdmin.Name = "btnBuildingAdmin";
            this.btnBuildingAdmin.Size = new System.Drawing.Size(264, 49);
            this.btnBuildingAdmin.TabIndex = 1;
            this.btnBuildingAdmin.Text = "Building Administration";
            this.btnBuildingAdmin.UseVisualStyleBackColor = true;
            this.btnBuildingAdmin.Click += new System.EventHandler(this.btnBuildingAdmin_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.Location = new System.Drawing.Point(3, 108);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(264, 49);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pLogo
            // 
            this.pLogo.Controls.Add(this.lblLogoName);
            this.pLogo.Controls.Add(this.pboxLogo);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(273, 82);
            this.pLogo.TabIndex = 0;
            // 
            // lblLogoName
            // 
            this.lblLogoName.AutoSize = true;
            this.lblLogoName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLogoName.Location = new System.Drawing.Point(119, 19);
            this.lblLogoName.Name = "lblLogoName";
            this.lblLogoName.Size = new System.Drawing.Size(118, 50);
            this.lblLogoName.TabIndex = 1;
            this.lblLogoName.Text = "Student \r\nHousing B.V.";
            // 
            // pboxLogo
            // 
            this.pboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pboxLogo.Image")));
            this.pboxLogo.Location = new System.Drawing.Point(20, 19);
            this.pboxLogo.Name = "pboxLogo";
            this.pboxLogo.Size = new System.Drawing.Size(83, 47);
            this.pboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxLogo.TabIndex = 0;
            this.pboxLogo.TabStop = false;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 746);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.pMenu);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.pMenu.ResumeLayout(false);
            this.pLogo.ResumeLayout(false);
            this.pLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pContainer;
        private Panel pMenu;
        private Button btnLogOut;
        private Button btnMyProfile;
        private Button btnUserAdmin;
        private Button btnCreateAnnoucement;
        private Button btnComplaints;
        private Button btnBuildingAdmin;
        private Button btnDashboard;
        private Panel pLogo;
        private Label lblLogoName;
        private PictureBox pboxLogo;
        private Button btnBuildingRules;
    }
}