using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    public class ChoreSchedule
    {

        public List<Chore> Chores
        { get; private set; }

        public ChoreSchedule() 
        {
            Chores = new List<Chore>();
        }

        public void NewChore(string name, string date, User user)
        {
            Chores.Add(new Chore(name, date, user));
        }
    }
}
