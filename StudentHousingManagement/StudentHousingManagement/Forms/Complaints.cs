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
    public partial class Complaints : Form
    {
        BuildingController buildingController;
        public Complaints(BuildingController buildingController)
        {
            InitializeComponent();
            this.buildingController = buildingController;
        }

        private void Complaints_Load(object sender, EventArgs e)
        {
            cboxBuildings.Items.Clear();
            cboxBuildings.DataSource = buildingController.Buildings;
        }

        private void cboxBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayComplaints();
        }

        private void cboxProcessedOrNot_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayComplaints();
        }

        private void DisplayComplaints()
        {
            foreach (Building building in buildingController.Buildings)
            {
                if ((Building)cboxBuildings.SelectedItem == building)
                {
                    flpComplaints.Controls.Clear();
                    foreach (StudentHousingManagement.Message complaint in building.Complaints)
                    {
                        UserControlComplaints ucComplaint = new UserControlComplaints();
                        flpComplaints.Controls.Add(ucComplaint);
                        ucComplaint.Complaints(complaint);
                    }

                }
            }
        }

        private void flpComplaints_SizeChanged(object sender, EventArgs e)
        {
            ChangeElementsSize();
        }

        public void ChangeElementsSize()
        {
            if (this.Size.Width > 1000)
            {
                foreach (UserControlComplaints ucComplai in flpComplaints.Controls)
                {
                    ucComplai.Width = this.Size.Width - 40;
                }
            }
            else
            {
                foreach (UserControlComplaints uccompla in flpComplaints.Controls)
                {
                    uccompla.Width = 855;
                }

            }
        }

       
    }
}
