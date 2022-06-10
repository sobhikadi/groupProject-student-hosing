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
        public UserControlAnnouncement()
        {
            InitializeComponent();
        }

        public void Announcements(StudentHousingManagement.Message message) 
        {
            lblUserName.Text = message.User.Name;
            lblAnnouncementTitle.Text = message.header;
            lblAnnouncementBody.Text = message.body.Substring(0, 15);
            lblAnnouncementDate.Text = message.dateTime.ToString();

        }
    }
}
