using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbpInterfacesExample.ClassLibrary
{
    public interface IVehicle
    {
        string Make { get; set; }
        string Model { get; set; }
        int Speed { get; set; }

        string SpeedUp();
    }
}
