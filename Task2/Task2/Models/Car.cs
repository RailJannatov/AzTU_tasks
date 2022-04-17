using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Models
{
    class Car : Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double MaxSpeed { get; set; }
        public Car(string brand, string model, int year, string color) :base(year,color)
        {
            Brand = brand;
            Model = model;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Color:{Color} Year:{Year} Brand:{Brand} Model:{Model} ");
        }
    }
}
