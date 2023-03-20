namespace Cviceni16._1_Autopujcovna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //1
            Zakaznik zak = new Zakaznik("Kuba", "Joe", 654358995, "U potucku");
            Auto a = new Auto("Toyota", "Supra", "4A7 7548");
            //2
            Zakaznik zak1 = new Zakaznik("Ondar", "Kulhavy", 758468922, "Dobris 5");
            Auto a1 = new Auto("Nissan", "R34", "8B4 8568");


            Pujcovna pujcovna = new Pujcovna();
            pujcovna.addAutoZakaznik(zak, a);
            pujcovna.addAutoZakaznik(zak1, a1);
            Console.WriteLine(pujcovna.ToString());
            pujcovna.MyDictionaryToJson();*/

            MorseFile mf = new MorseFile();
            Console.WriteLine(mf.splitFile(0));
            mf.vypis();
        }
    }
}