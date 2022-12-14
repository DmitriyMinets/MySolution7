namespace Ex._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item item = new Item();
            Console.WriteLine(item.GetName());
            item.SetName("table");
            Console.WriteLine(item.GetName());

        }
    }
}