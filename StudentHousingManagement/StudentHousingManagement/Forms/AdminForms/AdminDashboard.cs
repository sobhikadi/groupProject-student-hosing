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
    public partial class AdminDashboard : Form
    {
        BuildingController buildingController;
        public AdminDashboard()
        {
            InitializeComponent();
            buildingController = new BuildingController();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            cboxBuildings.Items.Clear();
            cboxBuildings.DataSource = buildingController.Buildings;
        }

        private void cboxBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayAnnouncements();
        }

        private void DisplayAnnouncements()
        {
            foreach (Building building in buildingController.Buildings)
            {
                if ((Building)cboxBuildings.SelectedItem == building)
                {
                    flpAnnouncements.Controls.Clear();
                    foreach (StudentHousingManagement.Message Announcement in building.Announcements)
                    {
                        UserControlAnnouncement ucAnnouncement = new UserControlAnnouncement();
                        flpAnnouncements.Controls.Add(ucAnnouncement);
                        ucAnnouncement.Announcements(Announcement);
                    }

                }
            }
        }

        private void flpAnnouncements_SizeChanged(object sender, EventArgs e)
        {
            ChangeElementsSize();
        }

        public void ChangeElementsSize()
        {
            if (this.Size.Width > 1000)
            {
                foreach (UserControlAnnouncement ucAnnou in flpAnnouncements.Controls)
                {
                    ucAnnou.Width = this.Size.Width - 40;
                }
            }
            else
            {
                foreach (UserControlAnnouncement ucAnnou in flpAnnouncements.Controls)
                {
                    ucAnnou.Width = 855;
                }

            }
        }
    }
}
