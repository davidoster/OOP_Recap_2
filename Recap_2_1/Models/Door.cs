using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_2_1.Models
{
    internal class Door : IDoor
    {
        public Door()
        {
            Console.WriteLine("This is a door");
        }

        public void Open()
        {
            Console.WriteLine("The door is opened");
        }

        public override string ToString()
        {
            return "door";
        }
    }
}
