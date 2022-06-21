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
    public partial class ChoreForm : Form
    {
        public static bool Is_Visible = false;
        string choreDate;
        User user;

        public ChoreForm(User user)
        {
            InitializeComponent();
            this.user = user;
            tbChore.Focus();
        }

        private void ChoreForm_Load(object sender, EventArgs e)
        {
            tbDate.Text = $"{UserControlDays.Static_Day:00}/{ChoreShedule.Static_Month:00}/{ChoreShedule.Static_Year}";
            choreDate = tbDate.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Is_Visible = true;
            user.House.ChoreSchedule.AddNewChore(tbChore.Text, choreDate, user.Name);
            this.Close();
        }

        private void tbChore_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) 
            {
                Is_Visible = true;
                user.House.ChoreSchedule.AddNewChore(tbChore.Text, choreDate, user.Name);
                this.Close();
            }
        }
    }
}
