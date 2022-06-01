using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_Managment
{
    public class BuildingController
    {
        public List<Building> Buildings
        { get; private set; }

        public BuildingController()
        {
            Buildings = new List<Building>();
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
