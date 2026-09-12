using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class ACremote : Remote
    {
        public override void TurnOn()
        {
            Console.WriteLine("AC turn on");
        }
    }
}
