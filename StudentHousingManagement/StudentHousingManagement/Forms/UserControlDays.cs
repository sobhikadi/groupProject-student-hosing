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
    public partial class UserControlDays : UserControl
    {
        public static string Static_Day;
        User currentUser;

        public UserControlDays(User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {
        }

        public void Days(int numsDays)
        {
            lblDaysNum.Text = numsDays.ToString();
        }

        private void UserControlDays_Click(object sender, EventArgs e)
        {
            Static_Day = lblDaysNum.Text;
            ChoreForm choreForm = new ChoreForm(currentUser);
            choreForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ChoresForm chores = new ChoresForm(currentUser.House.ChoreSchedule.Chores);
            chores.Show();
        }

        private void UserControlDays_Leave(object sender, EventArgs e)
        { 
            if (ChoreForm.Is_Visible) { label1.Visible = true; }
            ChoreForm.Is_Visible = false;
        }
    }
}
