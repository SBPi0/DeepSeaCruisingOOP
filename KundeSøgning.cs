using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DeepSeaCruisingOOP
{
    internal class KundeSøgning
    {
        string[] Info = File.ReadAllLines(@"C:\Users\" + Environment.UserName + @"\source\repos\DeepSeaCruising\Data.txt");
        string søg = "";

        public void Run()
        {
            string[] KundeEmails = Regex.Split(Info[0], @";");
            string[] KundeTlf = Regex.Split(Info[1], @";");
            string[] KundeNavne = Regex.Split(Info[2], @";");

            //overload af Constructor bliver brugt til at lave disse objekter
            //Constructor overload kan findes i klassen "Kunde"
            List<Kunde> KundeS = new List<Kunde>();
            for (int i = 1; i < KundeEmails.Length; i++) KundeS.Add(new(KundeEmails[i], KundeTlf[i], KundeNavne[i]));

            Console.Clear();
            Console.Write("Søg venligst på kundenavn, telefon nummer, eller email: ");
            søg = Console.ReadLine();

            for (int i = 0; i < KundeS.Count; i++)
            {
                if (KundeS[i].Navn == søg || KundeS[i].Tlf == søg || KundeS[i].Email == søg)
                {
                    Console.Clear();
                    //Override af metoden ToString() i klassen "Kunde" bruges her til at returnere den information vi vil returnere
                    //fra det aktuelle objekt i for-loop'et
                    Console.Write(KundeS[i].ToString());
                    //Afslutter for-loop'et hvis condition er true
                    break;
                }
            }
        }
    }
}
