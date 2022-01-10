using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarConsoleApp
{
    public class Car
    {
        public string RegNo { get; set; }
        public string Model { get; set; }
        public int Hk { get; set; }

        public Car()
        {
            
        }

        public Car(string regNo, string model, int hk)
        {
            RegNo = regNo;
            Model = model;
            Hk = hk;
        }

        public override string ToString()
        {
            return $"RegNo: {RegNo}, Model: {Model}, Hk: {Hk}";
        }
    }
}