using System.Security.Cryptography;
using System.Text;

namespace massenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userpick = 0;
            Registrace reg = new Registrace();
            
            do
            {
                Console.WriteLine("+----------------+");
                Console.WriteLine("| 1) Registrace  |");
                Console.WriteLine("| 2) Login       |");
                Console.WriteLine("| 3) Konec       |");
                Console.WriteLine("+----------------+");
                userpick = Convert.ToInt32(Console.ReadLine());
                
                if (userpick == 1)
                {
                    while (true)
                    {
                        Console.Write("Zadejte jmeno: ");
                        string name = Console.ReadLine();
                        Console.Write("Zadejte Heslo: ");
                        string password = Console.ReadLine();
                        Console.Write("Zadejte Heslo znovu: ");
                        string password2 = Console.ReadLine();
                        if (password == password2)
                        {
                            reg.addToDB(new Uzivatel(name, password));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("spatne heslo");
                        }
                    }
                }

                if (userpick == 2)
                {
                    if (reg.logIN()) {
                        while (true)
                        {
                            Console.WriteLine("+----------------+");
                            Console.WriteLine("| 3) Chat        |");
                            Console.WriteLine("+----------------+");
                        }
                    }
                }

            } while (userpick != 3);

        }
    }
}