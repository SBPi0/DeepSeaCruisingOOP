using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DeepSeaCruisingOOP
{
    public class AdminLogin
    {
        string[] Info = File.ReadAllLines(@"C:\Users\" + Environment.UserName + @"\source\repos\DeepSeaCruising\Data.txt");
        public void Run()
        {
            Console.Clear();
            Console.Write("(S)øgning  (K)undeOprettelse   (B)esætningOprettelse (Ku)ndeliste (Be)sætningsliste: ");
            switch (Console.ReadLine().ToUpper())
            {
                case "S":
                    //objekt initialisering af klassen Kundesøgning, og metode fra klassen køres
                    KundeSøgning Søg = new();
                    Søg.Run();
                    break;
                case "K":
                    KundeOpret Kunde = new();
                    Kunde.Run();
                    break;
                case "B":
                    BesætningOpret Besætning = new();
                    Besætning.Run();
                    break;
                case "KU":
                    SavedObjects KundeOp = new();
                    KundeOp.KundeListe();
                    break;
                case "BE":
                    SavedObjects BesætningLi = new();
                    BesætningLi.BesætningListe();
                    break;
                default:
                    break;
            }
        }
    }
}
