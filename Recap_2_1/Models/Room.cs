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

        public Room(string name, RoomType roomType, Door door)
        {
            Name = name;
            Type = roomType;    
            Doors.Add(door); // at least one Door exists per room
        }
    }
}
