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
        List<Human> Humans { get; set; }     
        List<Animal> Animals { get; set; }     

        public Room(string name, RoomType roomType, Door door, Human human = null, Animal animal = null)
        {
            Name = name;
            Type = roomType;    
            Doors.Add(door); // at least one Door exists per room
            Humans.Add(human);
            Animals.Add(animal);
        }
        
        public Room(string name, RoomType roomType, Door door, List<Human> humans, List<Animal> animals)
        {
            Name = name;
            Type = roomType;    
            Doors.Add(door); // at least one Door exists per room

         

        }
        
    }
}
