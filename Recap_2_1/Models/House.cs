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

        public House()
        {
            Door door = new Door();
            Rooms = new List<Room>()
            { 
                new Room("Living Room", RoomType.LIVING_ROOM, door), // Rooms.Add(new Room("Living Room"));
                new Room("Garden", RoomType.GARDEN, door),
            };
        }
    }
}
