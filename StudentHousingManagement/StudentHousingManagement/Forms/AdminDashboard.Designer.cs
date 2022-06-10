namespace StudentHousingManagementForms
{
    partial class AdminDashboard
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
            this.flpAnnouncements = new System.Windows.Forms.FlowLayoutPanel();
            this.cboxBuildings = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // flpAnnouncements
            // 
            this.flpAnnouncements.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpAnnouncements.AutoScroll = true;
            this.flpAnnouncements.AutoSize = true;
            this.flpAnnouncements.Location = new System.Drawing.Point(12, 54);
            this.flpAnnouncements.Name = "flpAnnouncements";
            this.flpAnnouncements.Size = new System.Drawing.Size(879, 633);
            this.flpAnnouncements.TabIndex = 3;
            this.flpAnnouncements.SizeChanged += new System.EventHandler(this.flpAnnouncements_SizeChanged);
            // 
            // cboxBuildings
            // 
            this.cboxBuildings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxBuildings.FormattingEnabled = true;
            this.cboxBuildings.Location = new System.Drawing.Point(12, 12);
            this.cboxBuildings.Name = "cboxBuildings";
            this.cboxBuildings.Size = new System.Drawing.Size(450, 36);
            this.cboxBuildings.TabIndex = 2;
            this.cboxBuildings.Text = "Select a building to show rules";
            this.cboxBuildings.SelectedIndexChanged += new System.EventHandler(this.cboxBuildings_SelectedIndexChanged);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 699);
            this.Controls.Add(this.flpAnnouncements);
            this.Controls.Add(this.cboxBuildings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flpAnnouncements;
        private ComboBox cboxBuildings;
    }
}