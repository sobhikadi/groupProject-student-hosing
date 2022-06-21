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
            this.nudNoOfHouses = new System.Windows.Forms.NumericUpDown();
            this.tbZIP = new System.Windows.Forms.TextBox();
            this.btnAddBuilding = new System.Windows.Forms.Button();
            this.lblNoOfResidents = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.lblBuildingAddress = new System.Windows.Forms.Label();
            this.tbStreetAndNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNoOfHouses = new System.Windows.Forms.Label();
            this.tbNoOfHouses = new System.Windows.Forms.TextBox();
            this.tbHouseNumber = new System.Windows.Forms.TextBox();
            this.btnAddHouse = new System.Windows.Forms.Button();
            this.lboxHouses = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNoOfResidents = new System.Windows.Forms.NumericUpDown();
            this.cboxBuilding = new System.Windows.Forms.ComboBox();
            this.gboxAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfHouses)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfResidents)).BeginInit();
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
            this.gboxAddUser.Location = new System.Drawing.Point(14, 14);
            this.gboxAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxAddUser.Name = "gboxAddUser";
            this.gboxAddUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxAddUser.Size = new System.Drawing.Size(437, 392);
            this.gboxAddUser.TabIndex = 3;
            this.gboxAddUser.TabStop = false;
            this.gboxAddUser.Text = "Add Building";
            // 
            // nudNoOfHouses
            // 
            this.nudNoOfHouses.Location = new System.Drawing.Point(126, 166);
            this.nudNoOfHouses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nudNoOfHouses.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudNoOfHouses.Name = "nudNoOfHouses";
            this.nudNoOfHouses.Size = new System.Drawing.Size(87, 27);
            this.nudNoOfHouses.TabIndex = 11;
            // 
            // tbZIP
            // 
            this.tbZIP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbZIP.Location = new System.Drawing.Point(126, 92);
            this.tbZIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbZIP.Name = "tbZIP";
            this.tbZIP.PlaceholderText = "ZIP Code";
            this.tbZIP.Size = new System.Drawing.Size(86, 30);
            this.tbZIP.TabIndex = 1;
            // 
            // btnAddBuilding
            // 
            this.btnAddBuilding.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddBuilding.Location = new System.Drawing.Point(7, 230);
            this.btnAddBuilding.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBuilding.Name = "btnAddBuilding";
            this.btnAddBuilding.Size = new System.Drawing.Size(215, 38);
            this.btnAddBuilding.TabIndex = 10;
            this.btnAddBuilding.Text = "Add Building";
            this.btnAddBuilding.UseVisualStyleBackColor = true;
            this.btnAddBuilding.Click += new System.EventHandler(this.btnAddBuilding_Click);
            // 
            // lblNoOfResidents
            // 
            this.lblNoOfResidents.AutoSize = true;
            this.lblNoOfResidents.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNoOfResidents.Location = new System.Drawing.Point(7, 166);
            this.lblNoOfResidents.Name = "lblNoOfResidents";
            this.lblNoOfResidents.Size = new System.Drawing.Size(120, 23);
            this.lblNoOfResidents.TabIndex = 2;
            this.lblNoOfResidents.Text = "No Of Houses:";
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCity.Location = new System.Drawing.Point(219, 92);
            this.tbCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCity.Name = "tbCity";
            this.tbCity.PlaceholderText = "City";
            this.tbCity.Size = new System.Drawing.Size(207, 30);
            this.tbCity.TabIndex = 5;
            // 
            // lblBuildingAddress
            // 
            this.lblBuildingAddress.AutoSize = true;
            this.lblBuildingAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuildingAddress.Location = new System.Drawing.Point(7, 42);
            this.lblBuildingAddress.Name = "lblBuildingAddress";
            this.lblBuildingAddress.Size = new System.Drawing.Size(74, 23);
            this.lblBuildingAddress.TabIndex = 4;
            this.lblBuildingAddress.Text = "Address:";
            // 
            // tbStreetAndNumber
            // 
            this.tbStreetAndNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStreetAndNumber.Location = new System.Drawing.Point(126, 38);
            this.tbStreetAndNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStreetAndNumber.Name = "tbStreetAndNumber";
            this.tbStreetAndNumber.PlaceholderText = "Adress";
            this.tbStreetAndNumber.Size = new System.Drawing.Size(301, 30);
            this.tbStreetAndNumber.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNoOfHouses);
            this.groupBox1.Controls.Add(this.tbNoOfHouses);
            this.groupBox1.Controls.Add(this.tbHouseNumber);
            this.groupBox1.Controls.Add(this.btnAddHouse);
            this.groupBox1.Controls.Add(this.lboxHouses);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudNoOfResidents);
            this.groupBox1.Controls.Add(this.cboxBuilding);
            this.groupBox1.Location = new System.Drawing.Point(471, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(421, 392);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add House";
            // 
            // lblNoOfHouses
            // 
            this.lblNoOfHouses.AutoSize = true;
            this.lblNoOfHouses.Location = new System.Drawing.Point(5, 63);
            this.lblNoOfHouses.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoOfHouses.Name = "lblNoOfHouses";
            this.lblNoOfHouses.Size = new System.Drawing.Size(104, 20);
            this.lblNoOfHouses.TabIndex = 20;
            this.lblNoOfHouses.Text = "No Of Houses:";
            // 
            // tbNoOfHouses
            // 
            this.tbNoOfHouses.Location = new System.Drawing.Point(119, 61);
            this.tbNoOfHouses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbNoOfHouses.Name = "tbNoOfHouses";
            this.tbNoOfHouses.ReadOnly = true;
            this.tbNoOfHouses.Size = new System.Drawing.Size(121, 27);
            this.tbNoOfHouses.TabIndex = 19;
            // 
            // tbHouseNumber
            // 
            this.tbHouseNumber.Location = new System.Drawing.Point(119, 262);
            this.tbHouseNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbHouseNumber.Name = "tbHouseNumber";
            this.tbHouseNumber.Size = new System.Drawing.Size(145, 27);
            this.tbHouseNumber.TabIndex = 16;
            // 
            // btnAddHouse
            // 
            this.btnAddHouse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddHouse.Location = new System.Drawing.Point(5, 336);
            this.btnAddHouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddHouse.Name = "btnAddHouse";
            this.btnAddHouse.Size = new System.Drawing.Size(215, 38);
            this.btnAddHouse.TabIndex = 13;
            this.btnAddHouse.Text = "Add House";
            this.btnAddHouse.UseVisualStyleBackColor = true;
            this.btnAddHouse.Click += new System.EventHandler(this.btnAddHouse_Click);
            // 
            // lboxHouses
            // 
            this.lboxHouses.FormattingEnabled = true;
            this.lboxHouses.ItemHeight = 20;
            this.lboxHouses.Location = new System.Drawing.Point(119, 110);
            this.lboxHouses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lboxHouses.Name = "lboxHouses";
            this.lboxHouses.Size = new System.Drawing.Size(298, 144);
            this.lboxHouses.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Building:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 266);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "House Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 302);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "NoOfResidents:";
            // 
            // nudNoOfResidents
            // 
            this.nudNoOfResidents.Location = new System.Drawing.Point(119, 300);
            this.nudNoOfResidents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudNoOfResidents.Name = "nudNoOfResidents";
            this.nudNoOfResidents.Size = new System.Drawing.Size(145, 27);
            this.nudNoOfResidents.TabIndex = 14;
            // 
            // cboxBuilding
            // 
            this.cboxBuilding.FormattingEnabled = true;
            this.cboxBuilding.Location = new System.Drawing.Point(119, 30);
            this.cboxBuilding.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxBuilding.Name = "cboxBuilding";
            this.cboxBuilding.Size = new System.Drawing.Size(298, 28);
            this.cboxBuilding.TabIndex = 13;
            this.cboxBuilding.SelectedIndexChanged += new System.EventHandler(this.cboxBuilding_SelectedIndexChanged);
            // 
            // BuildingAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxAddUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BuildingAdministration";
            this.Text = "BuildingAdministration";
            this.gboxAddUser.ResumeLayout(false);
            this.gboxAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfHouses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfResidents)).EndInit();
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
        private GroupBox groupBox1;
        private ComboBox cboxBuilding;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown nudNoOfResidents;
        private ListBox lboxHouses;
        private Button btnAddHouse;
        private TextBox tbHouseNumber;
        private Label lblNoOfHouses;
        private TextBox tbNoOfHouses;
    }
}