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
    public partial class BuildingAdministration : Form
    {
        BuildingController buildingController;
        public BuildingAdministration(BuildingController buildingController)
        {
            InitializeComponent();
            this.buildingController = buildingController;
        }

        private void btnAddBuilding_Click(object sender, EventArgs e)
        {
            //string address = ($tbStreetAndNumber.Text + 
            //buildingController.NewBuilding()
        }
    }
}
