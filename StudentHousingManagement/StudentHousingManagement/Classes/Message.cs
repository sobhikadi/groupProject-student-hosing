using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    public class Message
    {
        private string header;
        private string body;
        private DateTime dateTime;
        public User User { get; private set; }

        public Message(string header, string body, User user)
        {
            this.header = header;
            this.body = body;
            User = user;
            
        }
    }
}
