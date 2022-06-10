using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    public class Message
    {
        public string header 
        { get; private set; }
        public string body 
        { get; private set; }
        public DateTime dateTime 
        { get; private set; }
        public User User { get; private set; }

        public Message(string header, string body, User user, DateTime dateTime)
        {
            this.header = header;
            this.body = body;
            User = user;
            this.dateTime = dateTime;
            
        }
    }
}
