using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tretihodina
{
    internal class Svetec : Clovek
    {
        public Svetec(string jmeno) : base(jmeno)
        {
        }

        public override bool trueOrFalse()
        {
            return true; 
        }

        public override string ToString()
        {
            return "svetec "+base.ToString();
        }
    }
}
