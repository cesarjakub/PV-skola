namespace kolekce
{
    internal class Program
    {
        static void Main(string[] args)
        {   /*
            int[] pole = new int[10];
            generovani(pole);
            Console.WriteLine("pole");
            vypis(pole);
            List<int> list = new List<int>();
            LinkedList<int> list2 = new LinkedList<int>();
            HashSet<int> list3 = new HashSet<int>();
            SortedSet<int> list4 = new SortedSet<int>();

            foreach (int i in pole)
            {
                list.Add(i);
                list2.AddLast(i);
                list3.Add(i);
                list4.Add(i);
            }
            Console.WriteLine();
            Console.WriteLine("list");
            foreach (int i in list)
            {
                Console.Write(i+",");
            }
            Console.WriteLine();
            Console.WriteLine("linked list");
            foreach (int i in list2)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
            Console.WriteLine("hashset");
            foreach (int i in list3)
            {  
                Console.Write(i + ",");
            }
            Console.WriteLine();
            Console.WriteLine("sortedset");
            foreach (int i in list4)
            {    
                Console.Write(i + ",");
            }
            */


        }

        public static void generovani(int[] pole)
        {
            Random rand = new Random();
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = rand.Next(5)+1;
            }
        }
        public static void vypis(int[] pole)
        {
            foreach (int i in pole)
            {
                Console.Write(i+",");
            }
        }
    }
}