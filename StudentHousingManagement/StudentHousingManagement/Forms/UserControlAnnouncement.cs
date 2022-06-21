using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentHousingManagementForms
{
    public partial class UserControlAnnouncement : UserControl
    {
        StudentHousingManagement.Message messageToShow;

        public UserControlAnnouncement()
        {
            InitializeComponent();
        }

        public void Announcements(StudentHousingManagement.Message message) 
        {
            messageToShow = message;
            lblUserName.Text = message.User.Name;
            lblAnnouncementTitle.Text = message.Header;
            if (message.Body.Length > 50)
            {
                lblAnnouncementBody.Text = message.Body.Substring(0, 25) + "...";
            }
            else if (message.Body.Length < 50) 
            {
                lblAnnouncementBody.Text = message.Body.Substring(0, 10) + "...";
            }

                lblAnnouncementDate.Text = message.DateTime.ToString();

        }

        private void UserControlAnnouncement_Click(object sender, EventArgs e)
        {
            DisplayFullAnnouncement displayAnnouncement = new DisplayFullAnnouncement(messageToShow);
            displayAnnouncement.Show();

        }

        
    }
}
