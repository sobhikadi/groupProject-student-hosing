using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    [Serializable]
    public class Admin
    {
        public string Name
        { get; private set; }
        public string Email
        { get; private set; }
        public string Password
        { get; private set; }

        public Admin(string name, string email)
        {
            Name = name;
            Email = email;
            Password = "password";
        }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (oldPassword == Password)
            { Password = newPassword; return true; }
            else return false;
        }

        public override string ToString()
        {
            return Name + " - " + Email;
        }
    }
}
