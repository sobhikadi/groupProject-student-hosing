using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_Managment
{
    public class UserController
    {
        private int userIdFeeder;

        public List<User> Users
        { get; private set; }
        public Admin Admin
        { get; private set; }

        private UserController()
        {
            Users = new List<User>();
            Admin = new Admin("Admin", "password");
            userIdFeeder = 0;
        }

        public void NewUser(string userName, string password, string email)
        {
            Users.Add(new User(userName, password, email, userIdFeeder));
            userIdFeeder++;
        }

        public void NewAdmin(string userName, string password)
        {
            Admin = new Admin(userName, password);
        }

        public void NewMessage(string subject, string body, User user)
        {
            Message message = new Message(subject, body, user);

        }
    }
}
