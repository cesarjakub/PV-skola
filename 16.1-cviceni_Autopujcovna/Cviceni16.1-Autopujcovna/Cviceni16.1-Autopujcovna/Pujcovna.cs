using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Cviceni16._1_Autopujcovna
{
    public class Pujcovna
    {
        private Dictionary<Zakaznik,Auto> auta = new Dictionary<Zakaznik, Auto>();

        public Dictionary<Zakaznik, Auto> Auticka
        {
            get { return auta; }
            set { auta = value; }
        }

        public Pujcovna()
        {
        }

        public void addAutoZakaznik(Zakaznik zak, Auto a)
        {
            Auticka.Add(zak, a);
        }

        public void MyDictionaryToJson()
        {
            string json = "";
            var entries = Auticka.Select(d =>
                string.Format("\"{0}\": [{1}]", d.Key, string.Join(",", d.Value)));
            json += "{" + string.Join(",", entries) + "}\n";
            File.WriteAllText(Directory.GetCurrentDirectory()+ @"/jsonText/evidence.json", json);
        }


        public override string? ToString()
        {
            string text = "";
            foreach (KeyValuePair<Zakaznik, Auto> kvp in Auticka)
            {
                text += kvp.Key.ToString() +", půjčené auto: "+ kvp.Value.ToString()+"\n";
            }
            return text;
        }
    }
}
