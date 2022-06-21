using StudentHousingManagement;
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
    public partial class BuildingRules : Form
    {

        BuildingController buildingController;
        public BuildingRules()
        {
            InitializeComponent();
            buildingController = new BuildingController();
            UpdateComboBox();
        }

        private void btnUpdateBuildingRules_Click(object sender, EventArgs e)
        {
            Building building = (Building)cboxBuildings.SelectedItem;
            building.NewBuildingRules(tbBuildingRules.Text);
            MessageBox.Show("Building Rules Updated.");
        }

        private void cboxBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            Building building = (Building)cboxBuildings.SelectedItem;
            tbBuildingRules.Text = building.BuildingRules;
        }

        private void UpdateComboBox()
        {
            cboxBuildings.Items.Clear();
            foreach (Building building in buildingController.Buildings)
            {
                cboxBuildings.Items.Add(building);
            }
        }
    }
}
