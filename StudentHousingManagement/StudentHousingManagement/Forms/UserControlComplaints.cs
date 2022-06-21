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
    public partial class UserControlComplaints : UserControl
    {
        StudentHousingManagement.Message complaintToShow;
        public UserControlComplaints()
        {
            InitializeComponent();
        }

        public void Complaints(StudentHousingManagement.Message message)
        {
            complaintToShow = message;
            lblUserName.Text = message.User.Name;
            lblComplaintTitle.Text = message.Header;
            if (message.Body.Length > 50)
            {
                lblComplaintBody.Text = message.Body.Substring(0, 25) + "...";
            }
            else if (message.Body.Length < 50)
            {
                lblComplaintBody.Text = message.Body.Substring(0, 10) + "...";
            }

            lblComplaintDate.Text = message.DateTime.ToString();

        }

        private void UserControlComplaints_Click(object sender, EventArgs e)
        {
            DisplayFullAnnouncement displayComplaint = new DisplayFullAnnouncement(complaintToShow);
            displayComplaint.Show();
        }
    }
}
