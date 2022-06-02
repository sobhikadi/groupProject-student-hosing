namespace StudentHousingManagementForms
{
    partial class BuildingAdministration
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
            this.gboxAddUser = new System.Windows.Forms.GroupBox();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lblBuildingAddress = new System.Windows.Forms.Label();
            this.tbStreetAndNumber = new System.Windows.Forms.TextBox();
            this.lblNoOfResidents = new System.Windows.Forms.Label();
            this.tbZIP = new System.Windows.Forms.TextBox();
            this.btnAddBuilding = new System.Windows.Forms.Button();
            this.nudNoOfHouses = new System.Windows.Forms.NumericUpDown();
            this.gboxAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfHouses)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxAddUser
            // 
            this.gboxAddUser.Controls.Add(this.nudNoOfHouses);
            this.gboxAddUser.Controls.Add(this.tbZIP);
            this.gboxAddUser.Controls.Add(this.btnAddBuilding);
            this.gboxAddUser.Controls.Add(this.lblNoOfResidents);
            this.gboxAddUser.Controls.Add(this.tbCity);
            this.gboxAddUser.Controls.Add(this.lblBuildingAddress);
            this.gboxAddUser.Controls.Add(this.tbStreetAndNumber);
            this.gboxAddUser.Location = new System.Drawing.Point(12, 11);
            this.gboxAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxAddUser.Name = "gboxAddUser";
            this.gboxAddUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxAddUser.Size = new System.Drawing.Size(498, 278);
            this.gboxAddUser.TabIndex = 3;
            this.gboxAddUser.TabStop = false;
            this.gboxAddUser.Text = "Add Building";
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCity.Location = new System.Drawing.Point(192, 69);
            this.tbCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCity.Name = "tbCity";
            this.tbCity.PlaceholderText = "City";
            this.tbCity.Size = new System.Drawing.Size(256, 25);
            this.tbCity.TabIndex = 5;
            // 
            // lblBuildingAddress
            // 
            this.lblBuildingAddress.AutoSize = true;
            this.lblBuildingAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuildingAddress.Location = new System.Drawing.Point(6, 32);
            this.lblBuildingAddress.Name = "lblBuildingAddress";
            this.lblBuildingAddress.Size = new System.Drawing.Size(61, 19);
            this.lblBuildingAddress.TabIndex = 4;
            this.lblBuildingAddress.Text = "Address:";
            // 
            // tbStreetAndNumber
            // 
            this.tbStreetAndNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStreetAndNumber.Location = new System.Drawing.Point(110, 29);
            this.tbStreetAndNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStreetAndNumber.Name = "tbStreetAndNumber";
            this.tbStreetAndNumber.PlaceholderText = "Adress";
            this.tbStreetAndNumber.Size = new System.Drawing.Size(338, 25);
            this.tbStreetAndNumber.TabIndex = 3;
            // 
            // lblNoOfResidents
            // 
            this.lblNoOfResidents.AutoSize = true;
            this.lblNoOfResidents.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNoOfResidents.Location = new System.Drawing.Point(6, 125);
            this.lblNoOfResidents.Name = "lblNoOfResidents";
            this.lblNoOfResidents.Size = new System.Drawing.Size(98, 19);
            this.lblNoOfResidents.TabIndex = 2;
            this.lblNoOfResidents.Text = "No Of Houses:";
            // 
            // tbZIP
            // 
            this.tbZIP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbZIP.Location = new System.Drawing.Point(110, 69);
            this.tbZIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbZIP.Name = "tbZIP";
            this.tbZIP.PlaceholderText = "ZIP Code";
            this.tbZIP.Size = new System.Drawing.Size(76, 25);
            this.tbZIP.TabIndex = 1;
            // 
            // btnAddBuilding
            // 
            this.btnAddBuilding.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddBuilding.Location = new System.Drawing.Point(6, 173);
            this.btnAddBuilding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBuilding.Name = "btnAddBuilding";
            this.btnAddBuilding.Size = new System.Drawing.Size(188, 29);
            this.btnAddBuilding.TabIndex = 10;
            this.btnAddBuilding.Text = "Add Building";
            this.btnAddBuilding.UseVisualStyleBackColor = true;
            this.btnAddBuilding.Click += new System.EventHandler(this.btnAddBuilding_Click);
            // 
            // nudNoOfHouses
            // 
            this.nudNoOfHouses.Location = new System.Drawing.Point(110, 125);
            this.nudNoOfHouses.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudNoOfHouses.Name = "nudNoOfHouses";
            this.nudNoOfHouses.Size = new System.Drawing.Size(76, 23);
            this.nudNoOfHouses.TabIndex = 11;
            // 
            // BuildingAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gboxAddUser);
            this.Name = "BuildingAdministration";
            this.Text = "BuildingAdministration";
            this.gboxAddUser.ResumeLayout(false);
            this.gboxAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfHouses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gboxAddUser;
        private TextBox tbCity;
        private Label lblBuildingAddress;
        private TextBox tbStreetAndNumber;
        private Label lblNoOfResidents;
        private TextBox tbZIP;
        private NumericUpDown nudNoOfHouses;
        private Button btnAddBuilding;
    }
}