using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2.Classes
{
    public class Engine
    {
        public void Start()
        {
            Console.WriteLine("Двигатель включён");
        }
    }

}


    /*Реализовать структуру классов : 
     * Engine(содержит метод для включения двигателя), 
     * Transport(абстрактный класс), 
     * Car, Plane, абстрактные члены: 
      -свойство типа Engine 
      -метод Move. 
    Переопределение Move должно вызывать приватную логику движения наследников и включать двигатель.*/
