using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cer_kar_Cvičení_7._11_
{
    public class MapGen
    {
        private int[,] newmap;
        private Random random;

        public MapGen(int[,] newmap)
        {
            Newmap = newmap; 
            random = new Random();
            ranDomov();
            ranBab();
        }

        public int[,] Newmap
        {
            get { return newmap; }
            set { newmap = value; }
        }

        public void ranDomov()
        {
            int domov = 68;
            int x = random.Next(0, 10);
            int y = random.Next(0, 10);
            newmap[x, y] = domov;
        }

        public void ranBab()
        {
            int bab = 86;
            int x = random.Next(0, 10);
            int y = random.Next(0, 10);
            newmap[x, y] = bab;
        }

        public string vypisMapy()
        {
            string text = "";
            for (int row = 0; row < newmap.GetUpperBound(0); row++)
            {
                for (int col = 0; col < newmap.GetUpperBound(1); col++)
                {
                    text += newmap[row, col]+" ";
                }
                text += "\n";
            }
            return text;
        }
    }
}
