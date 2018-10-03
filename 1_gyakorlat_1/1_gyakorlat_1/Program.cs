using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autonevter.futtathato
{
    class Program
    {
        static void Main(string[] args)
        {
            int darab = 2;
            Auto[] autok = new Auto[darab];

            autok[0] = new Auto("Skoda", "superb", DateTime.Today.Year, "1.8");
            Console.WriteLine(autok[0].ToString());

            string gyarto;
            string tipus;
            int evjarat;
            string motortipus;
            string uzemanyag;
            double atlagfogyasztas;

            Console.WriteLine("Kerem a gyartot");
            gyarto = Console.ReadLine();
            Console.WriteLine("Kerem a tipust");
            tipus = Console.ReadLine();
            do
            {
                Console.WriteLine("Kerem az evjaratot");
                evjarat = int.Parse(Console.ReadLine());
            } while (evjarat < 1998 || evjarat > 2018);
            Console.WriteLine("Kerem a motortipust");
            motortipus = Console.ReadLine();
            Console.WriteLine("Kerem az uzemanyagot");
            uzemanyag = Console.ReadLine();
            Console.WriteLine("Kerem az atlagfogyasztast");
            atlagfogyasztas = double.Parse(Console.ReadLine());
            autok[1] = new Auto(gyarto, tipus, evjarat, motortipus,uzemanyag,atlagfogyasztas);
            

        }
    }
}
