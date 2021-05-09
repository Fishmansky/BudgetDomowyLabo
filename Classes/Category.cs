using System;
namespace Budget.Classes
{
    public class Category
    {
        private int id;
        private string title;

        public int Id
        {
            get => id;
        }

        public string Title
        {
            get => title;
            set
            {
                if (value == null)
                {
                    throw new Exception("Title cannot be of type NULL!"); 
                } else
                {
                    title = value;
                }
            }
        }
        public Category(string w_title)
        {
            Title = w_title;
        }
    }
}
