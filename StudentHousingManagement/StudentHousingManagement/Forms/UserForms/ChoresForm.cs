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
    public partial class ChoresForm : Form
    {
        List<Chore> chores;
        public ChoresForm(List<Chore> chores)
        {
            InitializeComponent();
            this.chores = chores;
        }

        private void ChoresForm_Load(object sender, EventArgs e)
        {
            lboxChores.Items.Clear();
            foreach (Chore chore in chores) 
            {
                if (chore.Date == $"{UserControlDays.Static_Day:00}/{ChoreShedule.Static_Month:00}/{ChoreShedule.Static_Year}")
                {
                    lboxChores.Items.Add(chore);
                }
            }

        }
    }
}
