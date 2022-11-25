using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_2_1.Models
{
    internal class Animal : Name, IAnimal
    {
        public Room Room { get; set; }
        public Animal(string name)
        {
            FirstName = name;
            Console.WriteLine(this);
        }
        public void Chase()
        {
            throw new NotImplementedException();
        }

        public void Look()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public virtual void Talk()
        {
            Console.WriteLine("Some animal talks!");
        }

        public void Walk()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{FirstName}\t{LastName}";
        }
    }
}
