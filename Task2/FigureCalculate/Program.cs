using System;
using FigureCalculate.Models;


namespace FigureCalculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Square Hesablayin");
            Console.WriteLine("2.Rectangle Hesablayin");
            Console.WriteLine("3.Trapeze Hesablayin");
            Console.WriteLine("4.Circle Hesablayin");
            string command = Console.ReadLine();
            do
            {

            } while (true);
            switch (command)
            {
                case "1":
                    Console.WriteLine("Square Terefi Yazin");
                    Square square = new Square();
                    square.Size = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(square.Calculate());
                    break;
                case "2":
                    Rectangle rectangle = new Rectangle();
                    Console.WriteLine("Rectangle Width yazin");
                    rectangle.Width= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Rectangle Length yazin");
                    rectangle.Length= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(rectangle.Calculate());
                    break;
                case "3":
                    Trapeze trapeze = new Trapeze();
                    Console.WriteLine("Trapeze width yazin");
                    trapeze.Width= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Trapeze Length yazin");
                    trapeze.Length = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Trapeze Height yazin");
                    trapeze.Height = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(trapeze.Calculate());
                    break;
                case "4": 
                    Circle circle = new Circle();
                    Console.WriteLine("Circle Radiusun Yazin");
                    circle.Radius = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(circle.Calculate());
                    break;
                default:
                    Console.WriteLine("wrong input");
                    break;
            }
        }
    }
}
