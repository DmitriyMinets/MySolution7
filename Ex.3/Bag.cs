using Ex._1;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ex._3
{
    internal class Bag
    {
        private Item[] _item = new Item[8];

        private bool _isOpen;

        private int counter;

        public void Open()
        {
            _isOpen = true;
        }
        public void Close()
        {
            _isOpen = false;
        }
        public void PutIn(Item item)
        {
            if (!_isOpen)
            {
                Console.WriteLine("Сумка закрыта");
                return;
            }

            if (counter == _item.Length)
                Console.WriteLine("Сумка заполнена");
            else
            {
                for (int i = 0; i < _item.Length; i++)
                {
                    if (_item[i] == null)
                    {
                        _item[i] = item;
                        counter++;
                        Console.WriteLine($"Предмет {item.GetName()} добален в сумку");
                        break;
                    }
                }
            }
        }
        public Item GetOut(int index)
        {
            if (!_isOpen)
            {
                return null;
            }

            Item item = _item[index];
            _item[index] = null;
            counter--;
            Console.WriteLine($"Вещь {item.GetName()} была вынута из сумки");

            return item;
        }
    }
}
