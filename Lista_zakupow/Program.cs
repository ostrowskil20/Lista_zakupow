﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_zakupow
{
    class Program
    {
        static void Main(string[] args)
        {

            Koszyk MojKoszyk = new Koszyk();
            Produkt Produkt_1 = new Produkt("Jabłko", 1, "Jablko 1", 3);
            Produkt Produkt_2 = new Produkt("Gruszka", 2, "Gruszka 1", 4);
            Produkt Produkt_3 = new Produkt("śliwka", 3, "Śliwa 1", 2);
            Produkt Produkt_4 = new Produkt("Banan", 4, "Banana 1", 6);

            MojKoszyk.DodajDoKoszyka(Produkt_1);
            MojKoszyk.DodajDoKoszyka(Produkt_2);

            MojKoszyk.ZawartoscKoszyka();

            
            Console.ReadKey();


        }
    }
}
