namespace StudentHousingManagementForms
{
    partial class CreateAnnouncementAdmin
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
            this.tbAnnouncementDescription = new System.Windows.Forms.TextBox();
            this.lblAnnouncementDescription = new System.Windows.Forms.Label();
            this.btnPublishAnnouncement = new System.Windows.Forms.Button();
            this.tbAnnouncementTitle = new System.Windows.Forms.TextBox();
            this.lblAnnouncementTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbAnnouncementDescription
            // 
            this.tbAnnouncementDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAnnouncementDescription.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAnnouncementDescription.Location = new System.Drawing.Point(33, 242);
            this.tbAnnouncementDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAnnouncementDescription.MinimumSize = new System.Drawing.Size(855, 378);
            this.tbAnnouncementDescription.Multiline = true;
            this.tbAnnouncementDescription.Name = "tbAnnouncementDescription";
            this.tbAnnouncementDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAnnouncementDescription.Size = new System.Drawing.Size(855, 400);
            this.tbAnnouncementDescription.TabIndex = 11;
            // 
            // lblAnnouncementDescription
            // 
            this.lblAnnouncementDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnnouncementDescription.AutoSize = true;
            this.lblAnnouncementDescription.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnnouncementDescription.Location = new System.Drawing.Point(33, 174);
            this.lblAnnouncementDescription.Name = "lblAnnouncementDescription";
            this.lblAnnouncementDescription.Size = new System.Drawing.Size(437, 46);
            this.lblAnnouncementDescription.TabIndex = 10;
            this.lblAnnouncementDescription.Text = "Announcement Description:";
            // 
            // btnPublishAnnouncement
            // 
            this.btnPublishAnnouncement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPublishAnnouncement.AutoSize = true;
            this.btnPublishAnnouncement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPublishAnnouncement.Location = new System.Drawing.Point(560, 665);
            this.btnPublishAnnouncement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPublishAnnouncement.Name = "btnPublishAnnouncement";
            this.btnPublishAnnouncement.Size = new System.Drawing.Size(328, 54);
            this.btnPublishAnnouncement.TabIndex = 9;
            this.btnPublishAnnouncement.Text = "Publish Announcement";
            this.btnPublishAnnouncement.UseVisualStyleBackColor = true;
            this.btnPublishAnnouncement.Click += new System.EventHandler(this.btnPublishAnnouncement_Click);
            // 
            // tbAnnouncementTitle
            // 
            this.tbAnnouncementTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAnnouncementTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbAnnouncementTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAnnouncementTitle.Location = new System.Drawing.Point(33, 90);
            this.tbAnnouncementTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAnnouncementTitle.Name = "tbAnnouncementTitle";
            this.tbAnnouncementTitle.Size = new System.Drawing.Size(855, 43);
            this.tbAnnouncementTitle.TabIndex = 8;
            // 
            // lblAnnouncementTitle
            // 
            this.lblAnnouncementTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnnouncementTitle.AutoSize = true;
            this.lblAnnouncementTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnnouncementTitle.Location = new System.Drawing.Point(33, 28);
            this.lblAnnouncementTitle.Name = "lblAnnouncementTitle";
            this.lblAnnouncementTitle.Size = new System.Drawing.Size(330, 46);
            this.lblAnnouncementTitle.TabIndex = 7;
            this.lblAnnouncementTitle.Text = "Announcement Title:";
            // 
            // CreateAnnouncementAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 746);
            this.Controls.Add(this.tbAnnouncementDescription);
            this.Controls.Add(this.lblAnnouncementDescription);
            this.Controls.Add(this.btnPublishAnnouncement);
            this.Controls.Add(this.tbAnnouncementTitle);
            this.Controls.Add(this.lblAnnouncementTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAnnouncementAdmin";
            this.Text = "CreateAnnouncementAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbAnnouncementDescription;
        private Label lblAnnouncementDescription;
        private Button btnPublishAnnouncement;
        private TextBox tbAnnouncementTitle;
        private Label lblAnnouncementTitle;
    }
}