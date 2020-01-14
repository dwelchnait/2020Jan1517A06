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
        }
           
    }
}
