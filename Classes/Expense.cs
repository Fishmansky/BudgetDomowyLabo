using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Budget.Classes;

namespace Budget
{
    public class Expense
    {

        private int category;
        private string description;
        private double cost;
        private DateTime data;

        public int Category
        {
            get => category;
            set
            {
                if (value == null)
                {
                    throw new Exception("Type cannot be of type NULL!");
                }
                else
                {
                    category = value;
                }
            }

        }

        public string Description
        {
            get => description;
            set
            {
                if (value == null)
                {
                    throw new Exception("Description cannot be of type NULL!");
                }
                else
                {
                    description = value;
                }
            }

        }
        public double Cost {
            get => cost;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Cost must be higher than 0!");
                } else
                {
                    cost = value;
                }
            }
        }
        public DateTime Data {
            get => data;
            set
            {
                if (value == null)
                {
                    throw new Exception("Data cannot be of type NULL");
                } else
                {
                    data = value;
                }
            }
        }

        public Expense(int w_cat, string w_desc, double w_cost)
        {
            Category = w_cat;
            Description = w_desc;
            Cost = w_cost;
            Data = DateTime.Now;
        }

    }
}