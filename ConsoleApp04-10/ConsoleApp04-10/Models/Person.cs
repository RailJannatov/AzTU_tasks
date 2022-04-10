using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp04_10.Models
{
    class Person
    {
        private string _name;
        private string _surname;
        private int _age;
        public string Name {
            get =>_name;
            set
            {
                if (!string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value))
                {
                    _name = value;
                }
            } 
        }
        public string Surname { get; set; }
        public int Age {
            get => _age;
            set
            {
                if (value > 0 && value < 180)
                {
                    _age = value;
                }
                else Console.WriteLine("Duzgun daxil edin!");
            }
        }





    }
}
