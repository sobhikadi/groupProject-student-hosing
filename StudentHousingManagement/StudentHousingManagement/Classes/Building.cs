using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    public class Building
    {
        private string address;
        private int ID;
        private int noOfHouses;
        private string buildingRules;
        private List<Message> announcements;
        private List<House> houseList;
        private List<Message> complaints;
        private List<User> residents;

        public Building(string address, int noOfHouses)
        {
            this.address = address;
            this.noOfHouses = noOfHouses;
        }

        public void NewBuildingRules(string rules)
        {

        }

        public void NewHouse(Building building,int noOfHouses)
        {

        }
    }
}
