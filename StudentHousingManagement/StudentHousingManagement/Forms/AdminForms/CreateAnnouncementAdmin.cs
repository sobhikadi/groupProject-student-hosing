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
        Admin admin;
        MessageController messageController;

        public CreateAnnouncementAdmin(Admin admin)
        {
            InitializeComponent();
            messageController = new MessageController();
            this.admin = admin;
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
            messageController.NewAnnouncementBuilding(admin, building, tbAnnouncementTitle.Text,tbAnnouncementDescription.Text, DateTime.Now);
            MessageBox.Show("Announcement published succesfully.");
        }
    }
}
