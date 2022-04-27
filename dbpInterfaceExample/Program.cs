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

            //Snowmobile skidoo = new Snowmobile(); // This isn't how we do this
            //Snowmobile skidoo = new Skidoo();
            Snowmobile skidoo = new ArcticCat();
            skidoo.Model = "Type III";

            List<IVehicle> garage = new List<IVehicle> { car, bike, pickup, skidoo };
            garage.ForEach(v =>
            {
                Console.WriteLine(v.SpeedUp());

                if (v is IPrintable)
                    Console.WriteLine(((IPrintable) v ).Print());

                if (v is Car)
                    Console.WriteLine("Taking the car for a spin");
                if (v is Truck)
                    Console.WriteLine("Offroading!");
                if (v is Bicycle)
                    Console.WriteLine("Heading to the boardwalk");

                if (v is Snowmobile)
                    Console.WriteLine("Tear thru that powder.");

                Console.WriteLine();
            }
            );

        }
    }
}
