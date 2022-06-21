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
            this.cboxBuildings.Location = new System.Drawing.Point(112, 13);
            this.cboxBuildings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxBuildings.Name = "cboxBuildings";
            this.cboxBuildings.Size = new System.Drawing.Size(435, 28);
            this.cboxBuildings.TabIndex = 0;
            this.cboxBuildings.SelectedIndexChanged += new System.EventHandler(this.cboxBuildings_SelectedIndexChanged);
            // 
            // lblBuildings
            // 
            this.lblBuildings.AutoSize = true;
            this.lblBuildings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuildings.Location = new System.Drawing.Point(10, 13);
            this.lblBuildings.Name = "lblBuildings";
            this.lblBuildings.Size = new System.Drawing.Size(74, 21);
            this.lblBuildings.TabIndex = 1;
            this.lblBuildings.Text = "Buildings";
            // 
            // tbBuildingRules
            // 
            this.tbBuildingRules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBuildingRules.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbBuildingRules.Location = new System.Drawing.Point(10, 55);
            this.tbBuildingRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbBuildingRules.Multiline = true;
            this.tbBuildingRules.Name = "tbBuildingRules";
            this.tbBuildingRules.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbBuildingRules.Size = new System.Drawing.Size(785, 438);
            this.tbBuildingRules.TabIndex = 2;
            // 
            // btnUpdateBuildingRules
            // 
            this.btnUpdateBuildingRules.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateBuildingRules.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateBuildingRules.Location = new System.Drawing.Point(493, 506);
            this.btnUpdateBuildingRules.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateBuildingRules.Name = "btnUpdateBuildingRules";
            this.btnUpdateBuildingRules.Size = new System.Drawing.Size(303, 37);
            this.btnUpdateBuildingRules.TabIndex = 3;
            this.btnUpdateBuildingRules.Text = "Update Building Rules";
            this.btnUpdateBuildingRules.UseVisualStyleBackColor = true;
            this.btnUpdateBuildingRules.Click += new System.EventHandler(this.btnUpdateBuildingRules_Click);
            // 
            // BuildingRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 560);
            this.Controls.Add(this.btnUpdateBuildingRules);
            this.Controls.Add(this.tbBuildingRules);
            this.Controls.Add(this.lblBuildings);
            this.Controls.Add(this.cboxBuildings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BuildingRules";
            this.Text = "BuildingRules";
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