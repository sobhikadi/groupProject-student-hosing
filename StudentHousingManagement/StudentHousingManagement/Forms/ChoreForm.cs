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
    public partial class ChoreForm : Form
    {
        string choreDate;
        public ChoreForm()
        {
            InitializeComponent();
        }

        private void ChoreForm_Load(object sender, EventArgs e)
        {
            tbDate.Text = $"{UserControlDays.Static_Day:00}/{ChoreShedule.Static_Month:00}/{ChoreShedule.Static_Year}";
            choreDate = tbDate.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
    }
}
