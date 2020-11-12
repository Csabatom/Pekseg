using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyírőCsaba_Pékség
{
    public class Pekaru
    {
        private String nev;
        private int ar;
        private bool laktozmentes;

        public String Nev { get { return nev; } set { nev = value; } }
        public int Ar { get { return ar; } set { ar = value; } }
        public bool Laktozmentes { get { return laktozmentes; } set { laktozmentes = value; } }

        public Pekaru(string nev, int ar, bool laktozmentes)
        {
            this.nev = nev;
            this.ar = ar;
            this.laktozmentes = laktozmentes;
        }

        public override string ToString()
        {
            return nev + " (" + ar + " Ft / db)";
        }
    }
}
