using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    class Bus:Car
    {
        public int passengerCount;

        public Bus(string brand, string model, string color, int maxSpeed, int passengerCount):base(brand,model,color,maxSpeed)
        {
            this.passengerCount = passengerCount;
        }

        public override string Info()
        {
            return base.Info() + $"Passenger Count {passengerCount}";
        }
    }
}
