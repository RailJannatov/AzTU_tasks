using System;
using Task2.Models;
using Task2.Mosels;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //string UserName;
            //string Password;

            //do
            //{
            //    Console.WriteLine("UserName daxil edin");
            //    UserName = Console.ReadLine();
            //    if (string.IsNullOrEmpty(UserName)||UserName.Length<6)
            //    {
            //        Console.WriteLine( "Sehv daxil edilib");
            //    }

            //} while (string.IsNullOrEmpty(UserName) || UserName.Length < 6);

            //do
            //{
            //    Console.WriteLine("Passord daxil edin");
            //    Password = Console.ReadLine();
            //    if (!User.PasswordChek(Password))
            //    {
            //        Console.WriteLine("Sehv daxil edilib");
            //    }

            //} while (!User.PasswordChek(Password));

            //Admin admin = new Admin(UserName, Password, true, "sistem");
            //admin.Info();
            #endregion
            Bus bus = new Bus(23,2002,"black");
            Car car = new Car("bmw", "x5",2005, "black");
            Vehicle[] vehicles = new Vehicle[0];
            int a = 5;

            Array.Resize(ref vehicles, vehicles.Length + 1);
            vehicles[vehicles.Length - 1] = car;
            //vehicles[^1] = car;
            Array.Resize(ref vehicles, vehicles.Length + 1);
            vehicles[vehicles.Length - 1] = bus;
            foreach (var item in vehicles)
            {
                item.ShowInfo();
            }
        }
    }
}
