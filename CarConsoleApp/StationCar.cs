using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsoleApp
{
    public class StationCar : Car
    {
        public int Volume { get; set; }

        public StationCar(string regNo, string model, int hk, int volume) : base(regNo, model, hk)
        {
            Volume = volume;
        }

        public override string ToString()
        {
            return base.ToString() + $" Volume: {Volume}";
        }
    }
}