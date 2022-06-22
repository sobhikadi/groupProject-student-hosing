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
        House house;
        public HouseRules(User user)
        {
            InitializeComponent();
            this.user = user;

            BuildingController buildingController = new BuildingController();
            house = buildingController.GetUserHouse(user);

            tbHouseRules.Text = house.HouseRules;
            tbBuildingRules.Text = house.Building.BuildingRules;
        }

        private void btnUpdateHouseRules_Click(object sender, EventArgs e)
        {
            house.NewHouseRules(tbHouseRules.Text);

            MessageBox.Show("House rules updated.");
        }
    }
}
