using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    //public class Telephone
    //{
    //    protected string phonetype;
    //    public void Ring()
    //    {
    //        Console.WriteLine("Ringing the " +phonetype);
    //    }


    //}
    public abstract class Telephone
    {
        //follow naming standards for variables
        protected string phonetype {get;set;}
        public abstract void Ring();


 
    }

}
