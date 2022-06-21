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
    public partial class MyProfileUser : Form
    {
        User user;
        public MyProfileUser(User user)
        {
            InitializeComponent();
            this.user = user;

            tbStudentName.Text = user.Name;
            tbStudentEmail.Text = user.Email;
            tbStudentPassword.Text = user.Password;
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            bool name = !String.IsNullOrEmpty(tbStudentName.Text);
            bool email = !String.IsNullOrEmpty(tbStudentEmail.Text);
            bool password = !String.IsNullOrEmpty(tbStudentPassword.Text);

            if (name && email && password)
            { user.UpdateInfo(tbStudentName.Text, tbStudentEmail.Text, tbStudentPassword.Text); }
            
        }
    }
}
