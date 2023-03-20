namespace Pole_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //prvni cviceni
            Random random = new Random();
            int[] cisla = new int[10];
            Generuj(cisla);
            Vypis(cisla);

            Console.WriteLine();
            Console.WriteLine("Prumer: "+Prumer(cisla));
            Console.WriteLine();
            Console.WriteLine("Nejmensi cislo: "+NejmensiCislo(cisla));
            Console.WriteLine();
            Console.WriteLine("Pocet cisel delitelna zadanym cislem: "+Delitelna(cisla, 2));
            */



            //druhy cviceni
            List<Uzivatel> list = new List<Uzivatel>();
            list.Add(new Uzivatel("Ondra", "123456789"));
            list.Add(new Uzivatel("Jakub", "gshgadj"));
            list.Add(new Uzivatel("JOEMAMA", "das4d5s1d"));
            list.Add(new Uzivatel("LEMON", "hagdjs46874654"));
            list.Add(new Uzivatel("ZIVOT", "dasdadaWDSA9"));
            //SORT
            Console.WriteLine("Serazeno podle nicknamu:");
            list.Sort();
            foreach (var li in list)
            {
                Console.WriteLine(li.ToString());
            }


            //treti cviceni

            


        }

        public static void Generuj(int[] pole)
        {
            Random random = new Random();
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = random.Next(1, 50);
            }
        }

        public static void Vypis(int[] pole)
        {
            foreach (int i in pole)
            {
                Console.Write(i + " ");
            }
        }

        public static int Prumer(int[] pole)
        {
            int temp = 0;
            int prumer;
            for(int i = 0; i < pole.Length; i++)
            {
                temp += pole[i];
            }
            prumer = temp / pole.Length;
            return prumer;
        }

        public static int NejmensiCislo(int[] pole)
        {
            int max = 100;
            for(int i = 0; i < pole.Length; i++)
            {
                if (pole[i] < max)
                {
                    max = pole[i];
                }
            }
            return max;
        }

        public static int Delitelna(int[] pole, int deilitelneCislo)
        {
            int pocet = 0;
            for(int i = 0; i < pole.Length; i++)
            {
                if (pole[i] % deilitelneCislo == 0)
                {
                    pocet++;
                }
            }
            return pocet;
        }
    }
}