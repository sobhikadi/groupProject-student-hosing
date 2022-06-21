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
    public partial class CreateAnnouncementUser : Form
    {
        User currentUser;
        MessageController messageController;
        BuildingController buildingController;

        public CreateAnnouncementUser(User user)
        {
            InitializeComponent();
            messageController = new MessageController();
            buildingController = new BuildingController();
            currentUser = user;
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
                messageController.NewAnnouncementBuilding(currentUser, tbAnnouncementTitle.Text,
                tbAnnouncementDescription.Text, DateTime.Now);
                buildingController.buildingManager.SaveBuilding(currentUser.House.Building);

            }
            else if(rbHouse.Checked == true)
            {
                messageController.NewAnnouncementHouse(currentUser, tbAnnouncementTitle.Text,
                tbAnnouncementDescription.Text, DateTime.Now);
                buildingController.buildingManager.SaveBuilding(currentUser.House.Building);
            }
            MessageBox.Show("Announcement published succesfully.");
        }
    }
}
