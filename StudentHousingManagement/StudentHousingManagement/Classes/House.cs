using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    [Serializable]
    public class House
    {
        public ChoreSchedule ChoreSchedule 
        { get; private set; }
        public Building Building
        { get; private set; }
        public List<User> Residents
        { get; private set; }
        public List<Message> Announcements
        { get; private set; }
        
        public string HouseNumber
        { get; private set; }
        public int NoOfResidents
        { get; private set; }
        public string HouseRules
        { get; private set; }

        public House(Building building, int noOfResidents, string houseNumber)
        {
            Building = building;
            NoOfResidents = noOfResidents;
            HouseNumber = houseNumber;

            ChoreSchedule = new ChoreSchedule();
            Residents = new List<User>();
            Announcements = new List<Message>();
        }

        public void AddResident(User resident)
        {
            Residents.Add(resident);
            SaveMe();
        }
        public void RemoveResident(User resident)
        {
            Residents.Remove(resident);
            SaveMe();
        }

        public bool RoomAvailable()
        { return Residents.Count < NoOfResidents; }

        public void NewHouseRules(string rules)
        {
            HouseRules = rules;
            SaveMe();
        }

        public void SaveMe()
        {
            BuildingController buildingController = new BuildingController();
            buildingController.SaveBuilding(this.Building);
        }

        public override string ToString()
        {
            return $"House Number: {HouseNumber}";
        }
    }
}
