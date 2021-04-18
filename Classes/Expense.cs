using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Budget.Classes;

namespace Budget
{
    public class Wydatek
    {
        private double koszt;
        public double Koszt {
            get => koszt;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Koszt nie może być mniejszy od zera!");
                } else
                {
                    koszt = value;
                }
            }
        }

        private DateTime data;
        public DateTime Data {
            get => data;
            set
            {
                if (value == null)
                {
                    throw new Exception("Data nie może być Null");
                } else
                {
                    data = value;
                }
            }
        }

        public Wydatek(){
            koszt = -1;
        }

    }

    public class Zakup : Wydatek
    {
        private string opis;
        public string Opis {
            get => opis;
            set
            {
                if(value == null)
                {
                    throw new Exception("Opis nie może być NULLem!");
                }
                else
                {
                    opis = value;
                }
            }

        }

        public Zakup(string w_opis, double w_koszt)
        {
            Opis = w_opis;
            Koszt = w_koszt;
            Data = DateTime.Now;
        }

        override public string ToString()
        {
            return $"Opis: {this.Opis} | Koszt: {this.Koszt} | Data: {this.Data}" ;
        }
    }

    public class Usługa : Wydatek
    {
        private string opis;
        public string Opis
        {
            get => opis;
            set
            {
                if (value == null)
                {
                    throw new Exception("Opis nie może być NULLem!");
                }
                else
                {
                    opis = value;
                }
            }
        }

        public Usługa(string w_opis, double w_koszt)
        {
            Opis = w_opis;
            Koszt = w_koszt;
            Data = DateTime.Now;
        }

        override public string ToString()
        {
            return $"Opis: {this.Opis} | Koszt: {this.Koszt} | Data: {this.Data}";
        }
    }
}