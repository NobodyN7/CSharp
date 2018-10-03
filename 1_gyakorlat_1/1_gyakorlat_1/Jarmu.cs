using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autonevter
{
    abstract class Jarmu
    {
        private string gyarto;
        private string tipus;

        //Futási idejű konstans:
        private readonly int evjarat;

        public Jarmu(string gyarto, string tipus, int evjarat)
        {
            this.Gyarto = gyarto;
            this.Tipus = tipus;
            this.evjarat = evjarat;
        }

        public string Gyarto
        {
            get { return gyarto; }
            set { gyarto = value; }
        }

        public string Tipus
        {
            get { return tipus; }
            set { tipus = value; }
        }

        public int Evjarat
        {
            get { return evjarat; }
        }

        public abstract int Sebesseg(int tavolsag, int idoOraban);

        public override string ToString()
        {
            return "Jarmu: " + Gyarto + ", " + Tipus + ", " + Evjarat;
        }



    }
}
