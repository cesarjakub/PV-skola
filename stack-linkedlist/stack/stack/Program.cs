namespace stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> sta = new MyStack<int>();
            sta.Push(5);
            sta.Push(2);
            sta.Push(3);
            sta.Push(4);


            while (!sta.IsEmpty())
            {
                Console.WriteLine(sta.Pop());
            }

            Console.WriteLine();
            Stack<int> stack = new Stack<int>();

            stack.Push(5);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            
            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            stack.Pop();
            Console.WriteLine(stack.Contains(5));
            

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
        }
    }
}