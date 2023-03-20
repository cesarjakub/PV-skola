using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cvivceni12._12
{
    public class Zamestnanec
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public int Plat { get; set; }
        public Pozice Pozice { get; set; }
        public DateTime NastupDoFirmy { get; set; }


        public Zamestnanec(string jmeno, string prijmeni, int plat, Pozice pozice, DateTime nastupDoFirmy)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Plat = plat;
            Pozice = pozice;
            NastupDoFirmy = nastupDoFirmy;
        }

        public override string? ToString()
        {
            return Jmeno+" "+Prijmeni+" Plat: "+Plat+", Pozice: "+Pozice+", Nastup Do Firmy: "+NastupDoFirmy;
        }
    }
}
