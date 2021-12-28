using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public class Shape
    {
        protected int xAxis, yAxis;

        public void Getcoord()
        {
            Console.WriteLine("Enter x axis");
            xAxis = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y axis");
            yAxis = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowCoord()
        {
            Console.WriteLine($"\n x Coordinate Is : {xAxis} And y Coordinate Is {yAxis}");
        }
    }
}
