using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeaCruisingOOP
{
    sealed public class Kunde : Person
    {
        public string Køn { get; set; }
        public string Alder { get; set; }
        public string Beskrivelse { get; set; }
        public string Husdyr { get; set; }
        public string Oprettelse { get; set; }
        public override string ToString()
        {
            return $"\nNavn: {Navn}\nTlf: {Tlf}\nEmail: {Email}";
        }

        //konstruktor som nedarver properties fra "Person" class
        public Kunde(string KundeEmail, string KundeTlf, string KundeNavn, string KundeKøn, string KundeAlder, string KundeBeskrivelse, string KundeHusdyr, string KundeOprettelse, string IDKunde)
        {
            Email = KundeEmail;
            Tlf = KundeTlf;
            Navn = KundeNavn;
            Køn = KundeKøn;
            Alder = KundeAlder;
            Beskrivelse = KundeBeskrivelse;
            Husdyr = KundeHusdyr;
            Oprettelse = KundeOprettelse;
            ID = IDKunde;
        }
        //overload af forhenværende constructor, til brug i "KundeSøgning" class
        public Kunde(string KundeEmail, string KundeTlf, string KundeNavn)
        {
            Email = KundeEmail;
            Tlf = KundeTlf;
            Navn = KundeNavn;
        }
    }
}