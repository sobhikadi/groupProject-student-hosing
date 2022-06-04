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
            this.tbAnnouncementDescription = new System.Windows.Forms.TextBox();
            this.rbHouse = new System.Windows.Forms.RadioButton();
            this.rbBuilding = new System.Windows.Forms.RadioButton();
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
            this.tbAnnouncementTitle.Location = new System.Drawing.Point(29, 107);
            this.tbAnnouncementTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbAnnouncementTitle.Name = "tbAnnouncementTitle";
            this.tbAnnouncementTitle.Size = new System.Drawing.Size(1068, 50);
            this.tbAnnouncementTitle.TabIndex = 1;
            // 
            // btnPublishAnnouncement
            // 
            this.btnPublishAnnouncement.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPublishAnnouncement.Location = new System.Drawing.Point(689, 798);
            this.btnPublishAnnouncement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPublishAnnouncement.Name = "btnPublishAnnouncement";
            this.btnPublishAnnouncement.Size = new System.Drawing.Size(410, 67);
            this.btnPublishAnnouncement.TabIndex = 2;
            this.btnPublishAnnouncement.Text = "Publish Announcement";
            this.btnPublishAnnouncement.UseVisualStyleBackColor = true;
            this.btnPublishAnnouncement.Click += new System.EventHandler(this.btnPublishAnnouncement_Click);
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
            // tbAnnouncementDescription
            // 
            this.tbAnnouncementDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAnnouncementDescription.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbAnnouncementDescription.Location = new System.Drawing.Point(29, 298);
            this.tbAnnouncementDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbAnnouncementDescription.Multiline = true;
            this.tbAnnouncementDescription.Name = "tbAnnouncementDescription";
            this.tbAnnouncementDescription.Size = new System.Drawing.Size(1068, 472);
            this.tbAnnouncementDescription.TabIndex = 4;
            // 
            // rbHouse
            // 
            this.rbHouse.AutoSize = true;
            this.rbHouse.Location = new System.Drawing.Point(596, 817);
            this.rbHouse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbHouse.Name = "rbHouse";
            this.rbHouse.Size = new System.Drawing.Size(88, 29);
            this.rbHouse.TabIndex = 5;
            this.rbHouse.TabStop = true;
            this.rbHouse.Text = "House";
            this.rbHouse.UseVisualStyleBackColor = true;
            // 
            // rbBuilding
            // 
            this.rbBuilding.AutoSize = true;
            this.rbBuilding.Location = new System.Drawing.Point(474, 817);
            this.rbBuilding.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbBuilding.Name = "rbBuilding";
            this.rbBuilding.Size = new System.Drawing.Size(101, 29);
            this.rbBuilding.TabIndex = 6;
            this.rbBuilding.TabStop = true;
            this.rbBuilding.Text = "Building";
            this.rbBuilding.UseVisualStyleBackColor = true;
            // 
            // CreateAnnoucement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 878);
            this.Controls.Add(this.rbBuilding);
            this.Controls.Add(this.rbHouse);
            this.Controls.Add(this.tbAnnouncementDescription);
            this.Controls.Add(this.lblAnnouncementDescription);
            this.Controls.Add(this.btnPublishAnnouncement);
            this.Controls.Add(this.tbAnnouncementTitle);
            this.Controls.Add(this.lblAnnouncementTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        private TextBox tbAnnouncementDescription;
        private RadioButton rbHouse;
        private RadioButton rbBuilding;
    }
}