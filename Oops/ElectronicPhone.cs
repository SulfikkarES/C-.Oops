using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public  class ElectronicPhone : Telephone 
    {
        public ElectronicPhone()
        {
            phonetype = "Digital";
        }

        public override void Ring()
        {
            Console.WriteLine("Good Evening");
        }

       
    }
}
