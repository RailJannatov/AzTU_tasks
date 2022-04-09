using ConsoleApp1.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car("Hyundai", "Sonata", "Black", 240);

            Bus bus = new Bus("Mercedes", "Benz", "Red", 200, 40);
            Console.WriteLine(bus.Info());
            
        }
    }
}
