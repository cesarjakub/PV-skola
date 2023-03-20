namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucet ucet = new Ucet(10000, 10000);

            Console.WriteLine(ucet.ToString());
            Console.WriteLine("----------------------------");
            Console.WriteLine("koupil sis neco za: "+ucet.kupSiNeco(5000)+"czk");
            Console.WriteLine(ucet.ToString());
            Console.WriteLine("----------------------------");    
            Console.WriteLine("Doplatil si do limitu: "+ucet.zaplatUtracenouCastku()+"czk");
            Console.WriteLine(ucet.ToString());
            Console.WriteLine("----------------------------");
            Console.WriteLine("na ucte je :"+ucet.czkToEur()+"eur");
            Console.WriteLine("----------------------------");
            ucet.zmarizUcet();
            Console.WriteLine("mate zmrazeny ucet :(");
            Console.WriteLine(ucet.ToString());
        }
    }
}