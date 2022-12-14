using Ex._1;

namespace Ex._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bag bag = new Bag();

            Item item = new Item();
            item.SetName("knife");

            Item item2 = new Item();
            item2.SetName("engine");

            Item item1 = new Item();
            item1.SetName("phone");

            bag.Open();
            bag.PutIn(item);
            bag.PutIn(item1);
            bag.PutIn(item2);
            bag.GetOut(0);
            bag.GetOut(1);
        }
    }
}