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
    public partial class CreateAnnouncementAdmin : Form
    {
        User currentUser;
        MessageController messageController;
        public CreateAnnouncementAdmin(UserController userController)
        {
            InitializeComponent();
            messageController = new MessageController();
            currentUser = userController.CurrentUser;
        }

        private void btnPublishAnnouncement_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbAnnouncementTitle.Text))
            {
                MessageBox.Show("Please enter a title.");
                return;
            }
            if (String.IsNullOrEmpty(tbAnnouncementDescription.Text))
            {
                MessageBox.Show("Please enter a description.");
            }
            messageController.NewAnnouncementBuilding(currentUser, tbAnnouncementTitle.Text,tbAnnouncementDescription.Text, DateTime.Now);
            MessageBox.Show("Announcement published succesfully.");
        }
    }
}
