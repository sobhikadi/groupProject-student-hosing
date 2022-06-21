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
        public void NewAnnouncementBuilding(User user, string header, string body, DateTime dateTime)
        {
            user.House.Building.Announcements.Add(new Message(header, body, user, dateTime));
        }

        public void NewAnnouncementBuilding(Admin admin, Building building, string header, string body, DateTime dateTime)
        {
            building.Announcements.Add(new Message(header, body, admin, dateTime));
        }

        public void NewAnnouncementHouse(User user, string header, string body, DateTime dateTime)
        {
            user.House.Announcements.Add(new Message(header, body, user, dateTime));
        }

        public void NewComplaint(User user, string header, string body, DateTime dateTime)
        {
            user.House.Building.Complaints.Add(new Message(header, body, user, dateTime));
        }
    }
}
