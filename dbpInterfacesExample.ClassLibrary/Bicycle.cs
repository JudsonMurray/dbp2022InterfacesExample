using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbpInterfacesExample.ClassLibrary
{
    public class Bicycle : IVehicle, IPrintable
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public int Speed { get; set; }

        public string SpeedUp()
        {
            return "Bicycle is flying! E.T. is having so much fun.";
        }

        public string Print()
        {
            return $"Bicycle of {Make} {Model} going {Speed} kph";
        }

    }
}
