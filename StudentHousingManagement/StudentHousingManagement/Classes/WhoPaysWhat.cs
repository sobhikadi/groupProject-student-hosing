﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentHousingManagement
{
    internal class WhoPaysWhat
    {
        public List<User> Users
        { get; private set; }
        public List<Expense> Expenses
        { get; private set; }

        public WhoPaysWhat(List<User> users)
        {
            Users = users;
            Expenses = new List<Expense>();
        }

        public void NewExpense(double amount)
        {
            Expense expense = new Expense(Users, amount);
            Expenses.Add(expense);
        }

        
    }
}
