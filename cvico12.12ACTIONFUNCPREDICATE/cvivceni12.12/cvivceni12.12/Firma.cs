using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvivceni12._12
{
    public class Firma
    {
        private string Nazev { get; set; }
        public List<Zamestnanec> seznamZam = new List<Zamestnanec>();

        public Firma(string nazev)
        {
            Nazev = nazev;
        }

        public void addZam(Zamestnanec zam)
        {
            seznamZam.Add(zam);
        }

        public List<Zamestnanec> nejVyssiPlat()
        {
            var max = seznamZam.Max(z => z.Plat);
            return seznamZam.OrderByDescending(z => z.Plat == max).ToList();
        }

        public double prumPlat()
        {
            return seznamZam.Average(z => z.Plat);
        }


        public double prumPlatPoz(Pozice pozice)
        {
            return seznamZam.Where(s => s.Pozice == pozice).Average(z => z.Plat);
        }

        public List<Zamestnanec> triNej()
        {
            return seznamZam.OrderByDescending(z => z.Plat).Take(3).ToList();
        }

        public List<Zamestnanec> podleData()
        {
            return seznamZam.OrderBy(z => z.NastupDoFirmy).ToList();
        }

        public List<Zamestnanec> svatek(string jmeno)
        {
            return seznamZam.Where(z => z.Jmeno == jmeno).ToList();
        }
    }
}
