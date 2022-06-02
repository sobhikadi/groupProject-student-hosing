using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    public class UserController
    {
        private int IDFeeder;

        public User? CurrentUser
        { get; private set; }
        public List<User> Users
        { get; private set; }

        public UserController()
        {
            Users = new List<User>();
            IDFeeder = 0;
            NewUser("admin", "password", "email", true);
            NewUser("user", "password", "email", false);
        }

        public bool LogIn(string userName, string password)
        {
            foreach (User user in Users)
            {
                if (user.UserName == userName && user.Password == password)
                {
                    CurrentUser = user;
                    return true;
                }            
            }
            return false;
        }

        public void NewUser(string userName, string password, string email, bool admin)
        {
            User user = new User(userName, password, email, IDFeeder, admin);
            Users.Add(user);
            IDFeeder++;
        }

        public void NewMessage(string subject, string body, User user)
        {
            Message message = new Message(subject, body, user);
        }
    }
}
