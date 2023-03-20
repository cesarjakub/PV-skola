using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni1710
{
    public class SeznamUdalosti
    {
        private List<MyEvent> udalost = new List<MyEvent>();
      
        public SeznamUdalosti()
        {
        }

        public void Add(MyEvent e)
        {
            udalost.Add(e);
        }

        public List<MyEvent> Filtr(Typ typ, Uroven u)
        {
            List<MyEvent> list = new List<MyEvent>();
            foreach (MyEvent e in udalost)
            {
                if (Typ.Any == typ && e.Uroven == u)
                {
                    list.Add(e);
                }
                if (e.Type == typ && Uroven.Any == u)
                {
                    list.Add(e);
                }
                if (Typ.Any == typ && Uroven.Any == u)
                {
                    list.Add(e);
                }
                if (e.Type == typ && e.Uroven == u)
                {
                    list.Add(e);
                }

            }
            return list;
        }

        public override string? ToString()
        {
            string text = "";
            foreach (MyEvent e in udalost)
            {
                text += e + "\n";
            }
            return text;
        }

        public string fitrstring(Typ typ, Uroven u)
        {
            string text = "";
            List<MyEvent> list = Filtr(typ, u);
            foreach (MyEvent e in list)
            {
                text += e + "\n";
            }

            return text;
        } 
    }
}
