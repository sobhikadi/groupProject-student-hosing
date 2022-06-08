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
            this.btnAddHouse = new System.Windows.Forms.Button();
            this.lboxHouses = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudNoOfResidents = new System.Windows.Forms.NumericUpDown();
            this.cboxBuilding = new System.Windows.Forms.ComboBox();
            this.tbHouseNumber = new System.Windows.Forms.TextBox();
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
            this.gboxAddUser.Location = new System.Drawing.Point(12, 11);
            this.gboxAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxAddUser.Name = "gboxAddUser";
            this.gboxAddUser.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gboxAddUser.Size = new System.Drawing.Size(382, 294);
            this.gboxAddUser.TabIndex = 3;
            this.gboxAddUser.TabStop = false;
            this.gboxAddUser.Text = "Add Building";
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
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCity.Location = new System.Drawing.Point(192, 69);
            this.tbCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCity.Name = "tbCity";
            this.tbCity.PlaceholderText = "City";
            this.tbCity.Size = new System.Drawing.Size(182, 25);
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
            this.tbStreetAndNumber.Size = new System.Drawing.Size(264, 25);
            this.tbStreetAndNumber.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbHouseNumber);
            this.groupBox1.Controls.Add(this.btnAddHouse);
            this.groupBox1.Controls.Add(this.lboxHouses);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudNoOfResidents);
            this.groupBox1.Controls.Add(this.cboxBuilding);
            this.groupBox1.Location = new System.Drawing.Point(412, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(368, 294);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add House";
            // 
            // btnAddHouse
            // 
            this.btnAddHouse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddHouse.Location = new System.Drawing.Point(4, 252);
            this.btnAddHouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddHouse.Name = "btnAddHouse";
            this.btnAddHouse.Size = new System.Drawing.Size(188, 29);
            this.btnAddHouse.TabIndex = 13;
            this.btnAddHouse.Text = "Add House";
            this.btnAddHouse.UseVisualStyleBackColor = true;
            this.btnAddHouse.Click += new System.EventHandler(this.btnAddHouse_Click);
            // 
            // lboxHouses
            // 
            this.lboxHouses.FormattingEnabled = true;
            this.lboxHouses.ItemHeight = 15;
            this.lboxHouses.Location = new System.Drawing.Point(104, 53);
            this.lboxHouses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lboxHouses.Name = "lboxHouses";
            this.lboxHouses.Size = new System.Drawing.Size(261, 139);
            this.lboxHouses.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Building:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "House Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "NoOfResidents:";
            // 
            // nudNoOfResidents
            // 
            this.nudNoOfResidents.Location = new System.Drawing.Point(104, 225);
            this.nudNoOfResidents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudNoOfResidents.Name = "nudNoOfResidents";
            this.nudNoOfResidents.Size = new System.Drawing.Size(127, 23);
            this.nudNoOfResidents.TabIndex = 14;
            // 
            // cboxBuilding
            // 
            this.cboxBuilding.FormattingEnabled = true;
            this.cboxBuilding.Location = new System.Drawing.Point(104, 22);
            this.cboxBuilding.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboxBuilding.Name = "cboxBuilding";
            this.cboxBuilding.Size = new System.Drawing.Size(261, 23);
            this.cboxBuilding.TabIndex = 13;
            this.cboxBuilding.SelectedIndexChanged += new System.EventHandler(this.cboxBuilding_SelectedIndexChanged);
            // 
            // tbHouseNumber
            // 
            this.tbHouseNumber.Location = new System.Drawing.Point(104, 197);
            this.tbHouseNumber.Name = "tbHouseNumber";
            this.tbHouseNumber.Size = new System.Drawing.Size(127, 23);
            this.tbHouseNumber.TabIndex = 16;
            // 
            // BuildingAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxAddUser);
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
    }
}