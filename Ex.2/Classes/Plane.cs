using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2.Classes
{
    internal class Plane : Transport
    {
        public override Engine Engine { get; init; }

        public override void Move()
        {
            Engine.Start();
            Console.WriteLine("Самолёт начал движение");
        }
    }
}
