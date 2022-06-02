using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    public class Chore
    {
        private string name;
        private int weekNumber;
        private User user;

        public Chore(string name, int weekNumber, User user)
        {
            this.name = name;
            this.weekNumber = weekNumber;
            this.user = user;
        }

    }
}
