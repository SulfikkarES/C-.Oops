using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public class Car : IFunction 
    {//following coding standards
  

        public void Accept()
        {
            Console.WriteLine("Enter the number of doors");
            NoOfDoors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of Wheels");
            NoOfWheels = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine($"number of doors :{NoOfDoors},number of Wheels :{NoOfWheels}");
        }

        public void Getfueltype()
        {
            Console.WriteLine("Enter the fueltype :");
            Fueltype = Console.ReadLine();
        }
        public void Setfueltype()
        {
            Console.WriteLine($"The fueltype is:{Fueltype}");
        }

    }
}
