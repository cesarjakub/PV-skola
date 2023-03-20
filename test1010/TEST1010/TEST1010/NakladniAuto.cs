using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST1010
{
    public class NakladniAuto : Auto
    {

        private int hmotnost;
        public NakladniAuto(int hmotsnost, int velikost, int aktualniStav) : base(velikost, aktualniStav)
        {
            this.hmotnost = hmotsnost;
        }

        public int Hmotnost
        {
            get { return hmotnost; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Hmotnost nesmi byt zaporna");
                }
                this.hmotnost = value;
            }
        }

        public override string? ToString()
        {
            return "Nakladni "+base.ToString()+", hmotnost nakladu: "+hmotnost+"tun";
        }
    }
}
