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
    public partial class CreateAnnoucement : Form
    {
        UserController userController;
        public CreateAnnoucement(UserController userController)
        {
            InitializeComponent();
            this.userController = userController;
        }

        private void btnPublishAnnouncement_Click(object sender, EventArgs e)
        {
            //Check if Radiobuttons have been checked and textboxes have been filled.
            //If not, show appropriate message.
            if (rbBuilding.Checked == false && rbHouse.Checked == false)
            { 
                MessageBox.Show("Please select a house or building.");
                return;
            }
            if (String.IsNullOrEmpty(tbAnnouncementTitle.Text))
            {
                MessageBox.Show("Please enter a title.");
                return;
            }
            if (String.IsNullOrEmpty(tbAnnouncementDescription.Text))
            {
                MessageBox.Show("Please enter a description.");
            }

            //Call functionality to add announcements to the proper Building or House.
            if(rbBuilding.Checked == true)
            {
                userController.CurrentUser.House.Building.NewAnnouncement(tbAnnouncementTitle.Text,
                tbAnnouncementDescription.Text, userController.CurrentUser, DateTime.Now);
            }
            else if(rbHouse.Checked == true)
            {
                userController.CurrentUser.House.NewAnnouncement(tbAnnouncementTitle.Text,
                tbAnnouncementDescription.Text, userController.CurrentUser, DateTime.Now);
            }
            MessageBox.Show("Announcement published succesfully.");
  
        }
    }
}
