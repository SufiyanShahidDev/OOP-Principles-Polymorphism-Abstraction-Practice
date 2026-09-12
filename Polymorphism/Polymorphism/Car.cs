using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Car : Vehicle
    {
        public override void start()
        {
            Console.WriteLine("Car starts with a key");
        }
    }
}
