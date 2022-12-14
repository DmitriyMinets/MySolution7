using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2.Classes
{
    public abstract class Transport
    {
        public abstract Engine Engine { get; init; }
        public abstract void Move();
 
    }


    /*Реализовать структуру классов : 
     * Engine(содержит метод для включения двигателя), 
     * Transport(абстрактный класс), 
     * Car, Plane, 
     * абстрактные члены: 
      -свойство типа Engine 
      -метод Move. 
    Переопределение Move должно вызывать приватную логику движения наследников и включать двигатель.*/

}
