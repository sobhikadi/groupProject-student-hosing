using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Housing_Managment
{
    public class House
    {
        private string address;
        private int noOfResidents;
        private int ID;
        private List<User> residentList;
        private ChoreSchedule choreSchedule;
        private string houseRules;
        private List<Message> announcements;
        
        public House(Building building, int noOfResidents)
        {
            this.noOfResidents = noOfResidents; 
        }

        public void NewHouseRules(string rules)
        { }
    }
}
