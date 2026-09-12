using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Bike : Vehicle
    {
        public override void start()
        {
            Console.WriteLine("Bike starts with a kick");
        }
    }       
}
