#region Copyright EazyLearn
//
// All rights are reserved. Reproduction or transmission in whole or in part, 
// in any form or by any means, electronic, mechanical or otherwise, is
// prohibited without the prior written consent of the copyright owner.
//
// Filename        : C#oops.cs
// Purpose         : To practice c# oops 
// Creation Date   : 30-09-2021
// Author          : Sulfikkar E S
//
// Change History  :
// Changed by      :              
// Date            : 
// Purpose         :
//
#endregion Copyright EazyLearn

#region Included namespaces

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion 

namespace Oops
{
    public class Bus :IFunction 
    {
       

        public void Accept()
        {
            Console.WriteLine("Enter the number of doors");
            NoOfDoors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of Wheels");
            NoOfWheels = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Seating Capacity");
            SeatingCapacity = Convert.ToInt32(Console.ReadLine());

        }
        public void Display()
        {
            Console.WriteLine($"number of doors :{NoOfDoors},number of Wheels :{NoOfWheels} " +
                $"and Seating Capacity is : {SeatingCapacity}");
        }

        public void GetFuelType()
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

