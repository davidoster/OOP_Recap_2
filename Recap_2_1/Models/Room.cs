using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_2_1.Models
{
    internal class Room
    {
        public string Name { get; set; }
        public RoomType Type { get; set; }
        public List<Door> Doors { get; set; }
        // Human (IHuman), Animal (IAnimal)
        public List<IHuman> Humans { get; set; }     
        public List<IAnimal> Animals { get; set; }     

        public Room(string name, RoomType roomType, Door door, IHuman human = null, IAnimal animal = null)
        {
            Name = name;
            Type = roomType;
            Doors = new List<Door>();
            Doors.Add(door); // at least one Door exists per room
            Humans = new List<IHuman>();
            if (human != null) Humans.Add(human); // ? ternary or ?? null coalescing or ??= 
            Animals = new List<IAnimal>();
            Animals.Add(animal);
            Console.WriteLine("From the room");
            Console.WriteLine(this);
        }

        public Room(string name, RoomType roomType, Door door)
        {
            Name = name;
            Type = roomType;
            Doors = new List<Door>();
            Doors.Add(door); // at least one Door exists per room
            Humans = new List<IHuman>();
            Animals = new List<IAnimal>();
            Console.WriteLine("From the room2");
            Console.WriteLine(this);
        }

        public Room(string name, RoomType roomType, Door door, List<IHuman> humans, List<IAnimal> animals)
        {
            Name = name;
            Type = roomType;
            Doors = new List<Door>();
            Doors.Add(door); // at least one Door exists per room
            Humans = new List<Human>();
            Animals = new List<Animal>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name}\t{Type}");
            foreach (var door in Doors)
            {
                sb.AppendLine(door.ToString());
            }
            foreach (var human in Humans)
            {
                sb.AppendLine(human.ToString());
            }
            foreach (var animal in Animals)
            {
                sb.AppendLine(animal.ToString());
            }
            return sb.ToString();
        }

    }
}
