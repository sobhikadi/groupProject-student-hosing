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
    public partial class AdminPanel : Form
    {
        UserController userController;
        BuildingController buildingController;

        Button currentButton;
        Form activeForm;
        LogIn logIn;
        public AdminPanel(LogIn logIn, UserController userController, BuildingController buildingController)
        {
            InitializeComponent();
            this.userController = userController;
            this.buildingController = buildingController;
            this.logIn = logIn;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.DarkGray;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Segoe UI", 13.5F);
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in pMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(224, 224, 224);
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Segoe UI", 12F);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pContainer.Controls.Add(childForm);
            this.pContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Dashboard(), sender);
        }

        private void btnBuildingAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BuildingAdministration(buildingController), sender);
        }

        private void btnUserAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserAdministration(userController, buildingController), sender);
        }

        private void btnCreateAnnoucement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateAnnoucement(), sender);
        }

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Complaints(), sender);
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MyProfile(), sender);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            logIn.Show();
            this.Close();
        }
    }
}
