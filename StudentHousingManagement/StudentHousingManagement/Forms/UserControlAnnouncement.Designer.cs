namespace StudentHousingManagementForms
{
    partial class UserControlAnnouncement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblAnnouncementTitle = new System.Windows.Forms.Label();
            this.lblAnnouncementBody = new System.Windows.Forms.Label();
            this.lblPostedOn = new System.Windows.Forms.Label();
            this.lblAnnouncementDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.Location = new System.Drawing.Point(23, 16);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 25);
            this.lblUserName.TabIndex = 0;
            // 
            // lblAnnouncementTitle
            // 
            this.lblAnnouncementTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAnnouncementTitle.AutoSize = true;
            this.lblAnnouncementTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblAnnouncementTitle.Location = new System.Drawing.Point(23, 62);
            this.lblAnnouncementTitle.Name = "lblAnnouncementTitle";
            this.lblAnnouncementTitle.Size = new System.Drawing.Size(0, 25);
            this.lblAnnouncementTitle.TabIndex = 1;
            // 
            // lblAnnouncementBody
            // 
            this.lblAnnouncementBody.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAnnouncementBody.AutoSize = true;
            this.lblAnnouncementBody.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnnouncementBody.Location = new System.Drawing.Point(23, 108);
            this.lblAnnouncementBody.Name = "lblAnnouncementBody";
            this.lblAnnouncementBody.Size = new System.Drawing.Size(0, 25);
            this.lblAnnouncementBody.TabIndex = 2;
            // 
            // lblPostedOn
            // 
            this.lblPostedOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPostedOn.AutoSize = true;
            this.lblPostedOn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPostedOn.Location = new System.Drawing.Point(742, 73);
            this.lblPostedOn.Name = "lblPostedOn";
            this.lblPostedOn.Size = new System.Drawing.Size(99, 25);
            this.lblPostedOn.TabIndex = 3;
            this.lblPostedOn.Text = "Posted on:";
            // 
            // lblAnnouncementDate
            // 
            this.lblAnnouncementDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnnouncementDate.AutoSize = true;
            this.lblAnnouncementDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnnouncementDate.Location = new System.Drawing.Point(841, 108);
            this.lblAnnouncementDate.Name = "lblAnnouncementDate";
            this.lblAnnouncementDate.Size = new System.Drawing.Size(0, 25);
            this.lblAnnouncementDate.TabIndex = 4;
            // 
            // UserControlAnnouncement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblAnnouncementDate);
            this.Controls.Add(this.lblPostedOn);
            this.Controls.Add(this.lblAnnouncementBody);
            this.Controls.Add(this.lblAnnouncementTitle);
            this.Controls.Add(this.lblUserName);
            this.Margin = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.Name = "UserControlAnnouncement";
            this.Size = new System.Drawing.Size(855, 143);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUserName;
        private Label lblAnnouncementTitle;
        private Label lblAnnouncementBody;
        private Label lblPostedOn;
        private Label lblAnnouncementDate;
    }
}
