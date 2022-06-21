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


        public UserDashboard(User user)
        {
            InitializeComponent();
            currentUser = user;
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
            if (cboxAllOrHouse.Text == "All")
            {
                flpAnnouncements.Controls.Clear();
                foreach (Message buildingAnnouncement in currentUser.House.Building.Announcements)
                {
                    UserControlAnnouncement ucAnnouncement = new UserControlAnnouncement();
                    flpAnnouncements.Controls.Add(ucAnnouncement);
                    ucAnnouncement.Announcements(buildingAnnouncement); 
                }
                foreach (Message houseAnnouncement in currentUser.House.Announcements)
                {
                    UserControlAnnouncement ucAnnouncement = new UserControlAnnouncement();
                    flpAnnouncements.Controls.Add(ucAnnouncement);
                    ucAnnouncement.Announcements(houseAnnouncement);
                }
            }

            if (cboxAllOrHouse.Text == "Building") 
            {
                flpAnnouncements.Controls.Clear();
                foreach (Message buildinAnnouncement in currentUser.House.Building.Announcements) 
                {
                    UserControlAnnouncement ucAnnouncement = new UserControlAnnouncement();
                    flpAnnouncements.Controls.Add(ucAnnouncement);
                    ucAnnouncement.Announcements(buildinAnnouncement);
                }
            }

            if (cboxAllOrHouse.Text == "House")
            {
                flpAnnouncements.Controls.Clear();
                foreach (Message houseAnnouncement in currentUser.House.Announcements)
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
