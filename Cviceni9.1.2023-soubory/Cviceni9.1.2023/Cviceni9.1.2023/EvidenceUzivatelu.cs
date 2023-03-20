using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace Cviceni9._1._2023
{
    public class EvidenceUzivatelu
    {

        private string path = Directory.GetCurrentDirectory()+@"/uzivatele/uziv.txt";
        private List<Uzivatel> uziv = new List<Uzivatel>();
        private StreamWriter writer;

        public List<Uzivatel> Uziv
        {
            get { return uziv; }
            set { uziv = value; }
        }

        public EvidenceUzivatelu()
        {

        }

        public void addUziv(Uzivatel uziv)
        {
            Uziv.Add(uziv);
        }

        public void zapisDoSouboru()
        {
            writer = new StreamWriter(path, true);
            foreach (var x in Uziv)
            {
                writer.WriteLine(x);
            }
            writer.Close();
        }

        public string LoadUziv()
        {
            string[] line = File.ReadAllLines(path);
            string text = "";
            foreach(var x in line)
            {
               text += x.ToString()+"\n";
            }
            return text;
        }
    }
}
