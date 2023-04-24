namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClient cli = new MyClient("127.0.0.1", 65525);
        }
    }
}