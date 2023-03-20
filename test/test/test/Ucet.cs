using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Ucet
    {
        private int limit;
        private int aktualniCastka;
        private bool zmrazeni = false; 

        public Ucet(int limit, int aktualniCastka)
        {
            this.limit = limit;
            this.aktualniCastka = aktualniCastka;
        }


        public int Limit
        {
            get { return limit; }
            set
            {
                if (zmrazeni)
                {
                    throw new Exception("Mate zmrazeny ucet :(");
                }
                if (value < 0)
                {
                    throw new Exception("Limit nemuze byt pod nulu");
                }
                limit = value;
            }
        }

        public int AktualniCastka
        {
            get { return aktualniCastka; }
            set
            {
                if (zmrazeni)
                {
                    throw new Exception("Mate zmrazeny ucet :(");
                }
                if (value < 0)
                {
                    throw new Exception("Aktualni casta nemuze byt pod nulou");
                }
                aktualniCastka = value;
            }
        }

        public int kupSiNeco(int cena)
        {
            if (zmrazeni)
            {
                throw new Exception("Mate zmrazeny ucet :(");
            }
            if (cena > aktualniCastka)
            {
                throw new Exception("nelze si koupit neco na co namas prachy");
            }
            aktualniCastka = limit - cena;
            return aktualniCastka;
        }


        public int zaplatUtracenouCastku()
        {
            if (zmrazeni)
            {
                throw new Exception("mate zmrazeny ucet :(");
            }
            int temp = limit - aktualniCastka;
            aktualniCastka = temp + aktualniCastka;
            return aktualniCastka;
        }

        public int czkToEur()
        {
            return aktualniCastka / 25;
        }

        public void zmarizUcet()
        {
            zmrazeni = true;
        }

        public override string? ToString()
        {
            return "limit: "+limit + "czk, aktualni castak: " + aktualniCastka+"czk";
        }
    }
}
