using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactoryLibrary.Model
{
    public interface IAutoFactory
    {
        ITesla CreateTesla();
        IBMW CreateBMW();
        IAudi CreateAudi();
    }
}
