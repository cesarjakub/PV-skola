namespace TEST1010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto(45, 23);
            Auto nakladni = new NakladniAuto(12,80,40);

            auto.DolitiNadrze(3);

            Majitel majitel = new Majitel("Jan", "Novák", auto);
            Majitel majitel1 = new Majitel("Karel", "Sykora", nakladni);

            Console.WriteLine(majitel.ToString());
            Console.WriteLine(majitel1.ToString());
        }
    }
}