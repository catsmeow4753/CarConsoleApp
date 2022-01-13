using System;
using System.Collections.Generic;
using System.IO.Enumeration;

namespace CarConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Test af CarCatalogDictionary
            CarCatalogDictionary carCatalogDictionary = new CarCatalogDictionary();
            carCatalogDictionary.AddCar(new Car() { RegNo = "XX12345", Model = "BMW", Hk = 150 });
            carCatalogDictionary.AddCar("4587508", "BMW", 120);
            carCatalogDictionary.AddCar("6953156", "BMW2", 100);
            carCatalogDictionary.AddCar("3895377", "BMW2", 150);
            carCatalogDictionary.AddCar("3947823", "BMW", 200);
            carCatalogDictionary.PrintCars();
            Console.WriteLine(carCatalogDictionary.GetCar("3895377"));

            CarCatalog carCatalog = new CarCatalog();

            // Test af AddCar
            carCatalog.AddCar(new Car() { RegNo = "XX12345", Model = "BMW", Hk = 150 });
            carCatalog.AddCar("4587508", "BMW", 120);
            carCatalog.AddCar("6953156", "BMW2", 100);
            carCatalog.AddCar("3895377", "BMW2", 150);
            carCatalog.AddCar("3947823", "BMW", 200);

            carCatalog.PrintCars();

            // Test af DeleteCar
            carCatalog.DeleteCar("6953156");
            carCatalog.PrintCars();

            // Test af FindAllModels med model BMW
            Console.WriteLine("Find All Models 'BMW'.");
            List<Car> cars = carCatalog.FindAllModels("BMW");
            foreach (var item in cars)
            {
                Console.WriteLine(item.ToString());
            }

            // Test af FindMaxHK
            Console.WriteLine("Max HK: " + carCatalog.FindMaxHk());

            // Test af exceptions
            try
            {
                carCatalog.AddCar("XX1234511111", "BMW", 150);
            }
            catch (ArgumentException aex)
            {
                string message = $"Could not add Car.\n{aex.Message}\n";
                Console.WriteLine(message);
            }

            Console.ReadKey();
        }
    }
}