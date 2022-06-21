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
    public partial class DisplayFullAnnouncement : Form
    {
        public DisplayFullAnnouncement(StudentHousingManagement.Message message)
        {
            InitializeComponent();

            tbAnnouncementTitle.Text = message.Header;
            tbAnnouncementDescription.Text = message.Body;
        }
    }
}
