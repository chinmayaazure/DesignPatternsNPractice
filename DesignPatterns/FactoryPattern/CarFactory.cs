using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    //Concrete Creator /Concrete Factory
    public class CarFactory: VehicleFactory
    {
        public override IVehicle CreateVehicle()   //Returns IProduct
        {
            return new Car();
        }
    
    }
}
