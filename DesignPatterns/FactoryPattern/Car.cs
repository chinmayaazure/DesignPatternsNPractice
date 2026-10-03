using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    //Concrete Product
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("Drive Car");
        }
    }
}
