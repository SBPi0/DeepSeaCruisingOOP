using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DeepSeaCruisingOOP
{
    internal class BesætningOpret
    {
        string[] Info = File.ReadAllLines(@"C:\Users\" + Environment.UserName + @"\source\repos\DeepSeaCruisingOOP\Data.txt");
        public void Run()
        {
            string valg;
            // Number er en string som bliver lavet ud fra split af Info[17] ved hvert ";"
            string[] Number = Regex.Split(Info[17], @";");
            Console.Clear();
            //Besætning Oprettelse
            //Info[15] er Besætnings ID. Besætnings ID'et bliver lavet ved at tælle antallet
            //af array elementer i Number[], og derefter sætte en integer med værdi 999 til det talte antal
            Info[15] += $";{Number.Count() + 999}";
            Console.Write("Email: ");
            Info[16] += $";{Console.ReadLine()}";
            Console.Write("Tlf: ");
            Info[17] += $";{Console.ReadLine()}";
            Console.Write("Navn: ");
            Info[18] += $";{Console.ReadLine()}";
            Console.Write("Rolle: ");
            Info[19] += $";{Console.ReadLine()}";
            Console.Write("Vagt Start: ");
            Info[20] += $";{Console.ReadLine()}";
            Console.Write("Vagt Slut: ");
            Info[21] += $";{Console.ReadLine()}";
            File.WriteAllLines(@"C:\Users\" + Environment.UserName + @"\source\repos\DeepSeaCruising\Data.txt", Info);
        }
    }
}
