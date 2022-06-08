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
    public partial class UserControlDays : UserControl
    {
        public static string Static_Day;

        public UserControlDays()
        {
            InitializeComponent();
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
            ChoreForm choreForm = new ChoreForm();
            choreForm.Show();

        }
    }
}
