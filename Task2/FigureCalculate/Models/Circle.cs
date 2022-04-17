using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculate.Models
{
   public  class Circle:Figures
    {
        public int Radius { get; set; }
        public double P = Math.PI;
        public override double Calculate()
        {
            return P * Radius * Radius;
        }
    }
}
