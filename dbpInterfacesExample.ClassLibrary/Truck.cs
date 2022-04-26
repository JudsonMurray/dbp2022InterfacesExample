using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbpInterfacesExample.ClassLibrary
{
    public class Truck : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

        public string SpeedUp()
        {
            return "Truck is moving now.";
        }
    }
}
