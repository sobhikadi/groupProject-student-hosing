using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    public class BuildingController
    {
        public List<Building> Buildings
        { get; private set; }

        public BuildingController()
        {
            Buildings = new List<Building>();
            NewBuilding("Tilburg 5025TJ, Korvelse Weg 51-54", 4);
            NewBuilding("Eindhoven 1234BG, Eindhovense Weg 1-5", 5);
        }

        public void NewBuilding(string address, int noOfHouses)
        {
            Buildings.Add(new Building(address, noOfHouses));
            Buildings.Sort((a, b) => a.Address.CompareTo(b.Address));
        }

        public void NewAnnoucement(string header, string message,DateTime dateTime, string user)
        {
            
        }

        public void NewChoreSchedule()
        {

        }
    }
}
