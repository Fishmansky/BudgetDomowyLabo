using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Budget.Classes
{
    public class Manager
    {
        private List<Expense> ExpensesList = new List<Expense> { };

        private Manager()
        {
        }

        private static Manager instance;

        public static Manager GetInstance()
        {
            if (instance == null)
            {
                instance = new Manager();
            }
            return instance;
        }

        public void NewExpense(Expense wydatek)
        {

            ExpensesList.Add(wydatek);
        }

        public List<Expense> GetExpensesOfType(int w_cat){
            List<Expense> result = new List<Expense> { };
            foreach(var expense in ExpensesList)
            {
                if(expense.Category == w_cat)
                {
                    result.Add(expense);
                }
            }
            return result;

        }

        public Expense FindExpense(Expense W)
        {
            int index = ExpensesList.IndexOf(W);
            return ExpensesList[index];
        }


    }
}
