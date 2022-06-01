namespace StudentHousingManagementForms
{
    partial class CreateAnnoucement
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
            this.lblAnnouncementTitle = new System.Windows.Forms.Label();
            this.tbAnnouncementTitle = new System.Windows.Forms.TextBox();
            this.btnPublishAnnouncement = new System.Windows.Forms.Button();
            this.lblAnnouncementDescription = new System.Windows.Forms.Label();
            this.tbAnnouncementDiscription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAnnouncementTitle
            // 
            this.lblAnnouncementTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAnnouncementTitle.AutoSize = true;
            this.lblAnnouncementTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnnouncementTitle.Location = new System.Drawing.Point(29, 30);
            this.lblAnnouncementTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnnouncementTitle.Name = "lblAnnouncementTitle";
            this.lblAnnouncementTitle.Size = new System.Drawing.Size(391, 54);
            this.lblAnnouncementTitle.TabIndex = 0;
            this.lblAnnouncementTitle.Text = "Announcement Title:";
            // 
            // tbAnnouncementTitle
            // 
            this.tbAnnouncementTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAnnouncementTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAnnouncementTitle.Location = new System.Drawing.Point(29, 106);
            this.tbAnnouncementTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAnnouncementTitle.Name = "tbAnnouncementTitle";
            this.tbAnnouncementTitle.Size = new System.Drawing.Size(1068, 50);
            this.tbAnnouncementTitle.TabIndex = 1;
            // 
            // btnPublishAnnouncement
            // 
            this.btnPublishAnnouncement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPublishAnnouncement.Location = new System.Drawing.Point(688, 798);
            this.btnPublishAnnouncement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPublishAnnouncement.Name = "btnPublishAnnouncement";
            this.btnPublishAnnouncement.Size = new System.Drawing.Size(410, 66);
            this.btnPublishAnnouncement.TabIndex = 2;
            this.btnPublishAnnouncement.Text = "Publish Announcement";
            this.btnPublishAnnouncement.UseVisualStyleBackColor = true;
            // 
            // lblAnnouncementDescription
            // 
            this.lblAnnouncementDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAnnouncementDescription.AutoSize = true;
            this.lblAnnouncementDescription.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnnouncementDescription.Location = new System.Drawing.Point(29, 212);
            this.lblAnnouncementDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnnouncementDescription.Name = "lblAnnouncementDescription";
            this.lblAnnouncementDescription.Size = new System.Drawing.Size(517, 54);
            this.lblAnnouncementDescription.TabIndex = 3;
            this.lblAnnouncementDescription.Text = "Announcement Description:";
            // 
            // tbAnnouncementDiscription
            // 
            this.tbAnnouncementDiscription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAnnouncementDiscription.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAnnouncementDiscription.Location = new System.Drawing.Point(29, 298);
            this.tbAnnouncementDiscription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAnnouncementDiscription.Multiline = true;
            this.tbAnnouncementDiscription.Name = "tbAnnouncementDiscription";
            this.tbAnnouncementDiscription.Size = new System.Drawing.Size(1068, 472);
            this.tbAnnouncementDiscription.TabIndex = 4;
            // 
            // CreateAnnoucement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 879);
            this.Controls.Add(this.tbAnnouncementDiscription);
            this.Controls.Add(this.lblAnnouncementDescription);
            this.Controls.Add(this.btnPublishAnnouncement);
            this.Controls.Add(this.tbAnnouncementTitle);
            this.Controls.Add(this.lblAnnouncementTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CreateAnnoucement";
            this.Text = "CreateAnnouncement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblAnnouncementTitle;
        private TextBox tbAnnouncementTitle;
        private Button btnPublishAnnouncement;
        private Label lblAnnouncementDescription;
        private TextBox tbAnnouncementDiscription;
    }
}