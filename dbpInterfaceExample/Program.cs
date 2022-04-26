using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using dbpInterfacesExample.ClassLibrary;

namespace dbpInterfaceExample.FrontEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Testing.....");

            Car car = new Car();
            //Console.WriteLine(car.SpeedUp()) ;

            Bicycle bike = new Bicycle();
            //Console.WriteLine(bike.SpeedUp());


            Truck pickup = new Truck();
            //Console.WriteLine(pickup.SpeedUp());

            List<IVehicle> garage = new List<IVehicle> { car, bike, pickup };
            garage.ForEach(v =>
            {
                Console.WriteLine(v.SpeedUp());

                if (v is Car)
                    Console.WriteLine("Taking the car for a spin");
                if (v is Truck)
                    Console.WriteLine("Offroading!");
                if (v is Bicycle)
                    Console.WriteLine("Heading to the boardwalk");

            }
            );

        }
    }
}
