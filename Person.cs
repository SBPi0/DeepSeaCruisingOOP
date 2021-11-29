using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeaCruisingOOP
{
    //Constructor til Person Class, som primært bruges til at klassen "Besætning" og klassen "Kunde" kan inherit
    //dens properties
    public class Person
    {
        public string ID { get; set; }
        public string Email { get; set; }
        public string Tlf { get; set; }
        public string Navn { get; set; }
    }
}
