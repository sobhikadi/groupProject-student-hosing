using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    public class Building
    {
        int IDFeeder;
        int noOfHouses;
        string buildingRules;
        private List<Message> announcements;
        private List<Message> complaints;
        

        
        public List<User> Residents
        { get; private set; }
        public List<House> Houses
        { get; private set; }
       
        public string Address
        {get; private set; }

        public Building(string address, int noOfHouses)
        {
            Address = address;
            this.noOfHouses = noOfHouses;
            IDFeeder = 0;

            Houses = new List<House>();
            NewHouse(6, "51");
            Residents = new List<User>();
        }

        public bool NewHouse(int noOfResidents, string houseNumber)
        {
            if (noOfHouses > IDFeeder)
            {
                Houses.Add(new House(this, noOfResidents, houseNumber));
                IDFeeder++;
                return true;
            }
            else return false;
        }

        public void AddResident(User resident)
        {
            Residents.Add(resident);
        }

        public void NewBuildingRules(string rules)
        {

        }

        public override string ToString()
        {
            return Address;
        }
    }
}
