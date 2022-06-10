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
            UpdateBuildingList();
        }

        private void btnAddBuilding_Click(object sender, EventArgs e)
        {
            buildingController.NewBuilding($"{tbCity.Text} {tbZIP.Text}, {tbStreetAndNumber.Text}", (int)nudNoOfHouses.Value);
            UpdateBuildingList();
        }

        private void btnAddHouse_Click(object sender, EventArgs e)
        {
            Building building = (Building)cboxBuilding.SelectedItem;
            if (!building.HouseAvailable())
            {
                MessageBox.Show("This building already has the maximum number of houses.");
                return;
            }

            if (building.NewHouse((int)nudNoOfResidents.Value, tbHouseNumber.Text))
            {
                MessageBox.Show("House added succesfully.");
                //cboxBuilding.SelectedIndex = 0;
                UpdateHouseList(building);
            }
            else MessageBox.Show("This house number is already in use.");
        }

        private void UpdateBuildingList()
        {
            cboxBuilding.DataSource = null;
            cboxBuilding.DataSource = buildingController.Buildings;
        }

        private void UpdateHouseList(Building building)
        {
            lboxHouses.DataSource = null;
            lboxHouses.DataSource = building.Houses;
        }

        private void cboxBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxBuilding.SelectedItem != null)
            { 
                Building building = (Building)cboxBuilding.SelectedItem;
                UpdateHouseList(building);
                tbNoOfHouses.Text = building.NoOfHouses.ToString();
            }
            
        }
    }
}
