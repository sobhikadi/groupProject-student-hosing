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
using Message = StudentHousingManagement.Message;

namespace StudentHousingManagementForms
{
    public partial class UserDashboard : Form
    {
        User currentUser;
        BuildingController buildingController;


        public UserDashboard(User user)
        {
            InitializeComponent();
            currentUser = user;
            buildingController = new BuildingController();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DisplayAnnouncements();
        }

        private void cboxAllOrHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayAnnouncements();
        }

        private void DisplayAnnouncements() 
        {
            Building building = buildingController.GetUserBuilding(currentUser);
            House house = buildingController.GetUserHouse(currentUser);

            if (cboxAllOrHouse.Text == "All")
            {
                flpAnnouncements.Controls.Clear();
                foreach (Message buildingAnnouncement in building.Announcements)
                {
                    UserControlAnnouncement ucAnnouncement = new UserControlAnnouncement();
                    flpAnnouncements.Controls.Add(ucAnnouncement);
                    ucAnnouncement.Announcements(buildingAnnouncement); 
                }
                foreach (Message houseAnnouncement in house.Announcements)
                {
                    UserControlAnnouncement ucAnnouncement = new UserControlAnnouncement();
                    flpAnnouncements.Controls.Add(ucAnnouncement);
                    ucAnnouncement.Announcements(houseAnnouncement);
                }
            }

            if (cboxAllOrHouse.Text == "Building") 
            {
                flpAnnouncements.Controls.Clear();
                foreach (Message buildinAnnouncement in building.Announcements) 
                {
                    UserControlAnnouncement ucAnnouncement = new UserControlAnnouncement();
                    flpAnnouncements.Controls.Add(ucAnnouncement);
                    ucAnnouncement.Announcements(buildinAnnouncement);
                }
            }

            if (cboxAllOrHouse.Text == "House")
            {
                flpAnnouncements.Controls.Clear();
                foreach (Message houseAnnouncement in house.Announcements)
                {
                    UserControlAnnouncement ucAnnouncement = new UserControlAnnouncement();
                    flpAnnouncements.Controls.Add(ucAnnouncement);
                    ucAnnouncement.Announcements(houseAnnouncement);
                }
            }

            ChangeElementsSize();

        }

        private void flpAnnouncements_SizeChanged(object sender, EventArgs e)
        {
            ChangeElementsSize();
        }

        public void ChangeElementsSize()
        {
            if (this.Size.Width > 1000)
            {
                foreach (UserControlAnnouncement ucAnnou in flpAnnouncements.Controls)
                {
                    ucAnnou.Width = this.Size.Width - 40;
                }
            }
            else
            {
                foreach (UserControlAnnouncement ucAnnou in flpAnnouncements.Controls)
                {
                    ucAnnou.Width = 855;
                }
            }
        }
    }
}
