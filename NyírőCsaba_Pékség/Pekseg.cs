using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyírőCsaba_Pékség
{
    public class Pekseg
    {
        private String nev;
        private List<Pekaru> termekek;
        private DateTime alapitva;

        public String Nev { get { return nev; } set { nev = value; } }
        public List<Pekaru> Termekek { get { return termekek; } }
        public DateTime Alapitva { get { return alapitva; } }

        public Pekseg(string nev, DateTime alapitasDatuma)
        {
            this.nev = nev;
            this.alapitva = alapitasDatuma;
            this.termekek = new List<Pekaru>();
        }
        
        public override string ToString()
        {
            return nev + " - " + alapitva.ToString().Remove(alapitva.ToString().Length-8);
        }

        public double AtlagAr()
        {
            double termekekOsszege = 0;

            foreach (var pekaru in termekek)
            {
                termekekOsszege += pekaru.Ar;
            }
            return termekekOsszege /= termekek.Count();
        }

        public Pekaru Legolcsobb()
        {
            try
            {
                Pekaru legolcsobb = termekek[0];
                foreach (var pekaru in termekek)
                {
                    if (legolcsobb.Ar > pekaru.Ar)
                    {
                        legolcsobb = pekaru;
                    }
                }
                return legolcsobb;
            } catch
            {
                return null;
            }
        }

        public Pekaru Legdragabb()
        {
            try
            {
                Pekaru legdragabb = termekek[0];
                foreach (var pekaru in termekek)
                {
                    if (legdragabb.Ar < pekaru.Ar)
                    {
                        legdragabb = pekaru;
                    }
                }
                return legdragabb;
            } catch
            {
                return null;
            }
        }

        public String Laktozmentesek()
        {
            int laktozmentesek = 0;

            foreach(var pekaru in termekek)
            {
                if(pekaru.Laktozmentes == true)
                {
                    laktozmentesek++;
                }
            }
            try
            {
                return laktozmentesek + " db, " + Math.Ceiling(Convert.ToDecimal(100 / termekek.Count) * laktozmentesek) + "%";
            } catch (Exception err)
            {
                return "0 db, 0%";
            }
        }
    }
}
