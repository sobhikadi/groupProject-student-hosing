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

            NewBuilding("Tilburg, Korvelse Weg 51-74", 4);
        }

        public void NewBuilding(string address, int noOfHouses)
        {
            Buildings.Add(new Building(address, noOfHouses));
        }

        public void NewAnnoucement(string header, string message,DateTime dateTime, string user)
        {
            
        }

        public void NewChoreSchedule()
        {

        }
    }
}
