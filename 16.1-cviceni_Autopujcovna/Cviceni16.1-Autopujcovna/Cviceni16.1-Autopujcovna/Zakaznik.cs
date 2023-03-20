using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni16._1_Autopujcovna
{
    public class Zakaznik
    {
        private string jmeno;
        private string prijmeni;
        private int tel;
        private string adresa;

        public string Jmeno
        {
            get { return jmeno; }
            set { jmeno = value; }
        }

        public string Prijmeni
        {
            get { return prijmeni; }
            set { prijmeni = value; }
        }

        public int Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }

        public Zakaznik(string jmeno, string prijmeni, int tel, string adresa)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Tel = tel;
            Adresa = adresa;
        }

        public override string? ToString()
        {
            return Jmeno +" "+ Prijmeni + ", tel: "+Tel+", adresa: "+Adresa;
        }
    }
}
