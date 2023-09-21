using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary.Model
{
    internal class Tesla : ICar
    {
        public void Start()
        {
            Console.WriteLine("Tesla is starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Tesla is stopping...");
        }
    }
}
