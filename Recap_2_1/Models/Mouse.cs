using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_2_1.Models
{
    internal class Mouse : Animal
    {
        public Mouse(string name) : base(name)
        {
        }

        public override void Talk()
        {
            Console.WriteLine("Squeaks");
        }
    }
}
