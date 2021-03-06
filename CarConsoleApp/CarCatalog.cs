using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsoleApp
{
    public class CarCatalog
    {
        public List<Car> carList;

        public CarCatalog()
        {
            carList = new List<Car>();
        }

        public void AddCar(string regNo, string model, int hk)
        {
            AddCar(new Car(regNo, model, hk));
        }

        public void AddCar(Car car)
        {
            if (car.RegNo.Length != 7)
            {
                throw new ArgumentException("Registration Number is not exactly 7 characters long.");
            }
            else if (car.Hk < 0)
            {
                throw new ArgumentException("Hk is less than 0.");
            }
            else if (car.Hk > 2000)
            {
                throw new ArgumentException("Hk is over 2000.");
            }
            else
            {
                carList.Add(car);
            }
        }

        public Car GetCar(string regNo)
        {
            foreach (Car item in carList)
            {
                if (item.RegNo.Equals(regNo))
                {
                    return item;
                }
            }

            return null;
        }

        public void DeleteCar(string regNo)
        {
            carList.Remove(GetCar(regNo));
        }

        public List<Car> FindAllModels(string model)
        {
            List<Car> cars = new List<Car>();

            foreach (Car item in carList)
            {
                if (item.Model.Equals(model))
                {
                    cars.Add(item);
                }
            }

            if (cars.Count > 0)
            {
                return cars;
            }
            else
            {
                return null;
            }
        }

        public Car FindMaxHk()
        {
            Car carMaxHK = new Car(null, null, 0);

            foreach (var item in carList)
            {
                if (item.Hk > carMaxHK.Hk)
                {
                    carMaxHK = item;
                }
            }

            if (carMaxHK.Hk > 0)
            {
                return carMaxHK;
            }
            else
            {
                return null;
            }
        }

        public void PrintCars()
        {
            foreach (var item in carList)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}