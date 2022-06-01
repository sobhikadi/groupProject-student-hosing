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
            this.tbComplaintDiscription = new System.Windows.Forms.TextBox();
            this.lblComplaintDescription = new System.Windows.Forms.Label();
            this.btnPublishComplaint = new System.Windows.Forms.Button();
            this.tbComplaintTitle = new System.Windows.Forms.TextBox();
            this.lblComplaintTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbComplaintDiscription
            // 
            this.tbComplaintDiscription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbComplaintDiscription.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbComplaintDiscription.Location = new System.Drawing.Point(30, 288);
            this.tbComplaintDiscription.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbComplaintDiscription.Multiline = true;
            this.tbComplaintDiscription.Name = "tbComplaintDiscription";
            this.tbComplaintDiscription.Size = new System.Drawing.Size(1068, 472);
            this.tbComplaintDiscription.TabIndex = 9;
            // 
            // lblComplaintDescription
            // 
            this.lblComplaintDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblComplaintDescription.AutoSize = true;
            this.lblComplaintDescription.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComplaintDescription.Location = new System.Drawing.Point(30, 202);
            this.lblComplaintDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComplaintDescription.Name = "lblComplaintDescription";
            this.lblComplaintDescription.Size = new System.Drawing.Size(428, 54);
            this.lblComplaintDescription.TabIndex = 8;
            this.lblComplaintDescription.Text = "Complaint Description:";
            // 
            // btnPublishComplaint
            // 
            this.btnPublishComplaint.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPublishComplaint.Location = new System.Drawing.Point(689, 788);
            this.btnPublishComplaint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPublishComplaint.Name = "btnPublishComplaint";
            this.btnPublishComplaint.Size = new System.Drawing.Size(410, 66);
            this.btnPublishComplaint.TabIndex = 7;
            this.btnPublishComplaint.Text = "Publish Complaint";
            this.btnPublishComplaint.UseVisualStyleBackColor = true;
            // 
            // tbComplaintTitle
            // 
            this.tbComplaintTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbComplaintTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbComplaintTitle.Location = new System.Drawing.Point(30, 96);
            this.tbComplaintTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbComplaintTitle.Name = "tbComplaintTitle";
            this.tbComplaintTitle.Size = new System.Drawing.Size(1068, 50);
            this.tbComplaintTitle.TabIndex = 6;
            // 
            // lblComplaintTitle
            // 
            this.lblComplaintTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblComplaintTitle.AutoSize = true;
            this.lblComplaintTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComplaintTitle.Location = new System.Drawing.Point(30, 20);
            this.lblComplaintTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComplaintTitle.Name = "lblComplaintTitle";
            this.lblComplaintTitle.Size = new System.Drawing.Size(302, 54);
            this.lblComplaintTitle.TabIndex = 5;
            this.lblComplaintTitle.Text = "Complaint Title:";
            // 
            // FileComplaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 874);
            this.Controls.Add(this.tbComplaintDiscription);
            this.Controls.Add(this.lblComplaintDescription);
            this.Controls.Add(this.btnPublishComplaint);
            this.Controls.Add(this.tbComplaintTitle);
            this.Controls.Add(this.lblComplaintTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FileComplaint";
            this.Text = "FileComplaint";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbComplaintDiscription;
        private Label lblComplaintDescription;
        private Button btnPublishComplaint;
        private TextBox tbComplaintTitle;
        private Label lblComplaintTitle;
    }
}