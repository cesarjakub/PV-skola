using System.Diagnostics;

namespace Vlakna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Program start");            
            Thread thread = new Thread(new ThreadStart(Program.WriteNumbers));
            thread.Start();
            //thread.Join();
            WriteNumbers();
            Console.WriteLine("Program finish");
            */
            
            var rand = new Random();
            
            ListNumbers list = new ListNumbers();
            for (int i = 0; i < 10_000_000; i++)
            {
                list.Add(rand.Next(10_000));
            }
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            list.Max();
            list.Min();
            stopWatch.Stop();
            Console.WriteLine("Time 1: " + stopWatch.ElapsedMilliseconds + "ms");
            


            ListNumbers l = new ListNumbers();
            for (int i = 0; i < 10_000_000; i++)
            {
                l.Add(rand.Next(10_000));
            }
            Thread thread1 = new Thread(new ThreadStart(l.Max));
            Thread thread2 = new Thread(new ThreadStart(l.Min));
            Stopwatch stopWatch1 = new Stopwatch();
            stopWatch1.Start();

            thread1.Start();
            thread2.Start();
            thread1.Join();
            thread2.Join();

            stopWatch1.Stop();
            Console.WriteLine("Time 2: " + stopWatch1.ElapsedMilliseconds + "ms");

        }

        private static void WriteNumbers()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }
    }
}