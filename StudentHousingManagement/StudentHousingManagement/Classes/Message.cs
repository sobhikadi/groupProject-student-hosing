using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    [Serializable]
    public class Message
    {
        public string Header 
        { get; private set; }
        public string Body 
        { get; private set; }
        public DateTime dateTime
        { get; private set; }
        public string Name
        { get; private set; }
        public User User { get; private set; }
        public Admin Admin { get; private set; }

        public Message(string header, string body, User user, DateTime dateTime)
        {
            Header = header;
            Body = body;
            User = user;
            this.dateTime = dateTime;
            Name = user.Name;
        }

        public Message(string header, string body, Admin admin, DateTime dateTime)
        {
            Header = header;
            Body = body;
            Admin = admin;
            this.dateTime = dateTime;
            Name = admin.Name;
        }
    }
}
