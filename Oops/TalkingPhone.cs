using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops
{
    public  class TalkingPhone : Telephone 
    {
        public TalkingPhone()
        {
            phonetype = "TalkingPhone";
        }
        public override void Ring()
        {
            Console.WriteLine("Ringing the " + phonetype);
        }

    }
}
