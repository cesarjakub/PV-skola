namespace druhahodina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interval interval = new Interval(10, 2);
            interval.Horni_interval = 22;
            Interval interval2 = new Interval(28, 25);


            Console.WriteLine(interval.Horni_interval+"------------------------------"+interval.Dolni_interval);
            Console.WriteLine(interval.nachaziSe(5));
            Console.WriteLine(interval.Prunik(interval2));
            
        }
    }
}