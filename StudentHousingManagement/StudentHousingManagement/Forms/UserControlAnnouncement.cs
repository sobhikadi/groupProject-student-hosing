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
            lblUserName.Text = message.Name;
            lblAnnouncementTitle.Text = message.header;
            if (message.body.Length > 50)
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
