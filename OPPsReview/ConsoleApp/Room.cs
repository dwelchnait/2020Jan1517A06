using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleData
{
    public class Room
    {
        public string Name { get; set; } 
        public List<Wall> Walls { get; set; }
        public List<Window> Windows { get; set; }
        public List<Door> Doors { get; set; }
    }
}
