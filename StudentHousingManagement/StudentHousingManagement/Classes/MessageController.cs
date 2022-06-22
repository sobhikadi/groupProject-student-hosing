using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace StudentHousingManagement
{
    public class MessageController
    {
        BuildingController buildingController;
        public MessageController()
        {
            buildingController = new BuildingController();
        }

        public void NewAnnouncementBuilding(User user, string header, string body, DateTime dateTime)
        {
            Building building = buildingController.GetUserBuilding(user);
            building.Announcements.Add(new Message(header, body, user, dateTime));
            building.SaveMe();
        }

        public void NewAnnouncementBuilding(Admin admin, Building building, string header, string body, DateTime dateTime)
        {
            building.Announcements.Add(new Message(header, body, admin, dateTime));
            building.SaveMe();
        }

        public void NewAnnouncementHouse(User user, string header, string body, DateTime dateTime)
        {
            House house = buildingController.GetUserHouse(user);
            house.Announcements.Add(new Message(header, body, user, dateTime));
            house.Building.SaveMe();
        }

        public void NewComplaint(User user, string header, string body, DateTime dateTime)
        {
            Building building = buildingController.GetUserBuilding(user);
            building.Complaints.Add(new Message(header, body, user, dateTime));
            building.SaveMe();
        }
    }
}
