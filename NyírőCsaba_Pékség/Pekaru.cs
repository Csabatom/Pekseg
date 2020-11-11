using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyírőCsaba_Pékség
{
    public class Pekaru
    {
        public String Nev;
        public double Ar;
        public bool laktozmentes;

        public Pekaru(string Nev, double Ar, bool laktozmentes)
        {
            this.Nev = Nev;
            this.Ar = Ar;
            this.laktozmentes = laktozmentes;
        }

        public override string ToString()
        {
            return Nev + " (" + Ar + " Ft / db)";
        }
    }
}
