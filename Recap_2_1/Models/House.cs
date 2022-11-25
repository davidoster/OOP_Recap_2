using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recap_2_1.Models
{
    internal class House
    {
        public List<Room> Rooms { get; set; }
        public IHuman Owner { get; set; }

        public House()
        {
            Door door = new Door();
            Rooms = new List<Room>()
            { 
                new Room("Living Room", RoomType.LIVING_ROOM, door), // Rooms.Add(new Room("Living Room"));
                new Room("Garden", RoomType.GARDEN, door),
            };
        }

        public House(Human human, Animal animal)
        {
            Door door = new Door();
            Rooms = new List<Room>()
            {
                new Room("Living Room", RoomType.LIVING_ROOM, door, human, animal), // Rooms.Add(new Room("Living Room"));
                new Room("Garden", RoomType.GARDEN, door, null, new Mouse("Tom"))
            };
            human.Room = Rooms[0];
            animal.Room = Rooms[0];
            Owner = human;
            //Console.WriteLine("Form the house");
            //Console.WriteLine(this);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var room in Rooms)
            {
                sb.AppendLine(room.ToString());
            }
            return sb.ToString();
        }
    }
}
