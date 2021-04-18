using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Budget.Classes;

namespace Budget
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Manager m1 = Manager.GetInstance();
            Zakup samochód = new Zakup("Audi a8", 800.0);
            Usługa abonament = new Usługa("Play", 90.0);
            m1.NowyWydatek(samochód);
            m1.NowyWydatek(abonament);
            m1.WypiszUsługi();

        }
    }
}
