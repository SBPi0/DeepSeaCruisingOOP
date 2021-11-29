using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DeepSeaCruisingOOP
{
    public class KundeOpret
    {
        string[] Info = File.ReadAllLines(@"C:\Users\" + Environment.UserName + @"\source\repos\DeepSeaCruising\Data.txt");
        public void Run()
        {
            string valg;
            string[] Number = Regex.Split(Info[0], @";");
            Console.Clear();
            //Kunde Oprettelse
            Console.Write("Email: ");
            Info[0] += $";{Console.ReadLine()}";
            Console.Write("Tlf: ");
            Info[1] += $";{Console.ReadLine()}";
            Console.Write("Navn: ");
            Info[2] += $";{Console.ReadLine()}";
            Console.Write("Køn: ");
            Info[3] += $";{Console.ReadLine()}";
            Console.Write("Alder: ");
            Info[4] += $";{Console.ReadLine()}";
            Console.Write("Noget vi skal være klar over vedrørende allergier, mad, eller lignende?");
            Info[5] += $";{Console.ReadLine()}";
            Console.Write("Husdyr, og hvis dette er tilfældet, hvilke: ");
            Info[6] += $";{Console.ReadLine()}";
            Info[7] += $";{DateTime.Now.ToString("MM/dd/yyyy h:mm tt")};";
            //Kunde ID
            Info[8] += $";{Number.Count()}";
            //Billet Oprettelse
            Console.Write("Fra Destination ");
            Info[9] += $";{Console.ReadLine()}";
            Console.Write("Til Destination: ");
            Info[10] += $";{Console.ReadLine()}";
            Console.Write("Afrejsedato: ");
            Info[11] += $";{Console.ReadLine()}";
            Console.Write("(F)ørste Klasse/(A)nden Klasse/(Ø)konomi Klasse: ");
            valg = Console.ReadLine().ToUpper();
            if (valg == "F") Info[12] = ";Første Klasse";
            else if (valg == "A") Info[12] = ";Anden Klasse";
            else if (valg == "Ø") Info[12] = ";Økonomi Klasse";
            else return;
            //Hver billet's kahytnr går op med 1 ved split af Info[12]
            Info[13] += $";{Number.Count() + 9}";
            //Billet ID
            Info[14] += $";{Number.Count() + 99}";
            File.WriteAllLines(@"C:\Users\" + Environment.UserName + @"\source\repos\DeepSeaCruising\Data.txt", Info);
        }
    }
}