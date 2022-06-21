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
    public partial class CreateAnnouncementUser : Form
    {
        User currentUser;
        Admin currentAdmin;
        MessageController messageController;

        public CreateAnnouncementUser(User user)
        {
            InitializeComponent();
            messageController = new MessageController();
            currentUser = user;
        }

        public CreateAnnouncementUser(Admin admin)
        {
            InitializeComponent();
            messageController = new MessageController();
            currentAdmin = admin;
        }

        private void btnPublishAnnouncement_Click(object sender, EventArgs e)
        {
            //Check if Radiobuttons have been checked and textboxes have been filled.
            //If not, show appropriate message.
            if (rbBuilding.Checked == false && rbHouse.Checked == false)
            { 
                MessageBox.Show("Please select a house or building.");
                return;
            }
            if (String.IsNullOrEmpty(tbAnnouncementTitle.Text))
            {
                MessageBox.Show("Please enter a title.");
                return;
            }
            if (String.IsNullOrEmpty(tbAnnouncementDescription.Text))
            {
                MessageBox.Show("Please enter a description.");
            }

            //Call functionality to add announcements to the proper Building or House.
            if(rbBuilding.Checked == true)
            {
                messageController.NewAnnouncementBuilding(currentUser, tbAnnouncementTitle.Text,
                tbAnnouncementDescription.Text, DateTime.Now);
            }
            else if(rbHouse.Checked == true)
            {
                messageController.NewAnnouncementHouse(currentUser, tbAnnouncementTitle.Text,
                tbAnnouncementDescription.Text, DateTime.Now);
            }
            MessageBox.Show("Announcement published succesfully.");
        }
    }
}