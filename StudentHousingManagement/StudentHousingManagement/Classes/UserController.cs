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
        BuildingController buildingController;

        public User? CurrentUser
        { get; private set; }
        public List<User> Users
        { get; private set; }

        public UserController(BuildingController buildingController)
        {
            this.buildingController = buildingController;

            Users = new List<User>();
            IDFeeder = 0;
            NewUser("Max Vaskovich", "password", "admin", true, buildingController.Buildings[0].Houses[0]);
            NewUser("Sobhi Kadi", "password", "user", false, buildingController.Buildings[0].Houses[0]);
        }

        public bool LogIn(string email, string password)
        {
            foreach (User user in Users)
            {
                if (user.Email == email && user.Password == password)
                {
                    CurrentUser = user;
                    return true;
                }            
            }
            return false;
        }

        public bool NewUser(string name, string password, string email, bool admin, House house)
        {
            foreach(User u in Users)
            {
                if (u.Email == email)
                { return false; }
            }

            User user = new User(name, password, email, IDFeeder, admin, house);
            Users.Add(user);

            house.Building.AddResident(user);
            house.AddResident(user);

            IDFeeder++;
            return true;
        }
        public bool NewUser(string name, string email, bool admin, House house)
        {
            foreach (User u in Users)
            {
                if (u.Email == email)
                { return false; }
            }
            //User user = new User(name, RandomPassword(), email, IDFeeder, admin, house);
            User user = new User(name, "password", email, IDFeeder, admin, house);
            Users.Add(user);
            IDFeeder++;
            return true;
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
