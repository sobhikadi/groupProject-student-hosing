using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    internal class Expense
    {
        double amount;

        public List<User> Users
        { get; private set; }


        public Expense(List<User> users, double amount)
        {
            Users = users;
            this.amount = amount;
        }

        public void AddExpenseToUser(User user, double amount)
        {
            foreach (User user1 in Users)
            {
                if (user == user1)
                {
                    //user1.Balance += amount;
                }
            }
        }
    }
}
