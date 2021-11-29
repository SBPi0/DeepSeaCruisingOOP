using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeepSeaCruisingOOP
{
    //Classen er sealed så at den ikke kan inherites
    sealed public class Besætning : Person
    {
        public string Rolle { get; set; }
        //public string Rolle { get; set; }
        public string VagtStart { get; set; }
        public string VagtSlut { get; set; }

        //Constructor til "Besætning" objekter
        public Besætning(string BeID, string BeEmail, string BeTlf, string BeNavn, string BeRolle, string BeVagtSt, string BeVagtStop)
        {
            ID = BeID;
            Email = BeEmail;
            Tlf = BeTlf;
            Navn = BeNavn;
            Rolle = BeRolle;
            VagtStart = BeVagtSt;
            VagtSlut = BeVagtStop;
        }
    }

}
