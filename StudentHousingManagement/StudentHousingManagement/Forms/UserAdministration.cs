using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentHousingManagement;

namespace StudentHousingManagementForms
{  
    public partial class UserAdministration : Form
    {
        UserController userController;
        BuildingController buildingController;

        public UserAdministration(UserController userController, BuildingController buildingController)
        {
            InitializeComponent();
            this.userController = userController;
            this.buildingController = buildingController;
            
            
            UpdateUserList();
            UpdateBuildingList();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //Check if Textboxes are not empty.
            if (String.IsNullOrEmpty(tbStudentName.Text))
            {
                MessageBox.Show("Please input a name.");
                return;
            }
            if(String.IsNullOrEmpty(tbStudentEmail.Text))
            {
                MessageBox.Show("Please input an email.");
                return;
            }

            if (userController.NewUser(tbStudentName.Text, tbStudentEmail.Text, rbAdmin.Checked, (House)cboxHouseAdd.SelectedItem))
            {
                MessageBox.Show("User succesfully added.");
                UpdateUserList();
            }
            else MessageBox.Show("This email is already in use.");
        }

        private void btnRemoveUser_Click(object sender, EventArgs e)
        {
            if (userController.CurrentUser != (User)lboxUsers.SelectedItem)
            {
                userController.Users.Remove((User)lboxUsers.SelectedItem);
                UpdateUserList();
            }
            else MessageBox.Show("You cannot remove yourself.");
        }

        private void UpdateUserList()
        {
            lboxUsers.DataSource = null;
            lboxUsers.DataSource = userController.Users;
        }
        private void UpdateBuildingList()
        {
            cboxBuildingAdd.DataSource = null;
            cboxBuildingAdd.DataSource = buildingController.Buildings;

            cboxBuildingView.DataSource = null;
            cboxBuildingView.DataSource = buildingController.Buildings;
        }
        private void UpdateHouseList(Building building)
        {
            cboxHouseAdd.DataSource = null;
            cboxHouseAdd.DataSource = building.Houses;

            cboxHouseView.DataSource = null;
            cboxHouseView.DataSource = building.Houses;
        }

        private void cBoxBuildingAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateHouseList((Building)cboxBuildingAdd.SelectedItem);
        }

        private void cboxBuildingView_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateHouseList((Building)cboxBuildingView.SelectedItem);
        }

        private void UserAdministration_SizeChanged(object sender, EventArgs e)
        {
            if (this.Size.Width > 1100)
            {
                gboxAddUser.Width = this.Size.Width - 520;
                groupBox1.Width = this.Size.Width - gboxAddUser.Width - 20;
            }
            else 
            { 
                groupBox1.Width = 312; 
                gboxAddUser.Width = this.Width - groupBox1.Width - 20; 
            }

        }
    }
}
