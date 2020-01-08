using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCTest.Models
{
    public class Room
    {
        public int RoomID { get; set; }
        public string Name { get; set; }
        public int length { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public List<Monster> Monsters { get; set; }
    }
}
