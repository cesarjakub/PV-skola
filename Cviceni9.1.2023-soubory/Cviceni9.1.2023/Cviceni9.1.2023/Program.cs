using System.Text;
namespace Cviceni9._1._2023
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            //2
            EvidenceUzivatelu eu = new EvidenceUzivatelu();

            eu.addUziv(new Uzivatel("Simon","ryba","Simon@Seznam.cz",999888777));

            eu.zapisDoSouboru();
            Console.WriteLine(eu.LoadUziv());
            */
            /*
            //1
            string path = Directory.GetCurrentDirectory() + @"/druheCvico/joe.txt";

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                int len = (int)fs.Length;
                byte[] bits = new byte[len];
                fs.Read(bits, 0, len);
                for (int x = 0; x < len; x += 16)
                {
                    int cen = Math.Min(16, len - x);
                    byte[] line = new byte[cen];
                    Array.Copy(bits, x, line, 0, cen);
                    Console.Write("{0:16}  ", x);
                    Console.Write(BitConverter.ToString(line));
                    Console.Write("  ");
                    for (int j = 0; j < cen; j++)
                    {
                        if (line[j] < 0x20 || line[j] > 0x7f) line[j] = (byte)'.';
                    }
                    Console.WriteLine(Encoding.ASCII.GetString(line));
                }

            
            }
            */

        }
    }
}