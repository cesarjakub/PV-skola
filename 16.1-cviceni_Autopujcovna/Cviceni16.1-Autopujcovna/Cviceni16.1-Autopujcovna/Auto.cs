using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni16._1_Autopujcovna
{
    public class Auto
    {
        private string model;
        private string znacka;
        private string spz;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Znacka
        {
            get { return znacka; }
            set { znacka = value; }
        }

        public string Spz
        {
            get { return spz; }
            set { spz = value; }
        }

        public Auto(string model, string znacka, string spz)
        {
            Model = model;
            Znacka = znacka;
            Spz = spz;
        }

        public override string? ToString()
        {
            return "Model: "+Model+", znacka: "+Znacka+", Spz: "+Spz;
        }
    }
}
