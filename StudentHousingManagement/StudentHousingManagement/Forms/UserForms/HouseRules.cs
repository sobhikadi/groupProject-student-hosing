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
    public partial class HouseRules : Form
    {
        User user;
        public HouseRules(User user)
        {
            InitializeComponent();
            this.user = user;
            tbHouseRules.Text = user.House.HouseRules;
            tbBuildingRules.Text = user.House.Building.BuildingRules;
        }

        private void btnUpdateHouseRules_Click(object sender, EventArgs e)
        {
            user.House.NewHouseRules(tbHouseRules.Text);
            MessageBox.Show("House rules updated.");
        }
    }
}
