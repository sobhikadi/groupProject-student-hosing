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
    public partial class CreateAnnouncementAdmin : Form
    {
        Admin admin;
        MessageController messageController;
        BuildingController buildingController;

        public CreateAnnouncementAdmin(Admin admin)
        {
            InitializeComponent();
            messageController = new MessageController();
            buildingController = new BuildingController();
            this.admin = admin;
            cboxBuildings.DataSource = null;
            cboxBuildings.DataSource = buildingController.Buildings;
        }

        private void btnPublishAnnouncement_Click(object sender, EventArgs e)
        {
            Building selectedBuilding = (Building)cboxBuildings.SelectedItem;

            if (String.IsNullOrEmpty(tbAnnouncementTitle.Text))
            {
                MessageBox.Show("Please enter a title.");
                return;
            }
            if (String.IsNullOrEmpty(tbAnnouncementDescription.Text))
            {
                MessageBox.Show("Please enter a description.");
                return;
            }
            if (selectedBuilding == null) 
            {
                MessageBox.Show("Please select a building first");
                return;
            }
            messageController.NewAnnouncementBuilding(admin, selectedBuilding, tbAnnouncementTitle.Text, tbAnnouncementDescription.Text, DateTime.Now);
            MessageBox.Show("Announcement published succesfully.");
        }
    }
}
