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
        }
    }
}
