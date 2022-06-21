namespace StudentHousingManagementForms
{
    partial class Complaints
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
            this.flpComplaints = new System.Windows.Forms.FlowLayoutPanel();
            this.cboxBuildings = new System.Windows.Forms.ComboBox();
            this.cboxProcessedOrNot = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // flpComplaints
            // 
            this.flpComplaints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpComplaints.AutoScroll = true;
            this.flpComplaints.AutoSize = true;
            this.flpComplaints.Location = new System.Drawing.Point(12, 102);
            this.flpComplaints.Name = "flpComplaints";
            this.flpComplaints.Size = new System.Drawing.Size(879, 585);
            this.flpComplaints.TabIndex = 5;
            this.flpComplaints.SizeChanged += new System.EventHandler(this.flpComplaints_SizeChanged);
            // 
            // cboxBuildings
            // 
            this.cboxBuildings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxBuildings.FormattingEnabled = true;
            this.cboxBuildings.Location = new System.Drawing.Point(12, 12);
            this.cboxBuildings.Name = "cboxBuildings";
            this.cboxBuildings.Size = new System.Drawing.Size(450, 36);
            this.cboxBuildings.TabIndex = 4;
            this.cboxBuildings.Text = "All";
            this.cboxBuildings.SelectedIndexChanged += new System.EventHandler(this.cboxBuildings_SelectedIndexChanged);
            // 
            // cboxProcessedOrNot
            // 
            this.cboxProcessedOrNot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxProcessedOrNot.FormattingEnabled = true;
            this.cboxProcessedOrNot.Items.AddRange(new object[] {
            "All",
            "Processed",
            "Unprocessed"});
            this.cboxProcessedOrNot.Location = new System.Drawing.Point(12, 60);
            this.cboxProcessedOrNot.Name = "cboxProcessedOrNot";
            this.cboxProcessedOrNot.Size = new System.Drawing.Size(450, 36);
            this.cboxProcessedOrNot.TabIndex = 6;
            this.cboxProcessedOrNot.Text = "All";
            this.cboxProcessedOrNot.SelectedIndexChanged += new System.EventHandler(this.cboxProcessedOrNot_SelectedIndexChanged);
            // 
            // Complaints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(903, 699);
            this.Controls.Add(this.cboxProcessedOrNot);
            this.Controls.Add(this.flpComplaints);
            this.Controls.Add(this.cboxBuildings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Complaints";
            this.Text = "Complaints";
            this.Load += new System.EventHandler(this.Complaints_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flpComplaints;
        private ComboBox cboxBuildings;
        private ComboBox cboxProcessedOrNot;
    }
}