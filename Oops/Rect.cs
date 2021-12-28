using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{

    public class Rectangle : Shape 
    {
        public void ShowCoord()
        {
            Console.WriteLine($"\n x Length Is : {xAxis} And Breadth Is {yAxis}");
        }

    }
}
