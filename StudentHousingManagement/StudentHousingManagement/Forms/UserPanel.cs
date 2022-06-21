﻿using StudentHousingManagementForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentHousingManagement;

namespace StudentHousingManagementForms
{
    public partial class UserPanel : Form
    {
        private Button currentButton;
        private Form activeForm;
        private LogIn logIn;

        UserController userController;

        public UserPanel(LogIn logIn, UserController userController)
        {
            InitializeComponent();   
            this.logIn = logIn;
            this.userController = userController;
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            UserDashboard userDashboard= new UserDashboard(userController);
            userDashboard.TopLevel = false;
            this.pContainer.Controls.Add(userDashboard);
            userDashboard.BringToFront();
            userDashboard.Show();
            btnDashboard.BackColor = Color.DeepSkyBlue;
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Font = new System.Drawing.Font("Segoe UI", 13.5F);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.DeepSkyBlue;
                    currentButton.ForeColor = Color.Black;
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
                    previousBtn.BackColor = Color.Linen;
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
            OpenChildForm(new UserDashboard(userController), sender);
        }

        private void btnChoreShedule_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChoreShedule(userController), sender);

        }

        private void btnWhoPaysWhat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WhoPaysWhat(), sender);

        }

        private void btnCreateAnnoucement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateAnnoucementUser(userController), sender);

        }

        private void btnFileComplaint_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FileComplaint(userController), sender);

        }
        private void btnBuildingHouseRules_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BuildingHouseRules(), sender);

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
