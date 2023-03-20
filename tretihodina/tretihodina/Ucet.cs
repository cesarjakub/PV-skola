using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tretihodina
{
    internal class Ucet
    {
        private int vklad;
        private int vyber;
        private int stav;

        public Ucet(int vklad, int vyber, int stav)
        {
            this.vklad = vklad;
            this.vyber = vyber;
            this.stav = stav;
        }

        public int Vklad 
        { get { return vklad; } 
          set 
          { 
                if (value <= 0) 
                { 
                    throw new Exception("Vklad nemuze bzt mensi jak nula"); 
                }  
                vklad = value;
          } 
        } 
        
        public int Vyber
        {
            get { return vyber; }
            set
            {
                if(value > stav)
                {
                    throw new Exception("Nemuzete vzbrat vic nez mate na ucte");
                }
                vyber = value;
            }
        }

        public int Stav
        {
            get { return stav; }
            set { value = stav; }
        }

        public void vlozitPrachy(int number)
        {
            if (number > 0)
            {
                stav += number;
            }
            else
            {
                throw new Exception("Nelze vlozit zaporno hodnotu");
            }
        }

        public void vzitPrachy(int number)
        {
            if (number <= stav)
            {
                stav -= number;
            }
            else
            {
                throw new Exception("Nelze vybrat vice penez nez mate na uctu");
            }
        }
    }
}
