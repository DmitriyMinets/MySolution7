using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2.Classes
{
    internal class Car : Transport
    {
        public override Engine Engine { get; init; }

        public override void Move()
        {
            Engine.Start();
            Console.WriteLine("Машина начала движение");
        }
    }
}
