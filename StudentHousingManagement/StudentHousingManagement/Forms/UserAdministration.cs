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
            
            UpdateBuildingList();

            cboxBuildingUpdate.DataSource = null;
            cboxBuildingUpdate.DataSource = buildingController.Buildings;
            cboxBuildingUpdate.BindingContext = new BindingContext();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //Check if Textboxes are not empty.
            if (String.IsNullOrEmpty(tbStudentName.Text))
            {
                MessageBox.Show("Please input a name.");
                return;
            }
            else if(String.IsNullOrEmpty(tbStudentEmail.Text))
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

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            User user = (User)lboxUsers.SelectedItem;
            user.House = (House)cBoxHouseUpdate.SelectedItem;
        }

        private void btnGetPassword_Click(object sender, EventArgs e)
        {
            User user = (User)lboxUsers.SelectedItem;
            MessageBox.Show($"{user.Email} - {user.Password}");
        }

        private void UpdateUserList()
        {
                House house = (House)cboxHouseView.SelectedItem;
                lboxUsers.DataSource = null;
                lboxUsers.DataSource = house.Residents;
        }
        private void UpdateBuildingList()
        {
            cboxBuildingAdd.DataSource = null;
            cboxBuildingAdd.DataSource = buildingController.Buildings;
            cboxBuildingAdd.BindingContext = new BindingContext();

            cboxBuildingView.DataSource = null;
            cboxBuildingView.DataSource = buildingController.Buildings;
        }
        private void UpdateHouseListAdd(Building building)
        {
            cboxHouseAdd.DataSource = null;
            cboxHouseAdd.DataSource = building.Houses;
            cboxHouseAdd.BindingContext = new BindingContext();
        }

        private void UpdateHouseListView(Building building)
        {
            cboxHouseView.DataSource = null;
            cboxHouseView.DataSource = building.Houses;
            cboxHouseView.BindingContext = new BindingContext();
        }

        private void UpdateHouseUpdateList(Building building)
        {
            cBoxHouseUpdate.DataSource = null;
            cBoxHouseUpdate.DataSource = building.Houses;
        }

        private void cBoxBuildingAdd_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateHouseListAdd((Building)cboxBuildingAdd.SelectedItem);
        }

        private void cboxBuildingView_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateHouseListView((Building)cboxBuildingView.SelectedItem);
        }

        private void cboxHouseView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxHouseView.SelectedItem != null)
            { UpdateUserList(); }
        }

        private void cboxBuildingUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateHouseUpdateList((Building)cboxBuildingUpdate.SelectedItem);
        }
    }
}
