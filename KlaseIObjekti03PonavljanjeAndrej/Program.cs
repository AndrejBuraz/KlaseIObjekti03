using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlaseIObjekti03PonavljanjeAndrej
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stablo stablo1 = new Stablo(false);
            Stablo stablo2 = new Stablo(true);
            Console.WriteLine("Prvo stablo: \n" + stablo1.ToString());
            Console.WriteLine("Drugo stablo: \n" + stablo2.ToString());
            Console.ReadKey();
        }
    }

    class Stablo
    {
        bool otpadajuListovi;
        string vrstaStabla;

        public void setOtpadajuListovi(bool otpadajuListovi)
        {
            this.otpadajuListovi = otpadajuListovi;
        }
        public bool getOtpadajuListovi()
        {
            return this.otpadajuListovi;
        }
        public Stablo()
        {

        }
        public Stablo(bool otpadajuListovi)
        {
            this.otpadajuListovi=otpadajuListovi;
            if(!otpadajuListovi)
            {
                this.vrstaStabla = "crnogorično";
            }
            else
            {
                this.vrstaStabla = "bijelogorično";
            }
        }
        public override string ToString()
        {
            string ispis = ("Stablo je: " + this.vrstaStabla);
            return ispis;
        }
    }
}
