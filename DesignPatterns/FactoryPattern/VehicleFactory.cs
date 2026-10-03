using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    //Abstract Factory
    public abstract class VehicleFactory
    {
      public abstract IVehicle CreateVehicle();

        // Core business logic that relies on the product
        public void DeliverVehicle()
        {
            IVehicle vehicle = CreateVehicle();
            Console.WriteLine("Factory is preparing delivery...");
            vehicle.Drive();
        }

    }
}
