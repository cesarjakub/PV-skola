namespace cviceni2410
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyOneWayLinkedList<int> list = new MyOneWayLinkedList<int>();
            list.AddToFront(4);
            list.AddToFront(2);
            list.AddToFront(5);
            list.AddToFront(8);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Get(2));
            foreach (int x in list)
            {
                Console.Write(x+", ");
            }
        }
    }
}