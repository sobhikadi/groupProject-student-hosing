using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    public class Chore
    {
        private string name;
        private string date;
        private User user;

        public Chore(string name, string date, User user)
        {
            this.name = name;
            this.date = date;
            this.user = user;
        }

        public string GetInfo() 
        {
            return $"{name} - {user.Name}";
        }

    }
}
