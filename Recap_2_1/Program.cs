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

            House house = new House(new Human("John"), new Cat("Ann"));
            IHuman john = house.Rooms[0].Humans[0];
            john.Walk();
            john.OpenDoor();
            //house.Rooms[0].Humans[0].LastName = "Johnakis";
            //Console.WriteLine(house.Rooms[0].Humans[0]);

            // Exercises from HOME
            // 1. Place cat Ann to the Garden
            Room livingRoom = house.Rooms[0];
            Room garden = house.Rooms[1];
            IAnimal ann = livingRoom.Animals[0]; // υπόθεση
            garden.Animals.Add(ann);
            livingRoom.Animals.Remove(ann);
            Console.WriteLine(livingRoom);
            Console.WriteLine(garden);

            IAnimal someAnimal = new Cat("sdfsdf");
            IAnimal someAnimal2 = new Mouse("sdfsdf");
            IAnimal someAnimal3 = new Animal("sdsdf");
            Animal animal = new Cat("Ann2");

            // 2. Make John to be the owner of:
            // 2a. House
            // 2b. cat's Ann

        }
    }
}
