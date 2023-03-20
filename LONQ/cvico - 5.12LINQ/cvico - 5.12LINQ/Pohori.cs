using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace cvico___5._12LINQ
{
    public class Pohori
    {
        private List<string> seznam;
        private string nazev;
        private int vyska;

        public string Nazev
        {
            get { return nazev; }
            set { nazev = value; }
        }

        public int Vyska
        {
            get { return vyska; }
            set { vyska = value; }
        }

        public List<string> Seznam
        {
            get { return seznam; }
            set { seznam = value; }
        }

        public Pohori(string nazev)
        {
            Nazev = nazev;
            Seznam = new List<string>();
            
            Seznam = Nazev.Split("•").ToList();

            Regex regex = new Regex(@"^.*?\([^\d]*(\d+)[^\d]*\).*$");
            Match match = regex.Match(Nazev);
            Nazev = nazev.Substring(0, match.Groups[1].Index - 1);
            Vyska = int.Parse(match.Groups[1].Value);

        }

        public void nejvyssiHora()
        {
            var nej = Seznam.OrderByDescending(v => vyska).First();
            Console.WriteLine("Nejvetsi hora: {0}",nej);
        }

        public void trinejvetsi()
        {
            var tri = Seznam.OrderByDescending(v => vyska).Take(3).ToList();
            Console.WriteLine("tri nejvetsi hory: ");
            foreach (var x in tri)
            {
                Console.Write(x+" ");
            }
        }

        public void prumer()
        {
            var vysledek = Seznam.Average(v => Vyska);
            Console.WriteLine("Prumerna vyska hor: " + vysledek);
        } 

        public void order()
        {
            var or = Seznam.OrderBy(v => vyska).Select(n => Nazev).ToList();
            Console.WriteLine("Hory serazeny pomoci vysky: ");
            foreach (var x in or)
            {
                Console.Write(x + " ");
            }

        }

        public void joe(int vys)
        {
            var joe = Seznam.Select(v => vyska > vys).ToList();
            Console.WriteLine("Hory vetsi nez zadana hodnota: ");
            foreach (var x in joe)
            {
                Console.Write(x + " ");
            }
        }


        public string Vypis()
        {
            string temp = "";
            foreach(var x in Seznam)
            {
                temp = temp + x;
            }
            return temp;
        }
    }
}
