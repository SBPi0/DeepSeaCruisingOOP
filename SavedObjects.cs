using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DeepSeaCruisingOOP
{
    public class SavedObjects
    {
        public void KundeListe()
        {
            Console.Clear();
            //Array elementer fra data filen, hvor gemt kunde information er, splittes hver især op for at lave nye arrays ud af de splittede strings
            string[] Info = File.ReadAllLines(@"C:\Users\" + Environment.UserName + @"\source\repos\DeepSeaCruising\Data.txt");
            string[] KundeEmails = Regex.Split(Info[0], @";");
            string[] KundeTlf = Regex.Split(Info[1], @";");
            string[] KundeNavne = Regex.Split(Info[2], @";");
            string[] KundeKøn = Regex.Split(Info[3], @";");
            string[] KundeAldre = Regex.Split(Info[4], @";");
            string[] KundeBeskrivelser = Regex.Split(Info[5], @";");
            string[] KundeHusdyr = Regex.Split(Info[6], @";");
            string[] KundeOpretDato = Regex.Split(Info[7], @";");
            string[] KundeID = Regex.Split(Info[8], @";");

            List<Kunde> KundeInf = new List<Kunde>();
            //For-loop laves lige så mange objekter som der er array elementer i string array'et "KundeEmails", og objekterne fyldes med data fra de ny lavede strings i array element position [i]
            for (int i = 1; i < KundeEmails.Length; i++) KundeInf.Add(new(KundeEmails[i], KundeTlf[i], KundeNavne[i], KundeKøn[i], KundeAldre[i], KundeBeskrivelser[i], KundeHusdyr[i], KundeOpretDato[i], KundeID[i]));
            //For loop som udskriver string med specifik info fra hvert objekt ud på consolen
            for (int i = 0; i <= KundeInf.Count() - 1; i++)
            {
                Console.WriteLine($"\nEmail: {KundeInf[i].Email}\nTlf: {KundeInf[i].Tlf}\nNavn: {KundeInf[i].Navn}\nKøn: {KundeInf[i].Køn}\nAlder: {KundeInf[i].Alder}\nBeskrivelse: {KundeInf[i].Beskrivelse}\n" +
                    $"Husdyr: {KundeInf[i].Husdyr}\nOprettelses Dato: {KundeInf[i].Oprettelse}\nID: {KundeInf[i].ID}");
            }
        }

        public static void BilletOpret()
        {
            //Samme som forhenværende metode, men med array elementer fra data filen som har med gemt billet information at gøre
            string[] Info = File.ReadAllLines(@"C:\Users\" + Environment.UserName + @"\source\repos\DeepSeaCruising\Data.txt");
            string[] FraDestinationer = Regex.Split(Info[9], @";");
            string[] TilDestinationer = Regex.Split(Info[10], @";");
            string[] AfrejseDatoer = Regex.Split(Info[11], @";");
            string[] BilletTyper = Regex.Split(Info[12], @";");
            string[] KahytNumre = Regex.Split(Info[13], @";");
            string[] BilletID = Regex.Split(Info[14], @";");

            List<BilletBestilling> Billet = new List<BilletBestilling>();
            for (int i = 0; i < FraDestinationer.Length; i++) Billet.Add(new BilletBestilling(FraDestinationer[i], TilDestinationer[i], AfrejseDatoer[i], BilletTyper[i], KahytNumre[i], BilletID[i]));

        }

        public void BesætningListe()
        {
            //Denne gang med information som har med besætningen at gøre
            string[] Info = File.ReadAllLines(@"C:\Users\" + Environment.UserName + @"\source\repos\DeepSeaCruising\Data.txt");
            string[] BeID = Regex.Split(Info[15], @";");
            string[] BeEmail = Regex.Split(Info[16], @";");
            string[] BeTlf = Regex.Split(Info[17], @";");
            string[] BeNavn = Regex.Split(Info[18], @";");
            string[] BeRolle = Regex.Split(Info[19], @";");
            string[] BeVagtSt = Regex.Split(Info[20], @";");
            string[] BeVagtStop = Regex.Split(Info[21], @";");

            List<Besætning> Crew = new List<Besætning>();
            for (int i = 1; i < BeID.Length; i++) Crew.Add(new Besætning(BeID[i], BeEmail[i], BeTlf[i], BeNavn[i], BeRolle[i], BeVagtSt[i], BeVagtStop[i]));
            for (int i = 0; i <= Crew.Count() - 1; i++)
            {
                Console.WriteLine($"\nID: {Crew[i].ID}\nEmail: {Crew[i].Email}\nTlf: {Crew[i].Tlf}\nNavn: {Crew[i].Navn}\nRolle: {Crew[i].Rolle}\nVagt Start: {Crew[i].VagtStart}\n" +
                    $"Vagt Slut: {Crew[i].VagtSlut}");
            }
        }
    }
}
