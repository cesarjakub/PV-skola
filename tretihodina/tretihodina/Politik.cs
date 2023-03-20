using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tretihodina
{
    internal class Politik : Clovek
    {

        public Politik(string jmeno) : base(jmeno)
        {

        }

        public override bool trueOrFalse()
        {
            return false;
        }

        public override string ToString()
        {
            return "politik "+base.ToString();
        }
    }
}
