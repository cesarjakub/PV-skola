using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST1010
{
    public class Auto
    {
        protected int velikost;
        protected int aktualniStav;

        public Auto(int velikost, int aktualniStav)
        {
            this.velikost = velikost;
            this.aktualniStav = aktualniStav;
        }

        public int Velikost
        {
            get { return velikost; }
            set
            {   
                if(value < 0)
                {
                    throw new Exception("velikost nesmi byt mensi nez nula");
                }
                velikost = value;
            }
        }

        public int AktualniStav
        {
            get { return aktualniStav; }
            set
            {
                if (value > velikost || value < 0)
                {
                    throw new Exception("aktualni stav nesmi byt vetsi nez velikost nadrze a nesmi byt mensi jak nula");
                }
                aktualniStav = value;
            }
        }


        public int DolitiNadrze(int hodnota)
        {
            int temp = 0;
            if (hodnota > 0 && hodnota < aktualniStav)
            {
                temp = aktualniStav += hodnota;
            }
            else
            {
                throw new Exception("hodnota nesmi byt zaporna a vetsi nez velikost nadrze");
            }
            return temp;
        }

        public override string? ToString()
        {
            return "Auto s velikosti nadrze: " + velikost + "l , Aktualni stav nadrze: "+aktualniStav+"l";
        }
    }
}
