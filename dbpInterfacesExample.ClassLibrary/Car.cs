using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbpInterfacesExample.ClassLibrary
{
    public class Car : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

        public double FuelLevel { get; set; }

        public string SpeedUp()
        {
            return "Car is going faster!";
        }

        public void Fillup (double litres)
        {
            FuelLevel += litres;

            return;
        }


    }
}
