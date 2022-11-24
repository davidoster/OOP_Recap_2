using Recap_2_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // John has a house. The house has also a garden.
            // John has a cat named Ann.
            // Right now John and Ann are in the living room
            // John walks towards a door that leads to the garden and opens the door
            // Ann runs to the door and steps to the garden
            // Ann suddenly stops and John stares at her to understand why she stopped
            // Ann looks at the mouse Tom, Tom looks at the cat Ann, Ann starts to run and chases Tom

            // John - Human, Ann - Cat (Animal), Tom - Mouse (Animal)
            // House, Garden, Door, (Living) Room
            // Which are the props of the ...?
            // Which are the methods (behaviours) of the ...?
            // Which are the states of the ...???
            // Owns ...???

            House house = new House(new Human("John"), new Animal("Ann"));

        }
    }
}
