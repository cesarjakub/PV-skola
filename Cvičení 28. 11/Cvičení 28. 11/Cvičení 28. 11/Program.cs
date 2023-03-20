namespace Cvičení_28._11_
{
    public class Program
    {
        public delegate int Operation(int a, int b);

        private static int Div(int a, int b)
        {
            return a / b;
        }
        private static int Mul(int a, int b)
        {
            return a * b;
        }
        private static int Sub(int a, int b)
        {
            return a - b;
        }
        private static int Add(int a, int b)
        {
            return a + b;
        }


        public delegate int MyFunction(int x);

        

        static void Main(string[] args)
        {
            /*
            Operation operation = Add;
            Console.WriteLine(operation(12, 5));

            operation = Sub;
            Console.WriteLine(operation(12, 5));

            operation = Mul;
            Console.WriteLine(operation(12, 5));

            operation = Div;
            Console.WriteLine(operation(12, 5));
            */
            /*
            Random random = new Random();
            Operation[] operations = { Add, Sub, Mul, Div };
            int x = random.Next(100);
            int y = random.Next(100);

            Console.Write("Vyberte pocetni operaci: ");
            int vyber = int.Parse(Console.ReadLine());
            Console.WriteLine(x+" + "+y+" = ");
            Console.WriteLine(operations[vyber](x,y));
            */

            
            MyFunction Square = x => x * x;
            MyFunction Cube = x => x * x * x;
            MyFunction Signum = x => x > 0 ? 1 : x < 0 ? -1 : 0;
            MyFunction Factorial = x =>
            {
                if (x < 0) throw new Exception();
                if (x < 2) return 1;
                int n = 1;
                for(int i = 0; i < x; i++)
                {
                    n *= i;
                }
                return n;
            };



            MyFunction[] fun = {Square, Cube, Signum, Factorial};
            Console.Write("Vyberte pocetni operaci: ");
            int vyber = int.Parse(Console.ReadLine());

            Console.WriteLine(fun[vyber](5));


        }


    }



}