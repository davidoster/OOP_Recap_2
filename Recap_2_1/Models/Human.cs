using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_2_1.Models
{
    internal class Human : Name, IHuman
    {
        public Room Room { get; set; }
        public Human(string name)
        {
            FirstName = name;
            Console.WriteLine(this);
        }
        public void Look()
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            throw new NotImplementedException();
        }

        public void Talk()
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            Console.WriteLine($"Human {FirstName} walks!!");
        }

        public void OpenDoor()
        {
            Room.Doors[0].Open();
        }

        public override string ToString()
        {
            return $"{FirstName}\t{LastName}";
        }
    }
}
