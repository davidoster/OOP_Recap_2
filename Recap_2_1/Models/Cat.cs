using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_2_1.Models
{
    internal class Cat : Animal
    {
        public override void Talk()
        {
            Console.WriteLine("Niaou");
            Console.WriteLine();
        }
    }
}
