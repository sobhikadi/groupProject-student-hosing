using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    [Serializable]
    internal class Expense
    {
        double amount;

        List<User> Users;
        List<double> doubles;

        public Expense(List<User> users, List<double> doubles)
        {
            Users = users;
            this.doubles = doubles;
            UpdateBalances();
        }

        public void UpdateBalances()
        {
            for (int i = 0; i < Users.Count; i++)
            {
                Users[i].UpdateBalance(doubles[i]);
            }
        }
    }
}
