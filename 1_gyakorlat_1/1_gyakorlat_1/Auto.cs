using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autonevter
{
    class Auto : Jarmu
    {
        static string[] motortipusokk = { "1.4", "1.6", "1.8", "2.0", "2.3" };
        public static ArrayList motortipusok = new ArrayList(motortipusokk);
        public static int letrehozottAutok = 0;


        //Forditasi ideju konstans:
        //  private const int konstans = 1;

        private string motortipus;
        private string uzemanyag;
        private double atlagfogyasztas;

        public double Atlagfogyasztas
        {
            get { return atlagfogyasztas; }
            set { atlagfogyasztas = value; }
        }


        public string Uzemanyag
        {
            get { return uzemanyag; }
            set { uzemanyag = value; }
        }


        public string Motortipus
        {
            get { return motortipus; }
            set { motortipus = value; }
        }

        public Auto(string gyarto, string tipus, int evjarat, string motortipus, string uzemanyag, double atlagfogyasztas):base(gyarto, tipus, evjarat)
        {
            this.motortipus = motortipus;
            this.uzemanyag = uzemanyag;
            this.atlagfogyasztas = atlagfogyasztas;
            letrehozottAutok++;
        }
        public Auto(string gyarto, string tipus, int evjarat, string motortipus):base(gyarto, tipus, evjarat)
        {
            this.motortipus = motortipus;
            this.uzemanyag = "benzin";

            switch (motortipus)
            {
                case "1.4":
                    this.atlagfogyasztas = 6.5;
                    break;
                case "1.8":
                    this.atlagfogyasztas = 7.5;
                    break;
                case "2.0":
                    this.atlagfogyasztas = 8;
                    break;
                default:
                    break;
            }
            letrehozottAutok++;
        }
        public void MotorCsere(string motortipus, string uzemanyag, double atlagfogyasztas)
        {
            Motortipus = motortipus;
            Uzemanyag = uzemanyag;
            Atlagfogyasztas = atlagfogyasztas;
        }

        /// <summary>
        /// Uzemanyag fogyasztás számítása
        /// </summary>
        /// <param name="uzemanyag">uzemanyag literben</param>
        /// <param name="tavolsag">tavolsag km-ben</param>
        /// <returns>a napi fogyasztas értéke</returns>
        public double Fogyasztas(double uzemanyag, int tavolsag)
        {
            return uzemanyag / tavolsag * 100;
        }

        public bool AtlagFogyasztasOsszehasonlito(double uzemanyag, int tavolsag)
        {
            return Fogyasztas(uzemanyag, tavolsag) <= this.atlagfogyasztas; 
        }

        /// <summary>
        /// Uzemanyag költség számítás
        /// </summary>
        /// <param name="tavolsag">tavolsag km-ben</param>
        /// <param name="uzemanyagAr">literenkénti forint egység ár</param>
        /// <returns></returns>
        public int UzemanyagKoltsegSzamitasForint(int tavolsag, int uzemanyagAr)
        {
            return (int)(atlagfogyasztas * tavolsag * uzemanyagAr / 100);
        }


        public int UzemanyagKoltsegSzamitasEuro(int tavolsag, int uzemanyagAr, int arfolyam)
        {
            return (int)(atlagfogyasztas * tavolsag * uzemanyagAr / 100 / arfolyam);
        }
        public static int LetrehozottAutoSorszama()
        {
            return letrehozottAutok;
        }

        public override string ToString()
        {
            return "Auto: " + "|" + Gyarto + ", " + Tipus + ", " + Evjarat + ", " + Motortipus + ", " + Uzemanyag + ", " + Atlagfogyasztas + "|";
        }

        public override int Sebesseg(int tavolsag, int idoOraban)
        {
            return tavolsag / idoOraban;
        }
    }
}
