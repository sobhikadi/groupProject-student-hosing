using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    public class House
    {
        private int noOfResidents;
        private string houseNumber;
        private ChoreSchedule choreSchedule;
        private string houseRules;

        public Building Building
        { get; private set; }
        public List<User> Residents
        { get; private set; }
        public List<Message> Announcements
        { get; private set; }
        
        public House(Building building, int noOfResidents, string houseNumber)
        {
            Building = building;
            this.noOfResidents = noOfResidents;
            this.houseNumber = houseNumber;

            Residents = new List<User>();
            Announcements = new List<Message>();
        }

        public void AddResident(User resident)
        {
            Residents.Add(resident);
        }

        public void NewAnnouncement(string header, string body, User user, DateTime dateTime)
        {
            Announcements.Add(new Message(header, body, user, dateTime));
        }

        public void NewHouseRules(string rules)
        { }

        public override string ToString()
        {
            return $"House Number: {houseNumber}";
        }
    }
}
