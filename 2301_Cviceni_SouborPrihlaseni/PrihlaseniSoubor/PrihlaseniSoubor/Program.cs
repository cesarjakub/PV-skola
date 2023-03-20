namespace PrihlaseniSoubor
{
    public class Program
    {
        static void Main(string[] args)
        {
            LoginTO();

        }

        public static void create()
        {
            string username = "";
            string password = "";
            Console.Write("Username: ");
            username = Console.ReadLine();
            Console.Write("Password: ");
            password = Console.ReadLine();

            Kontrola kontrola = new Kontrola();
            Console.WriteLine(kontrola.CreateNewAccount(username, password));
        }

        public static void LoginTO()
        {
            string username = "";
            string password = "";
            Console.Write("Username: ");
            username = Console.ReadLine();
            Console.Write("Password: ");
            password = Console.ReadLine();

            Kontrola kontrola = new Kontrola();
            Console.WriteLine(kontrola.LoginToAccount(username, password));
        }
    }
}