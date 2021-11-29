using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeaCruisingOOP
{
    //public enum Billet { FørsteKlasse, AndenKlasse, ØkonomiKlasse }
    internal class BilletBestilling
    {
        public string FraDestination { get; set; }
        public string TilDestination { get; set; }
        public string AfrejseDato { get; set; }
        public string Billet { get; set; }
        public string KahytNr { get; set; }
        public string BilletID { get; set; }
        //Constructor til objekter som har med billetbestilling at gøre
        public BilletBestilling(string FDestination, string TDestination, string AfrejseD, string Bill, string Kahyt, string IDBillet)
        {
            FraDestination = FDestination;
            TilDestination = TDestination;
            AfrejseDato = AfrejseD;
            Billet = Bill;
            KahytNr = Kahyt;
            BilletID = IDBillet;
        }
    }
}