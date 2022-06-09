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
    public partial class Dashboard : Form
    {
        UserController userController;

        public Dashboard(UserController userController)
        {
            InitializeComponent();
            this.userController = userController;
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
                foreach (StudentHousingManagement.Message announcement in userController.CurrentUser.House.Building.Announcements)
                {
                    UserControlAnnouncement ucAnnouncement = new UserControlAnnouncement();
                    flpAnnouncements.Controls.Add(ucAnnouncement);
                }
                foreach (StudentHousingManagement.Message announcement in userController.CurrentUser.House.Announcements)
                {
                    UserControlAnnouncement ucAnnouncement = new UserControlAnnouncement();
                    flpAnnouncements.Controls.Add(ucAnnouncement);
                }
            }

            if (cboxAllOrHouse.Text == "Building") 
            {
                flpAnnouncements.Controls.Clear();
                foreach (StudentHousingManagement.Message announcement in userController.CurrentUser.House.Building.Announcements) 
                {
                    UserControlAnnouncement ucAnnouncement = new UserControlAnnouncement();
                    flpAnnouncements.Controls.Add(ucAnnouncement);
                }
            }

            if (cboxAllOrHouse.Text == "House")
            {
                flpAnnouncements.Controls.Clear();
                foreach (StudentHousingManagement.Message announcement in userController.CurrentUser.House.Announcements)
                {
                    UserControlAnnouncement ucAnnouncement = new UserControlAnnouncement();
                    flpAnnouncements.Controls.Add(ucAnnouncement);
                }
            }


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
                    ucAnnou.Width = 845;
                }

            }
        }
    }
}
