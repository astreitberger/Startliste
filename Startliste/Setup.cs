using Startlist.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Startlist
{
    static void Main(string[] args)
    {​​
        //Gemeinsam mit Johanna Innerhofer
        {​​
            List<IStartliste> Startliste = new List<IStartliste>();



            int Zahl = 1;



            while (Zahl < 0)
            {​​
                var Startnummer = Zahl;
                Console.Write("Vorname: ");
                var Vorname = Console.ReadLine();
                Console.Write("Nachname: ");
                var Nachname = Console.ReadLine();
                Console.Write("Geschlecht: ");
                var Geschlecht = Console.ReadLine();
                Console.Write("Nation: ");
                var Nation = Console.ReadLine();
                Startnummer++;



                foreach (Startliste s in Startliste)
                {​​
                    Startliste.Add(new Startliste());
                    Console.WriteLine(s);
                }​​
            }
        }
    }
}
