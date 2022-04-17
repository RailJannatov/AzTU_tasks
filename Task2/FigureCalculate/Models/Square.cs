using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculate.Models
{
    public class Square:Figures
    {
        public int Size { get; set; }
        public override double Calculate()
        {
            return Size * Size;   
        }
    }
}
