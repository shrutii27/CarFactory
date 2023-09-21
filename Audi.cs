using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary.Model
{
    internal class Audi: ICar
    {
        public void Start()
        {
            Console.WriteLine("Audi is starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Audi is stopping...");
        }
    }
}
