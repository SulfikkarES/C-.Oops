using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    class VarIntTest : IVariableTest 
    {
        public int x { get; set; }
        public int y { get; set; }

        public VarIntTest()
        {
            x = 10;
            y = 20;
        }//Constructer

        public void Disp()
        {
            Console.WriteLine("Good night");
        }
        public void Display()
        {
            Console.WriteLine($"Value is :{x}");
        }
    }
}
