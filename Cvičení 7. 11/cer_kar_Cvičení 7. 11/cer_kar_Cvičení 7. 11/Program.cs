namespace cer_kar_Cvičení_7._11_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mm = new int[10, 10];
            MapGen map = new MapGen(mm);
            Console.WriteLine(map.vypisMapy());
        }
    }
}