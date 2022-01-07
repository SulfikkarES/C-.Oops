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
#endregion included namespaces

namespace Oops
{
    //change the namespace name
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n\t\t *** Menu ***\n");
                Console.WriteLine(" \t 1 : Shape Details" +
                    "\n\t 2 : Telephone " +
                    "\n\t 3 : Interface of VariableTest" +
                    "\n\t 4: Door and Wheel details of a car" +
                    "\n\t 5 : Interface of Car " +
                    "\n\t 6 : Interface of Bus");
                Console.WriteLine("\nPleace Select Any Option : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\n 1 : Shape Details \n\t*******\n");
                        CreateShape();
                        break;
                    case 2:
                        Console.WriteLine("\n 2 : Telephone\n\t*****\n");
                        //change the function name
                        CreateTelephone();
                        break;
                    case 3:
                        Console.WriteLine("\n 3 :Interface of VariableTest \n\t*****\n");
                        CreateInterfaceIVariableTest();
                        break;
                    case 4:
                        Console.WriteLine("\n 4: Door and Wheel details of a car \n\t******\n");
                        CreateCarClassDetails();
                        break;
                    case 5:
                        Console.WriteLine("\n 5 : Interface of Car\n\t******\n");
                        CreateInterfaceIFunction();
                        break;
                    case 6:
                        Console.WriteLine("\n 6 : Interface of Bus\n\t*****\n");
                        CreateBusClass();
                        break;
                    case 7: break;
                    default:
                        Console.WriteLine(" Invalid Option Is Selected ");
                        break;
                }

            } while (choice != 0);
        }//Main End Here

        static void CreateShape()
        {
            //rewrite the program to implement correct access specifiers in base abd derived class
            
            Shape obj = new Shape();
            obj.Getcoord();
            obj.ShowCoord();

            Rectangle obbj = new Rectangle();
            Console.ReadLine();
        }
        //End of CreateShape()
        static void CreateTelephone()
        {
            ElectronicPhone obj = new ElectronicPhone();
            //obj.Ring();
            obj.Ring();
            TalkingPhone obbj = new TalkingPhone();
            obbj.Ring();
            DigitalPhone objj = new DigitalPhone();
            objj.Ring();
            Console.ReadLine();
        }//End of Telephone()

       static void CreateInterfaceIVariableTest()
        {
            VarIntTest obj = new VarIntTest();
            obj.Disp();
            obj.Display();
            Console.ReadLine();
        }// End CreateInterfaceIVariableTest()

        static void CreateCarClassDetails()
        {
            Car obj = new Car();
            obj.Accept();
            obj.Display();
            Console.ReadLine();
        }// End of CreateCarClassDetails()

        static void CreateInterfaceIFunction()
        {
            Car obj = new Car();
            obj.Getfueltype();
            obj.Setfueltype();
            obj.Accept();
            obj.Display();
            Console.ReadLine();
        }//End of CreateInterfaceIFunction()

        static void CreateBusClass()
        {
            Bus obj = new Bus();
            obj.Getfueltype();
            obj.Setfueltype();
            obj.Accept();
            obj.Display();
            Console.ReadLine();
        }//End of CreateBusClass()
    }
}

