using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    public class Chore
    {
        public string ChoreName
         { get; private set; }

        public string Date
        { get; private set; }

        public string UserName
        { get; private set; }

        public Chore(string name, string date, string userName)
        {
            ChoreName = name;
            Date = date;
            UserName = userName;
        }

        public override string ToString() 
        {
            return $"{ChoreName} by {UserName}";
        }

    }
}
