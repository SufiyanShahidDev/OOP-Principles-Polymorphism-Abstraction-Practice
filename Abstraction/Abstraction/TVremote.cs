using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class TVremote : Remote
    {
        public override void TurnOn()
        {
            Console.WriteLine("TV turn on");
        }
    }
}
