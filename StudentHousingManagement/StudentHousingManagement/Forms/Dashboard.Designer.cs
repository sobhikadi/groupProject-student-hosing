namespace StudentHousingManagementForms
{
    partial class Dashboard
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
            this.cboxAllOrHouse = new System.Windows.Forms.ComboBox();
            this.flpAnnouncements = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // cboxAllOrHouse
            // 
            this.cboxAllOrHouse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxAllOrHouse.FormattingEnabled = true;
            this.cboxAllOrHouse.Items.AddRange(new object[] {
            "All",
            "Building",
            "House"});
            this.cboxAllOrHouse.Location = new System.Drawing.Point(12, 12);
            this.cboxAllOrHouse.Name = "cboxAllOrHouse";
            this.cboxAllOrHouse.Size = new System.Drawing.Size(450, 36);
            this.cboxAllOrHouse.TabIndex = 0;
            this.cboxAllOrHouse.Text = "All";
            this.cboxAllOrHouse.SelectedIndexChanged += new System.EventHandler(this.cboxAllOrHouse_SelectedIndexChanged);
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
            this.flpAnnouncements.TabIndex = 1;
            this.flpAnnouncements.SizeChanged += new System.EventHandler(this.flpAnnouncements_SizeChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 699);
            this.Controls.Add(this.flpAnnouncements);
            this.Controls.Add(this.cboxAllOrHouse);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboxAllOrHouse;
        private FlowLayoutPanel flpAnnouncements;
    }
}