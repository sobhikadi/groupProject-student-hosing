namespace StudentHousingManagementForms
{
    partial class BuildingRules
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
            this.cboxBuildings = new System.Windows.Forms.ComboBox();
            this.lblBuildings = new System.Windows.Forms.Label();
            this.tbBuildingRules = new System.Windows.Forms.TextBox();
            this.btnUpdateBuildingRules = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboxBuildings
            // 
            this.cboxBuildings.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboxBuildings.FormattingEnabled = true;
            this.cboxBuildings.Location = new System.Drawing.Point(128, 17);
            this.cboxBuildings.Name = "cboxBuildings";
            this.cboxBuildings.Size = new System.Drawing.Size(497, 33);
            this.cboxBuildings.TabIndex = 0;
            // 
            // lblBuildings
            // 
            this.lblBuildings.AutoSize = true;
            this.lblBuildings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuildings.Location = new System.Drawing.Point(12, 17);
            this.lblBuildings.Name = "lblBuildings";
            this.lblBuildings.Size = new System.Drawing.Size(92, 28);
            this.lblBuildings.TabIndex = 1;
            this.lblBuildings.Text = "Buildings";
            // 
            // tbBuildingRules
            // 
            this.tbBuildingRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuildingRules.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBuildingRules.Location = new System.Drawing.Point(12, 73);
            this.tbBuildingRules.Multiline = true;
            this.tbBuildingRules.Name = "tbBuildingRules";
            this.tbBuildingRules.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbBuildingRules.Size = new System.Drawing.Size(897, 583);
            this.tbBuildingRules.TabIndex = 2;
            // 
            // btnUpdateBuildingRules
            // 
            this.btnUpdateBuildingRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateBuildingRules.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateBuildingRules.Location = new System.Drawing.Point(563, 674);
            this.btnUpdateBuildingRules.Name = "btnUpdateBuildingRules";
            this.btnUpdateBuildingRules.Size = new System.Drawing.Size(346, 49);
            this.btnUpdateBuildingRules.TabIndex = 3;
            this.btnUpdateBuildingRules.Text = "Update Building Rules";
            this.btnUpdateBuildingRules.UseVisualStyleBackColor = true;
            // 
            // BuildingRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 746);
            this.Controls.Add(this.btnUpdateBuildingRules);
            this.Controls.Add(this.tbBuildingRules);
            this.Controls.Add(this.lblBuildings);
            this.Controls.Add(this.cboxBuildings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BuildingRules";
            this.Text = "BuildingRules";
            this.Load += new System.EventHandler(this.BuildingRules_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboxBuildings;
        private Label lblBuildings;
        private TextBox tbBuildingRules;
        private Button btnUpdateBuildingRules;
    }
}