using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculate.Models
{
    public class Trapeze:Figures
    {
        public int Width { get; set; }
        public  int Length { get; set; }
        public int Height { get; set; }
        public override double Calculate()
        {
            return (Width + Length) / 2 * Height;   
        }
    }
}
