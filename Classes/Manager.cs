using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Budget.Classes
{
    public class Manager
    {
        private List<Wydatek> listaWydatków = new List<Wydatek> { };

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

        public void NowyWydatek(Wydatek wydatek)
        {

            listaWydatków.Add(wydatek);
        }

        public List<Wydatek> ZwróćZakupy()
        {
            List<Wydatek> wydatki = new List<Wydatek>{ };
            foreach (Wydatek w in listaWydatków)
            {
                if(w is Zakup)
                {
                    wydatki.Add(w);
                }
            }
            return wydatki;
        }

        public List<Wydatek> ZwróćUsługi()
        {
            List<Wydatek> wydatki = new List<Wydatek> { };
            foreach (Wydatek w in listaWydatków)
            {
                if (w is Usługa)
                {
                    wydatki.Add(w);
                }
            }
            return wydatki;
        }

        public void WypiszZakupy()
        {
            foreach (object w in listaWydatków)
            {
                if (w is Zakup)
                {
                    Console.WriteLine(w.ToString());
                }
            }
        }

        public void WypiszUsługi()
        {
            foreach (object w in listaWydatków)
            {
                if (w is Usługa)
                {
                    Console.WriteLine(w.ToString());
                }
            }
        }

        public Wydatek ZnajdźWydatek(Wydatek W)
        {
            int index = listaWydatków.IndexOf(W);
            return listaWydatków[index];
        }


    }
}
