namespace StudentHousingManagementForms
{
    partial class UserControlComplaints
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
            this.lblComplaintDate = new System.Windows.Forms.Label();
            this.lblPostedOn = new System.Windows.Forms.Label();
            this.lblComplaintBody = new System.Windows.Forms.Label();
            this.lblComplaintTitle = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblComplaintDate
            // 
            this.lblComplaintDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComplaintDate.AutoSize = true;
            this.lblComplaintDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComplaintDate.Location = new System.Drawing.Point(834, 103);
            this.lblComplaintDate.Name = "lblComplaintDate";
            this.lblComplaintDate.Size = new System.Drawing.Size(0, 25);
            this.lblComplaintDate.TabIndex = 9;
            // 
            // lblPostedOn
            // 
            this.lblPostedOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPostedOn.AutoSize = true;
            this.lblPostedOn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPostedOn.Location = new System.Drawing.Point(735, 68);
            this.lblPostedOn.Name = "lblPostedOn";
            this.lblPostedOn.Size = new System.Drawing.Size(99, 25);
            this.lblPostedOn.TabIndex = 8;
            this.lblPostedOn.Text = "Posted on:";
            // 
            // lblComplaintBody
            // 
            this.lblComplaintBody.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblComplaintBody.AutoSize = true;
            this.lblComplaintBody.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblComplaintBody.Location = new System.Drawing.Point(18, 104);
            this.lblComplaintBody.Name = "lblComplaintBody";
            this.lblComplaintBody.Size = new System.Drawing.Size(0, 25);
            this.lblComplaintBody.TabIndex = 7;
            // 
            // lblComplaintTitle
            // 
            this.lblComplaintTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblComplaintTitle.AutoSize = true;
            this.lblComplaintTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblComplaintTitle.Location = new System.Drawing.Point(18, 58);
            this.lblComplaintTitle.Name = "lblComplaintTitle";
            this.lblComplaintTitle.Size = new System.Drawing.Size(0, 25);
            this.lblComplaintTitle.TabIndex = 6;
            // 
            // lblUserName
            // 
            this.lblUserName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserName.Location = new System.Drawing.Point(18, 12);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(0, 25);
            this.lblUserName.TabIndex = 5;
            // 
            // UserControlComplaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblComplaintDate);
            this.Controls.Add(this.lblPostedOn);
            this.Controls.Add(this.lblComplaintBody);
            this.Controls.Add(this.lblComplaintTitle);
            this.Controls.Add(this.lblUserName);
            this.Name = "UserControlComplaints";
            this.Size = new System.Drawing.Size(853, 141);
            this.Click += new System.EventHandler(this.UserControlComplaints_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblComplaintDate;
        private Label lblPostedOn;
        private Label lblComplaintBody;
        private Label lblComplaintTitle;
        private Label lblUserName;
    }
}
