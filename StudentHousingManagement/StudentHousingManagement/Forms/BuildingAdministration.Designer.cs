﻿namespace StudentHousingManagementForms
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
            this.nudHouseNumber = new System.Windows.Forms.NumericUpDown();
            this.nudNoOfResidents = new System.Windows.Forms.NumericUpDown();
            this.cboxBuilding = new System.Windows.Forms.ComboBox();
            this.gboxAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfHouses)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHouseNumber)).BeginInit();
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
            this.gboxAddUser.Location = new System.Drawing.Point(17, 18);
            this.gboxAddUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxAddUser.Name = "gboxAddUser";
            this.gboxAddUser.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxAddUser.Size = new System.Drawing.Size(545, 463);
            this.gboxAddUser.TabIndex = 3;
            this.gboxAddUser.TabStop = false;
            this.gboxAddUser.Text = "Add Building";
            // 
            // nudNoOfHouses
            // 
            this.nudNoOfHouses.Location = new System.Drawing.Point(157, 208);
            this.nudNoOfHouses.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudNoOfHouses.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudNoOfHouses.Name = "nudNoOfHouses";
            this.nudNoOfHouses.Size = new System.Drawing.Size(109, 31);
            this.nudNoOfHouses.TabIndex = 11;
            // 
            // tbZIP
            // 
            this.tbZIP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbZIP.Location = new System.Drawing.Point(157, 115);
            this.tbZIP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbZIP.Name = "tbZIP";
            this.tbZIP.PlaceholderText = "ZIP Code";
            this.tbZIP.Size = new System.Drawing.Size(107, 34);
            this.tbZIP.TabIndex = 1;
            // 
            // btnAddBuilding
            // 
            this.btnAddBuilding.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddBuilding.Location = new System.Drawing.Point(9, 288);
            this.btnAddBuilding.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddBuilding.Name = "btnAddBuilding";
            this.btnAddBuilding.Size = new System.Drawing.Size(269, 48);
            this.btnAddBuilding.TabIndex = 10;
            this.btnAddBuilding.Text = "Add Building";
            this.btnAddBuilding.UseVisualStyleBackColor = true;
            this.btnAddBuilding.Click += new System.EventHandler(this.btnAddBuilding_Click);
            // 
            // lblNoOfResidents
            // 
            this.lblNoOfResidents.AutoSize = true;
            this.lblNoOfResidents.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNoOfResidents.Location = new System.Drawing.Point(9, 208);
            this.lblNoOfResidents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNoOfResidents.Name = "lblNoOfResidents";
            this.lblNoOfResidents.Size = new System.Drawing.Size(137, 28);
            this.lblNoOfResidents.TabIndex = 2;
            this.lblNoOfResidents.Text = "No Of Houses:";
            // 
            // tbCity
            // 
            this.tbCity.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCity.Location = new System.Drawing.Point(274, 115);
            this.tbCity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCity.Name = "tbCity";
            this.tbCity.PlaceholderText = "City";
            this.tbCity.Size = new System.Drawing.Size(259, 34);
            this.tbCity.TabIndex = 5;
            // 
            // lblBuildingAddress
            // 
            this.lblBuildingAddress.AutoSize = true;
            this.lblBuildingAddress.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBuildingAddress.Location = new System.Drawing.Point(9, 53);
            this.lblBuildingAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuildingAddress.Name = "lblBuildingAddress";
            this.lblBuildingAddress.Size = new System.Drawing.Size(86, 28);
            this.lblBuildingAddress.TabIndex = 4;
            this.lblBuildingAddress.Text = "Address:";
            // 
            // tbStreetAndNumber
            // 
            this.tbStreetAndNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbStreetAndNumber.Location = new System.Drawing.Point(157, 48);
            this.tbStreetAndNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbStreetAndNumber.Name = "tbStreetAndNumber";
            this.tbStreetAndNumber.PlaceholderText = "Adress";
            this.tbStreetAndNumber.Size = new System.Drawing.Size(376, 34);
            this.tbStreetAndNumber.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddHouse);
            this.groupBox1.Controls.Add(this.lboxHouses);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudHouseNumber);
            this.groupBox1.Controls.Add(this.nudNoOfResidents);
            this.groupBox1.Controls.Add(this.cboxBuilding);
            this.groupBox1.Location = new System.Drawing.Point(588, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(526, 463);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add House";
            // 
            // btnAddHouse
            // 
            this.btnAddHouse.Location = new System.Drawing.Point(194, 423);
            this.btnAddHouse.Name = "btnAddHouse";
            this.btnAddHouse.Size = new System.Drawing.Size(161, 34);
            this.btnAddHouse.TabIndex = 13;
            this.btnAddHouse.Text = "Add House";
            this.btnAddHouse.UseVisualStyleBackColor = true;
            this.btnAddHouse.Click += new System.EventHandler(this.btnAddHouse_Click);
            // 
            // lboxHouses
            // 
            this.lboxHouses.FormattingEnabled = true;
            this.lboxHouses.ItemHeight = 25;
            this.lboxHouses.Location = new System.Drawing.Point(149, 89);
            this.lboxHouses.Name = "lboxHouses";
            this.lboxHouses.Size = new System.Drawing.Size(371, 229);
            this.lboxHouses.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Building:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "House Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "NoOfResidents:";
            // 
            // nudHouseNumber
            // 
            this.nudHouseNumber.Location = new System.Drawing.Point(173, 341);
            this.nudHouseNumber.Name = "nudHouseNumber";
            this.nudHouseNumber.Size = new System.Drawing.Size(182, 31);
            this.nudHouseNumber.TabIndex = 15;
            // 
            // nudNoOfResidents
            // 
            this.nudNoOfResidents.Location = new System.Drawing.Point(173, 378);
            this.nudNoOfResidents.Name = "nudNoOfResidents";
            this.nudNoOfResidents.Size = new System.Drawing.Size(182, 31);
            this.nudNoOfResidents.TabIndex = 14;
            // 
            // cboxBuilding
            // 
            this.cboxBuilding.FormattingEnabled = true;
            this.cboxBuilding.Location = new System.Drawing.Point(149, 36);
            this.cboxBuilding.Name = "cboxBuilding";
            this.cboxBuilding.Size = new System.Drawing.Size(371, 33);
            this.cboxBuilding.TabIndex = 13;
            this.cboxBuilding.SelectedIndexChanged += new System.EventHandler(this.cboxBuilding_SelectedIndexChanged);
            // 
            // BuildingAdministration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gboxAddUser);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BuildingAdministration";
            this.Text = "BuildingAdministration";
            this.gboxAddUser.ResumeLayout(false);
            this.gboxAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNoOfHouses)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudHouseNumber)).EndInit();
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
        private NumericUpDown nudHouseNumber;
        private NumericUpDown nudNoOfResidents;
        private ListBox lboxHouses;
        private Button btnAddHouse;
    }
}