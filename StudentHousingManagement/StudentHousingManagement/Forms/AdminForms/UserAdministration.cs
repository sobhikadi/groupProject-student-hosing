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

        public UserAdministration()
        {
            InitializeComponent();
            buildingController = new BuildingController();
            userController = new UserController();

            UpdateBuildingList();

            cboxBuildingUpdate.DataSource = null;
            cboxBuildingUpdate.DataSource = buildingController.Buildings;
            cboxBuildingUpdate.BindingContext = new BindingContext();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            House house = (House)cboxHouseAdd.SelectedItem;
            //Check if Textboxes are not empty.
            if (String.IsNullOrEmpty(tbStudentName.Text))
            {
                MessageBox.Show("Please input a name.");
                return;
            }
            else if (String.IsNullOrEmpty(tbStudentEmail.Text))
            {
                MessageBox.Show("Please input an email.");
                return;
            }
            else if (!house.RoomAvailable())
            {
                MessageBox.Show("No available rooms in target house.");
                return;
            }

            if (userController.NewUser(tbStudentName.Text, tbStudentEmail.Text, house))
            {
                MessageBox.Show("User succesfully added.");
                UpdateUserList();
            }
            else MessageBox.Show("This email is already in use.");
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbAdminName.Text))
            {
                MessageBox.Show("Please input a name.");
                return;
            }
            else if (String.IsNullOrEmpty(tbAdminEmail.Text))
            {
                MessageBox.Show("Please input an email.");
                return;
            }

            if (userController.NewAdmin(tbAdminName.Text, tbAdminEmail.Text))
            {
                MessageBox.Show("Admin succesfully added.");
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

        private void btnUpdateHouse_Click(object sender, EventArgs e)
        {
            User user = (User)lboxUsers.SelectedItem;
            House house = (House)cboxHouseUpdate.SelectedItem;

            if (!house.RoomAvailable())
            {
                MessageBox.Show("No available rooms in target house.");
                return;
            }

            if (buildingController.ChangeHouse(house, user))
            {
                userController.ChangeHouse(house, user);
                MessageBox.Show("House updated succesfully.");
                UpdateUserList();
            }
            else MessageBox.Show("User is already in this house.");
        }

        private void btnLoginInfo_Click(object sender, EventArgs e)
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
            cboxHouseUpdate.DataSource = null;
            cboxHouseUpdate.DataSource = building.Houses;
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
            {
                House house = (House)cboxHouseView.SelectedItem;
                UpdateUserList();
                tbNoOfResidents.Text = house.NoOfResidents.ToString();
            }
        }

        private void cboxBuildingUpdate_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateHouseUpdateList((Building)cboxBuildingUpdate.SelectedItem);
        }

        private void UserAdministration_SizeChanged(object sender, EventArgs e)
        {
            if (this.Size.Width > 1100)
            {
                gboxAddUser.Width = this.Size.Width - 520;
                gboxStudents.Width = this.Size.Width - gboxAddUser.Width - 20;
            }
            else
            {
                gboxStudents.Width = 312;
                gboxAddUser.Width = this.Width - gboxStudents.Width - 20;
            }
        }
    }
}