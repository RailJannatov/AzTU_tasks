using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Models
{
    class Bus : Vehicle
    {
        public int PassengerCount { get; set; }
        public Bus(int passengerCount, int year, string color) :base(year,color)
        {
            PassengerCount = passengerCount;   
        }
        public override void ShowInfo()
        {
            Console.WriteLine( $"Color:{Color} Year:{Year} PassengerCount:{PassengerCount}");
        }
    }
}
