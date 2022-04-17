using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Models
{
   public abstract class Vehicle
    {
        public  int Year { get; set; }
        public string Color { get; set; }

        public Vehicle(int year, string color)
        {
            Color = color;
            Year = year;
        }

        public abstract void ShowInfo();
    }
}
