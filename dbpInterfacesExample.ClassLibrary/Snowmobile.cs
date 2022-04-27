using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbpInterfacesExample.ClassLibrary
{
    public abstract class Snowmobile : IVehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

        public string SpeedUp()
        {
            return "Caught air on that last bump.";
        }
    }

    public class Skidoo : Snowmobile
    {

    }

    public class ArcticCat : Snowmobile, IPrintable
    {
        public ArcticCat()
        {
            base.Make = "Arctic Cat";   
        }
        public string Print()
        {
            return $"{base.Make} is of Model: {base.Model}";
        }
    }
}
