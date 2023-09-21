using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary.Model
{
   public class BMWFactory : ICarFactory
    {
        public ICar MakeCar()
        {
            return new BMW();
        }
    }
}
