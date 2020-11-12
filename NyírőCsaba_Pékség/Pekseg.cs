using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyírőCsaba_Pékség
{
    public class Pekseg
    {
        public String Nev;
        public DateTime AlapitasDatuma;
        public List<Pekaru> Pekaruk;

        public Pekseg(string nev, DateTime alapitasDatuma)
        {
            this.Nev = nev;
            this.AlapitasDatuma = alapitasDatuma;
            this.Pekaruk = new List<Pekaru>();
        }
        
        public override string ToString()
        {
            return Nev + " - " + AlapitasDatuma.ToString().Remove(AlapitasDatuma.ToString().Length-8);
        }
    }
}
