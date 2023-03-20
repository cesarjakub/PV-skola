namespace Cviceni1710
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            SeznamUdalosti se = new SeznamUdalosti();
            se.Add(new MyEvent(Typ.Aplikacni, Uroven.Informace, ":("));
            se.Add(new MyEvent(Typ.Systemova, Uroven.Varovani, ":("));
            se.Add(new MyEvent(Typ.Hardware, Uroven.Chyba, ":("));
            se.Add(new MyEvent(Typ.Systemova, Uroven.Chyba, ":("));
            se.Add(new MyEvent(Typ.Aplikacni, Uroven.Varovani, ":("));
            se.Add(new MyEvent(Typ.Hardware, Uroven.Informace, ":("));

            Console.WriteLine(se.ToString());
            Console.WriteLine("Filtr: ");
            
            Console.WriteLine(se.fitrstring(Typ.Any, Uroven.Informace));
            
        }
    }
}