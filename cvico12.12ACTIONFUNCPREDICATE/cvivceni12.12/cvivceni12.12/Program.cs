namespace cvivceni12._12
{
    internal class Program
    {
        public delegate void Action<in T1>(T1 arg1);
        static void Main(string[] args)
        {
            /*
            //1
            Func<string, string> selector = str => str.ToUpper();
            string[] words = { "orange", "apple", "Article", "elephant" };
            IEnumerable<String> aWords = words.Select(selector);

            foreach (String word in aWords)
                Console.WriteLine(word);
            Console.WriteLine("====================================================");
            //2 - akce
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            list.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("====================================================");
            //3
            List<int> list2 = new List<int> { 10, 22, 30, 40, 52, 62, 70, 82, 90 };
            Predicate<int> predicate = x => x % 5 == 0;
            foreach(int x in list2)
            {
                Console.WriteLine(predicate(x));
            }
            Console.WriteLine("====================================================");
            */
            Firma firma = new Firma("JOES FIRMA");
            firma.addZam(new Zamestnanec("Honza","Modry", 50000, Pozice.IT, new DateTime(2020, 4, 1)));
            firma.addZam(new Zamestnanec("Jirka", "Zeleny", 20000, Pozice.UKLIZEC, new DateTime(2021, 2, 2)));
            firma.addZam(new Zamestnanec("Kuba", "Cerveny", 25000, Pozice.HLIDAC, new DateTime(2019, 8, 9)));
            firma.addZam(new Zamestnanec("Ondra", "Cerny", 55000, Pozice.OBCHODAK, new DateTime(2010, 4, 3)));
            firma.addZam(new Zamestnanec("Marke", "Prochazka", 40000, Pozice.MARKETING, new DateTime(2022, 6, 2)));
            firma.addZam(new Zamestnanec("Pavel", "Kulhav", 54000, Pozice.OBCHODAK, new DateTime(2015, 8, 4)));

            //nej plat
            Console.WriteLine(firma.nejVyssiPlat());

            //prum plat
            Console.WriteLine("Prum plat: " + firma.prumPlat());

            //prum plat poz
            Console.WriteLine("Prum plat pozice: "+firma.prumPlatPoz(Pozice.IT));
            Console.WriteLine();
            //tri nej plat
            foreach (var x in firma.triNej())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            //podle data
            foreach (var x in firma.podleData())
            {
                Console.WriteLine(x);
            }
            Console.WriteLine();
            //svatek
            foreach (var x in firma.svatek("Honza"))
            {
                Console.WriteLine(x);
            }
        }
    }
}