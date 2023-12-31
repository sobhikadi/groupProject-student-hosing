﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    [Serializable]
    public class User
    {
        public List<Message> Complaints
        { get; private set; }
        public House House
        { get; set; }

        public string Name
        { get; private set; }
        public string Password
        { get; private set; }
        public string Email
        { get; private set; }

        public double Balance
        { get; private set; }

        public User(string name, string password, string email, House house)
        {
            Name = name;
            Email = email;
            Password = password;
            House = house;

            Complaints = new List<Message>();
        }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (oldPassword == Password)
            { Password = newPassword; return true; }
            else return false;
        }

        public void NewComplaint(string subject, string body, DateTime time)
        {
            Message complaint = new Message(subject, body, this, DateTime.Now);
            Complaints.Add(complaint);
        }

        public void UpdateInfo(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        public void UpdateBalance(double amount)
        {
            Balance += amount;
        }

        public override string ToString()
        {
            return Name + " - " + Email;
        }
    }
}
