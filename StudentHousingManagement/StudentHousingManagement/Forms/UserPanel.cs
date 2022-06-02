﻿using StudentHousingManagementForms;
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
    public partial class UserPanel : Form
    {
        private Button currentButton;
        private Form activeForm;
        private LogIn logIn;

        public UserPanel(LogIn logIn)
        {
            InitializeComponent();   
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

        private void btnChoreShedule_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ChoreShedule(), sender);

        }

        private void btnWhoPaysWhat_Click(object sender, EventArgs e)
        {
            OpenChildForm(new WhoPaysWhat(), sender);

        }

        private void btnCreateAnnoucement_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateAnnoucement(), sender);

        }

        private void btnFileComplaint_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FileComplaint(), sender);

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