using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pretezovanioperatoru
{
    public class komplexniCislo
    {
        public int realnaSlozka;
        public int imaginarniSlozka;

        public komplexniCislo(int realnaSlozka, int imaginarniSlozka)
        {
            this.realnaSlozka = realnaSlozka;
            this.imaginarniSlozka = imaginarniSlozka;
        }

        public static bool operator ==(komplexniCislo kc1, komplexniCislo kc)
        {
            return (kc1.realnaSlozka == kc.realnaSlozka && kc1.imaginarniSlozka == kc.imaginarniSlozka);
        }

        public static bool operator !=(komplexniCislo kc1, komplexniCislo kc)
        {
            return !(kc1.realnaSlozka == kc.realnaSlozka && kc1.imaginarniSlozka == kc.imaginarniSlozka);
        }

        public static komplexniCislo operator +(komplexniCislo kc1, komplexniCislo kc)
        {
            int x = kc1.realnaSlozka + kc.realnaSlozka;
            int y = kc1.imaginarniSlozka + kc.imaginarniSlozka;
            return new komplexniCislo(x,y);
        }

        public static komplexniCislo operator -(komplexniCislo kc1, komplexniCislo kc)
        {
            int x = kc1.realnaSlozka - kc.realnaSlozka;
            int y = kc1.imaginarniSlozka - kc.imaginarniSlozka;
            return new komplexniCislo(x, y)
        }
    }
}
