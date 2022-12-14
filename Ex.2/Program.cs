using Ex._2.Classes;

namespace Ex._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car() { Engine = new Engine()};
            Plane plane = new Plane() { Engine = new Engine() };
                      
            car.Move();
            plane.Move();
        }
    }
}