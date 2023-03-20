namespace tretihodina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //politik
            Clovek c = new Politik("Honza");
            Console.WriteLine(c.ToString());

            //svetec
            Clovek c1 = new Svetec("Abel");
            Console.WriteLine(c1.ToString());

            //clovek
            Clovek c2 = new Clovek("Ondra");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(c2.ToString());
            }
        }
    }
}