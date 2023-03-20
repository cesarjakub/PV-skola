using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST1010
{
    public class Majitel
    {
        private string jmeno;
        private string prijmeni;
        private Auto maAuto;

        public Majitel(string jmeno, string prijmeni, Auto maAuto)
        {
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.maAuto = maAuto;
        }

        public string Jmeno
        {
            get { return this.jmeno; }
            set { this.jmeno = value; }
        }

        public string Prijmeni
        {
            get { return this.prijmeni; }
            set { this.prijmeni = value; }
        }

        public Auto MaAuto
        {
            get { return this.maAuto; }
            set { this.maAuto = value;}
        }

        public override string? ToString()
        {
            return jmeno+" "+prijmeni+" ma "+maAuto.ToString();
        }
    }
}
