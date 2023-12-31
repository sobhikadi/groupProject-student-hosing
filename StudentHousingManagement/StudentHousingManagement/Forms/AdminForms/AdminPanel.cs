﻿using System;
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
        Admin admin;

        Button currentButton;
        Form activeForm;
        LogIn logIn;
        public AdminPanel(LogIn logIn, Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.logIn = logIn;
        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.TopLevel = false;
            this.pContainer.Controls.Add(adminDashboard);
            adminDashboard.BringToFront();
            adminDashboard.Show();
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
            OpenChildForm(new AdminDashboard(), sender);
        }

        private void btnBuildingAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BuildingAdministration(), sender);
        }

        private void btnUserAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UserAdministration(), sender);
        }

        private void btnCreateAnnoucement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateAnnouncementAdmin(admin), sender);
        }

        private void btnComplaints_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Complaints(), sender);
        }
        private void btnBuildingRules_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BuildingRules(), sender);
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
