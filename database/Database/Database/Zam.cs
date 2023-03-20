using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Zam
    {
        private int id;
        private string jmeno;
        private string prijmeni;
        private int vek;

        public int ID { get => id; set => id = value; }
        public string Jmeno { get => jmeno; set => jmeno = value; }
        public string Prijmeni { get => prijmeni; set => prijmeni = value; }
        public int Vek { get => vek; set => vek = value; }

        public Zam(int id, string jmeno, string prijmeni, int vek)
        {
            this.ID = id;
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.vek = vek;
        }

        public Zam(string jmeno, string prijmeni, int vek)
        {
            this.ID = 0;
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.vek = vek;
        }
    }
}
