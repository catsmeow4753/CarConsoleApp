using System;
using System.Collections.Generic;
using System.IO.Enumeration;

namespace CarConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCatalog carCatalog = new CarCatalog();

            CarCatalogDictionary cat2 = new CarCatalogDictionary();
            cat2.AddCar(new Car() { RegNo = "XX12345", Model = "BMW", Hk = 150 });
            cat2.AddCar("4587508", "BMW", 120);
            cat2.AddCar("6953156", "BMW2", 100);
            cat2.AddCar("3895377", "BMW2", 150);
            cat2.AddCar("3947823", "BMW", 200);
            cat2.PrintCars();
            Console.WriteLine(cat2.GetCar("3895377"));
            /*
            carCatalog.AddCar(new Car() { RegNo = "XX12345", Model = "BMW", Hk = 150 });
            carCatalog.AddCar("4587508", "BMW", 120);
            carCatalog.AddCar("6953156", "BMW2", 100);
            carCatalog.AddCar("3895377", "BMW2", 150);
            carCatalog.AddCar("3947823", "BMW", 200);

            carCatalog.PrintCars();

            carCatalog.DeleteCar("6953156");
            carCatalog.PrintCars();

            Console.WriteLine("Find All Models 'BMW'.");
            List<Car> cars = carCatalog.FindAllModels("BMW");
            foreach (var item in cars)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Max HK: " + carCatalog.FindMaxHk());

            try
            {
                carCatalog.AddCar("XX1234511111", "BMW", 150);
            }
            catch (ArgumentException aex)
            {
                string message = $"Could not add Car.\n{aex.Message}\n";
                Console.WriteLine(message);
            }
            */

            Console.ReadKey();
        }
    }
}