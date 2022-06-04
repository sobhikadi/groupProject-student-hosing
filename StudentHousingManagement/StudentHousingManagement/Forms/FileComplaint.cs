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
    public partial class FileComplaint : Form
    {
        UserController userController;
        public FileComplaint(UserController userController)
        {
            InitializeComponent();
            this.userController = userController;
        }

        private void btnPublishComplaint_Click(object sender, EventArgs e)
        {
            //Check if the textboxes contain text.
            if(String.IsNullOrEmpty(tbComplaintTitle.Text))
            {
                MessageBox.Show("Please enter a title.");
                return;
            }
            if(String.IsNullOrEmpty(tbComplaintDescription.Text))
            {
                MessageBox.Show("Please enter a description.");
                return;
            }

            //Post a new complaint.
            userController.CurrentUser.House.Building.NewComplaint(tbComplaintTitle.Text,
                tbComplaintDescription.Text, userController.CurrentUser, DateTime.Now);
            MessageBox.Show("Complaint successfully posted.");
        }
    }
}
