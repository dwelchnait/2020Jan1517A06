using ConsoleData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an instance of the window class using the default constructor
            // program NEVER calls a constructor directly
            // the new will use the suggested constructor
            // the actual call to the constructor is done by new
            Window theWindowD = new Window();

            Console.WriteLine($"width {theWindowD.Width}; height {theWindowD.Height}; " +
                $"Panes {theWindowD.NumberOfPanes}; Manufacturer >{theWindowD.Manufacturer}<");

            //to place data within the new instance of the class (object)
            //   use the properties
            //to reference a property within an instance use the dot operator
            theWindowD.Manufacturer = "All Weather";
            theWindowD.Width = .9m;
            theWindowD.NumberOfPanes = 2;


            Console.WriteLine($"width {theWindowD.Width}; height {theWindowD.Height}; " +
                $"Panes {theWindowD.NumberOfPanes}; Manufacturer >{theWindowD.Manufacturer}<");

            Window theWindowG = new Window(2.6m, 1.75m, 12, "Fancy Windows");

            Console.WriteLine($"width {theWindowG.Width}; height {theWindowG.Height}; " +
               $"Panes {theWindowG.NumberOfPanes}; Manufacturer >{theWindowG.Manufacturer}<");
            Console.WriteLine("\n\n");

            Door theDoorD = new Door();

            Console.WriteLine($"width {theDoorD.Width}; height {theDoorD.Height}; " +
                $"Direction {theDoorD.RightOrLeft}; Material >{theDoorD.Material}<");

            Door theDoorG = new Door(1.2m,1.9m,"L","wood");

            Console.WriteLine($"width {theDoorG.Width:0.0}; height {theDoorG.Height}; " +
                $"Direction {theDoorG.RightOrLeft}; Material >{theDoorG.Material}<");

            Console.WriteLine("width {0:0.0}; height {1}; " +
                "Direction {2}; Material >{2}<", theDoorG.Width, theDoorG.Height,
                theDoorG.RightOrLeft, theDoorG.Material);

            //theDoorG.RightOrLeft = "M"; //will cause a run time abort
            Console.WriteLine($"width {theDoorG.Width}; height {theDoorG.Height}; " +
               $"Direction {theDoorG.RightOrLeft}; Material >{theDoorG.Material}<");

            Console.WriteLine("\n\n");

            Console.WriteLine($"Default window area {theWindowD.WindowArea()};" +
                $"Default window perimeter {theWindowD.WindowPerimeter()}");
            Console.WriteLine($"Greedy window area {theWindowG.WindowArea()};" +
               $"Default window perimeter {theWindowG.WindowPerimeter()}");
            Console.WriteLine($"Default door area {theDoorD.DoorArea()};" +
                $"Default door perimeter {theDoorD.DoorPerimeter()}");
            Console.WriteLine($"Greedy door area {theDoorG.DoorArea()};" +
                $"Default door perimeter {theDoorG.DoorPerimeter()}");

            Console.WriteLine("\n\n");
            UsingClasses();
        }

        static void UsingClasses()
        {
            //declare the needed List<T> for estimating paint job
            List<Wall> walls = new List<Wall>();
            List<Door> doors = new List<Door>();
            List<Window> windows = new List<Window>();
            Room room = new Room();

            //loop of prompt/input/validate for walls
            Wall wall = new Wall();
            //prompt, read, validate
            wall.Width = 6.6m;
            wall.Height = 3.1m;
            walls.Add(wall);
            wall = new Wall();
            wall.Width = 6.6m;
            wall.Height = 3.1m;
            walls.Add(wall);
            wall = new Wall();
            wall.Width = 5.6m;
            wall.Height = 3.1m;
            walls.Add(wall);
            wall = new Wall();
            wall.Width = 5.6m;
            wall.Height = 3.1m;
            walls.Add(wall);

            //loop of prompt/input/validate for windows
            Window window = new Window();
            window.Width = 1.5m;
            window.Height = 1.2m;
            window.Manufacturer = "All Weather";
            window.NumberOfPanes = 3;
            windows.Add(window);

            //loop of prompt/input/validate for doors
            Door door = new Door();
            door.Width = .85m;
            door.Height = 2.0m;
            door.Material = "wood";
            door.RightOrLeft = "R";
            doors.Add(door);
            door = new Door();
            door.Width = .85m;
            door.Height = 2.0m;
            door.Material = "wood";
            door.RightOrLeft = "L";
            doors.Add(door);
            door = new Door();
            door.Width = .85m;
            door.Height = 2.0m;
            door.Material = "wood";
            door.RightOrLeft = "L";
            doors.Add(door);

            //store all characteristic of Room
            room.Name = "Master Bedroom";
            room.Walls = walls;
            room.Doors = doors;
            room.Windows = windows;

            //paint can coverage: 27.87 sq m

            //how many cans of paint do I need to cover the walls
            //calculate the area of the walls
            decimal wallarea = 0.0m;
            foreach(Wall item in room.Walls)
            {
                wallarea += item.WallArea();
            }
            //calculate the area of the doors
            decimal doorarea = 0.0m;
            for (int i = 0; i < room.Doors.Count; i++)
            {
                doorarea += room.Doors[i].DoorArea();
            }
            //calculate the area of the windows
            decimal windowarea = 0.0m;
            foreach (var item in room.Windows)
            {
                windowarea += item.WindowArea();
            }

            //calculate net area of walls
            decimal netWallArea = wallarea - (doorarea + windowarea);

            //calculate the number of require paint cans
            decimal cansOfPaint = netWallArea / 27.87m;

            //output the results
            Console.WriteLine($"Wall area is:\t{wallarea:0.00}");
            Console.WriteLine($"Door area is:\t{doorarea:0.00}");
            Console.WriteLine($"Window area is:\t{windowarea:0.00}");
            Console.WriteLine($"Net Wall area is:\t{netWallArea:0.00}");
            Console.WriteLine($"Required number of paint cans is:\t{cansOfPaint:0.00}");
        }

    }
}
