namespace StudentHousingManagementForms
{
    partial class FileComplaint
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
            this.tbComplaintDescription = new System.Windows.Forms.TextBox();
            this.lblComplaintDescription = new System.Windows.Forms.Label();
            this.btnPublishComplaint = new System.Windows.Forms.Button();
            this.tbComplaintTitle = new System.Windows.Forms.TextBox();
            this.lblComplaintTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbComplaintDescription
            // 
            this.tbComplaintDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbComplaintDescription.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbComplaintDescription.Location = new System.Drawing.Point(24, 230);
            this.tbComplaintDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbComplaintDescription.Multiline = true;
            this.tbComplaintDescription.Name = "tbComplaintDescription";
            this.tbComplaintDescription.Size = new System.Drawing.Size(855, 378);
            this.tbComplaintDescription.TabIndex = 9;
            // 
            // lblComplaintDescription
            // 
            this.lblComplaintDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComplaintDescription.AutoSize = true;
            this.lblComplaintDescription.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComplaintDescription.Location = new System.Drawing.Point(24, 162);
            this.lblComplaintDescription.Name = "lblComplaintDescription";
            this.lblComplaintDescription.Size = new System.Drawing.Size(361, 46);
            this.lblComplaintDescription.TabIndex = 8;
            this.lblComplaintDescription.Text = "Complaint Description:";
            // 
            // btnPublishComplaint
            // 
            this.btnPublishComplaint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPublishComplaint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPublishComplaint.Location = new System.Drawing.Point(551, 630);
            this.btnPublishComplaint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPublishComplaint.Name = "btnPublishComplaint";
            this.btnPublishComplaint.Size = new System.Drawing.Size(328, 54);
            this.btnPublishComplaint.TabIndex = 7;
            this.btnPublishComplaint.Text = "Publish Complaint";
            this.btnPublishComplaint.UseVisualStyleBackColor = true;
            this.btnPublishComplaint.Click += new System.EventHandler(this.btnPublishComplaint_Click);
            // 
            // tbComplaintTitle
            // 
            this.tbComplaintTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbComplaintTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbComplaintTitle.Location = new System.Drawing.Point(24, 78);
            this.tbComplaintTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbComplaintTitle.Name = "tbComplaintTitle";
            this.tbComplaintTitle.Size = new System.Drawing.Size(855, 43);
            this.tbComplaintTitle.TabIndex = 6;
            // 
            // lblComplaintTitle
            // 
            this.lblComplaintTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComplaintTitle.AutoSize = true;
            this.lblComplaintTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComplaintTitle.Location = new System.Drawing.Point(24, 16);
            this.lblComplaintTitle.Name = "lblComplaintTitle";
            this.lblComplaintTitle.Size = new System.Drawing.Size(254, 46);
            this.lblComplaintTitle.TabIndex = 5;
            this.lblComplaintTitle.Text = "Complaint Title:";
            // 
            // FileComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 698);
            this.Controls.Add(this.tbComplaintDescription);
            this.Controls.Add(this.lblComplaintDescription);
            this.Controls.Add(this.btnPublishComplaint);
            this.Controls.Add(this.tbComplaintTitle);
            this.Controls.Add(this.lblComplaintTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FileComplaint";
            this.Text = "FileComplaint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbComplaintDescription;
        private Label lblComplaintDescription;
        private Button btnPublishComplaint;
        private TextBox tbComplaintTitle;
        private Label lblComplaintTitle;
    }
}