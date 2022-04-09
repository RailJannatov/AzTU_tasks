using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Car
    {
        public string brand;
        public string model;
        public string color;
        public int maxSpeed;

        public Car()
        {
            Console.WriteLine("Car is created");
        }
        public Car(string brand, string model)
        {
           this.brand = brand;
           this.model = model;
        }
        public Car(string brand, string model, string color,int maxSpeed):this(brand, model)
        {
            this.color = color;
            this.maxSpeed = maxSpeed;
        }
        public virtual string Info()
        {
            return $"brand {brand}, model {model}, color {color}, maxSpeed {maxSpeed}";
        }
    }
}
