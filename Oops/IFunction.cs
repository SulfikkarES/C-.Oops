using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public interface IFunction
    {
         int NoOfDoors { get; set; }
         int NoOfWheels { get; set; }
         string Fueltype { get; set; }
         int SeatingCapacity { get; set; }
        string Getfueltype();
        string Setfueltype();   
    }
}
