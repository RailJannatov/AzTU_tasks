using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculate.Models
{
    class Rectangle:Figures
    {
        public int  Length { get; set; }
        public int Width { get; set; }
        public override double Calculate()
        {
            return Length * Width;
        }
    }
}
