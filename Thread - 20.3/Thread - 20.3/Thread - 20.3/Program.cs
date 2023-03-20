using System.Collections.Concurrent;

namespace Thread___20._3
{
    internal class Program
    {
        static object _lock = new object();
        static void Main(string[] args)
        {
            /*Citac citac = new Citac(0);
            Thread t = new Thread(() => Zvys(citac));            
            Thread t1 = new Thread(() => Sniz(citac));
            t.Start();
            t1.Start();
            t.Join();
            t1.Join();
            */
            /*
            //2
            List<int> list = new List<int>();
            Thread thread = new Thread(() => ListGen(list));
            Thread thread1 = new Thread(() => ListGen(list));
            

            Monitor.Enter(_lock);
            try
            {
                thread1.Start();
                thread1.Join();
                thread.Start();
                thread.Join();
                
            }
            finally
            {
                Monitor.Exit(_lock);
                Console.WriteLine(list.Count);
            }

            //3
            ConcurrentBag<int> cb = new ConcurrentBag<int>();
            Thread thread2 = new Thread(() => ListGen(cb));
            Thread thread3 = new Thread(() => ListGen(cb));


            Monitor.Enter(_lock);
            try
            {
                thread2.Start();
                thread2.Join();
                thread3.Start();
                thread3.Join();

            }
            finally
            {
                Monitor.Exit(_lock);
                Console.WriteLine(cb.Count);
            }
            */
            //4







        }

        private static void ListGen(ConcurrentBag<int> cb)
        {
            Random random = new Random();
            for (int i = 0; i < 1_000_000; i++)
            {
                cb.Add(random.Next(100));
            }
        }

        public static void ListGen(List<int> list)
        {
            
            Random random = new Random();
            for(int i = 0; i < 1_000_000; i++)
            {
                list.Add(random.Next(100));
            }
        }



        public static void Zvys(Citac citac)
        {
            for (int i = 0; i < 1_000_000; i++)
            {
                citac.Zvys();
            }
            Console.WriteLine(citac.ToString());
        }

        public static void Sniz(Citac citac)
        {
            for (int i = 0; i < 1_000_000; i++)
            {
                citac.Sniz();
            }
            Console.WriteLine(citac.ToString());
        }
    }
}