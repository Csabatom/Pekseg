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
        public bool Laktozmentes;

        public Pekaru(string Nev, double Ar, bool Laktozmentes)
        {
            this.Nev = Nev;
            this.Ar = Ar;
            this.Laktozmentes = Laktozmentes;
        }

        public override string ToString()
        {
            return Nev + " (" + Ar + " Ft / db)";
        }
    }
}
