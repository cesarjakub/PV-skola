using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cviceni16._1_Autopujcovna
{
    public class MorseFile
    {
        private string path = Directory.GetCurrentDirectory() + @"/morseFile/morse.txt";
        private string text = "";
        string[] lines;
        string[] temp;
        public MorseFile()
        {

        }

        public string splitFile(int index)
        {
            lines = File.ReadAllLines(path);
            temp = lines[index].Split("	");
            foreach (var x in temp)
            {
                text += x;
            }
            return text;
        }

        public string vypis()
        {
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(text);
            }
            return text;
        }
    }
}
