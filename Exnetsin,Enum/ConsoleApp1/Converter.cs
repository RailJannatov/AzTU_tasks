using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Converter
    {
        public double Exchange(Currency currency,double azn)
        {
            switch (currency)
            {
                case Currency.USD:
                    return 0.59 * azn;
                case Currency.EUR:
                    return 0.53 * azn;
                case Currency.TRY:
                    return 8.73 * azn;            
                case Currency.RUB:
                    return 52.21 * azn;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }
            return -1;
        }
    }
}
