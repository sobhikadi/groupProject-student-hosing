using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_Managment
{
    public class User
    {
        private string password;

        public List<Message> Complaints 
        { get; private set; }

        public int ID
        { get; private set; }
        public string UserName
        { get; private set; }
        public string Email
        { get; private set; }
        public int PhoneNumber
        { get; private set; }

        public House House
        { get; private set; }

        public User(string name, string password, string email, int id)
        {
            UserName = name;
            Email = email;
            this.password = password;
            ID = id;

            Complaints = new List<Message>();
        }
       

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (oldPassword == password)
            { password = newPassword; return true; }
            else return false;
        }

        public void NewComplaint(string subject, string body, DateTime time)
        {
            Message complaint = new Message(subject, body, this);
            Complaints.Add(complaint);

        }

    }
}
