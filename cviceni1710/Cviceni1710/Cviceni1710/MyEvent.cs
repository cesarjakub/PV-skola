using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni1710
{
    public class MyEvent
    {
        private Typ type;
        public Uroven urovene;
        public string popis;

        public MyEvent(Typ type, Uroven urovene, string popis)
        {
            Type = type;
            Uroven = urovene;
            Popis = popis;
        }

        public Typ Type
        {
            get { return type; }
            set { type = value; }
        }

        public Uroven Uroven
        {
            get { return urovene; }
            set { urovene = value; }
        }

        public string Popis
        {
            get { return popis;}
            set { popis = value; }
        }

        public override string? ToString()
        {
            return "Typ: "+Type+", urovne: "+Uroven+", popis: "+popis;
        }
    }
}
