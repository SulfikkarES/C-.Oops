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
