namespace pretezovanioperatoru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            komplexniCislo komcislo = new komplexniCislo(5,7);
            komplexniCislo komcislo1 = new komplexniCislo(5, 7);
            Console.WriteLine(komcislo == komcislo1);
            Console.WriteLine(komcislo + komcislo1);
            Console.WriteLine(komcislo - komcislo1);
        }
    }
}