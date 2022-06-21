using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    public class UserController
    {
        int IDFeeder;
        UserManager userManager;

        public User CurrentUser
        { get; private set; }

        public List<User> Users
        { get; private set; }
        public List<Admin> Admins
        { get; private set; }

        public UserController()
        {
            userManager = new UserManager();
            Users = userManager.Users;
            Admins = userManager.Admins;

            IDFeeder = 0;
            NewAdmin("Max Vaskovich", "admin");
        }

        public User? LogInUser(string email, string password)
        {
            foreach (User user in Users)
            {
                if (user.Email == email && user.Password == password)
                {
                    CurrentUser = (User)user;
                    return user;
                }            
            }
            return null;
        }

        public Admin? LogInAdmin(string email, string password)
        {
            foreach (Admin admin in Admins)
            {
                if (admin.Email == email && admin.Password == password)
                {
                    return admin;
                }
            }
            return null;
        }

        public bool NewUser(string name, string email, House house)
        {
            if (IsEmailUnique(email))
            {
                //User user = new User(name, RandomPassword(), email, IDFeeder, admin, house);
                User user = new User(name, "password", email, IDFeeder, house);
                Users.Add(user);
                userManager.SaveUsers(Users);

                house.Building.AddResident(user);
                house.AddResident(user);

                return true;
            }
            else return false;
        }

        public bool NewAdmin(string name, string email)
        {
            if (IsEmailUnique(email))
            {
                Admin admin = new Admin(name, email);
                Admins.Add(admin);
                userManager.SaveAdmins(Admins);
                return true;
            }
            else return false;
        }

        public void ChangeHouse(House house, User user)
        {
            user.House = house;
        }
        public bool IsEmailUnique(string email)
        {
            bool unique = true;

            if (Users.Count != 0)
            {
                foreach (User u in Users)
                {
                    if (u.Email == email)
                    { unique = false; }
                }
            }

            if (Admins.Count != 0)
            {
                foreach (Admin a in Admins)
                {
                    if (a.Email == email)
                    { unique = false; }
                }
            }
            return unique;
        }

        public string RandomPassword()
        {
            Random random = new Random();
            string password = "";
            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUWVXYZ12345678901234567890";

            for (int x = 0; x < 10; x++)
            {
                password += (characters[random.Next(characters.Length - 1)]);
            }
            return password;
        }
    }
}
