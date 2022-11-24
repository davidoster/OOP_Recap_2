﻿using System;
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
        public List<Human> Humans { get; set; }     
        public List<Animal> Animals { get; set; }     

        public Room(string name, RoomType roomType, Door door, Human human = null, Animal animal = null)
        {
            Name = name;
            Type = roomType;
            Doors = new List<Door>();
            Doors.Add(door); // at least one Door exists per room
            Humans = new List<Human>();
            Humans.Add(human);
            Animals = new List<Animal>();
            Animals.Add(animal);

            Console.WriteLine(this);
        }
        
        public Room(string name, RoomType roomType, Door door, List<Human> humans, List<Animal> animals)
        {
            Name = name;
            Type = roomType;    
            Doors.Add(door); // at least one Door exists per room
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name}\t{Type}\t{Doors}\t");
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
