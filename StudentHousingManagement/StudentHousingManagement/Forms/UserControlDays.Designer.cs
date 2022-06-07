namespace StudentHousingManagementForms
{
    partial class UserControlDays
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
            this.lblDaysNum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDaysNum
            // 
            this.lblDaysNum.AutoSize = true;
            this.lblDaysNum.Location = new System.Drawing.Point(8, 8);
            this.lblDaysNum.Name = "lblDaysNum";
            this.lblDaysNum.Size = new System.Drawing.Size(25, 20);
            this.lblDaysNum.TabIndex = 0;
            this.lblDaysNum.Text = "00";
            // 
            // UserControlDays
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDaysNum);
            this.Name = "UserControlDays";
            this.Size = new System.Drawing.Size(122, 93);
            this.Load += new System.EventHandler(this.UserControlDays_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblDaysNum;
    }
}
