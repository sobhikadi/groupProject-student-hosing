namespace StudentHousingManagementForms
{
    partial class DisplayFullAnnouncement
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
            this.tbAnnouncementDescription.Location = new System.Drawing.Point(35, 236);
            this.tbAnnouncementDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAnnouncementDescription.MinimumSize = new System.Drawing.Size(855, 378);
            this.tbAnnouncementDescription.Multiline = true;
            this.tbAnnouncementDescription.Name = "tbAnnouncementDescription";
            this.tbAnnouncementDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbAnnouncementDescription.Size = new System.Drawing.Size(855, 452);
            this.tbAnnouncementDescription.TabIndex = 8;
            // 
            // lblAnnouncementDescription
            // 
            this.lblAnnouncementDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnnouncementDescription.AutoSize = true;
            this.lblAnnouncementDescription.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnnouncementDescription.Location = new System.Drawing.Point(35, 171);
            this.lblAnnouncementDescription.Name = "lblAnnouncementDescription";
            this.lblAnnouncementDescription.Size = new System.Drawing.Size(437, 46);
            this.lblAnnouncementDescription.TabIndex = 7;
            this.lblAnnouncementDescription.Text = "Announcement Description:";
            // 
            // tbAnnouncementTitle
            // 
            this.tbAnnouncementTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbAnnouncementTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbAnnouncementTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAnnouncementTitle.Location = new System.Drawing.Point(35, 93);
            this.tbAnnouncementTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAnnouncementTitle.Name = "tbAnnouncementTitle";
            this.tbAnnouncementTitle.Size = new System.Drawing.Size(855, 43);
            this.tbAnnouncementTitle.TabIndex = 6;
            // 
            // lblAnnouncementTitle
            // 
            this.lblAnnouncementTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnnouncementTitle.AutoSize = true;
            this.lblAnnouncementTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnnouncementTitle.Location = new System.Drawing.Point(35, 31);
            this.lblAnnouncementTitle.Name = "lblAnnouncementTitle";
            this.lblAnnouncementTitle.Size = new System.Drawing.Size(330, 46);
            this.lblAnnouncementTitle.TabIndex = 5;
            this.lblAnnouncementTitle.Text = "Announcement Title:";
            // 
            // DisplayFullAnnouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 712);
            this.Controls.Add(this.tbAnnouncementDescription);
            this.Controls.Add(this.lblAnnouncementDescription);
            this.Controls.Add(this.tbAnnouncementTitle);
            this.Controls.Add(this.lblAnnouncementTitle);
            this.Name = "DisplayFullAnnouncement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayFullAnnouncement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbAnnouncementDescription;
        private Label lblAnnouncementDescription;
        private TextBox tbAnnouncementTitle;
        private Label lblAnnouncementTitle;
    }
}