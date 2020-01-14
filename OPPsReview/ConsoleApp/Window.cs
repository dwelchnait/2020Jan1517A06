using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleData
{
    //a class represents the defined characteristics of a item
    //an item can be a physical thing (cellphone), concept (student),
    //  collection of data
    //visual studio creates your class without a specific access type
    //the default type for a class is private
    //code outside of a private class cannot use the contents of the private class
    //for the class to  be used by and outside user it must be public
    public class Window
    {
        //the class can have data that is open to the user by
        //  defining it as a public datatype variablename
        //the class can have data that is restrict from the user
        //  by defining it as a private datatype variablename
        //the class can create a Property that can be used to
        //   interface between the user and the private data
        //the Property will have public access

        //Private data member
        private string _Manufacturer;
        private decimal _Height;

        //Properties
        //optional
        //properties can be implemented in two ways
        //a) Fully Implemented property
        //    used because there is additional code/logic use
        //    in processing the data
        //b) Auto Implemented property
        //    used when there is no need for additonal code/logic,
        //    when the data is simply saved

        // example of a Fully implemented property
        public string Manufacturer
        {
            //assume the Manufacturer is a nullable string
            // 3 possibilities
            //  a)there are characters
            //  b)string has no data (null)
            //  c)there is a physical string BUT no characters
            //there will be additional code to ensure ONLY a and b
            //  exists for the data
            //this requires a private data member to hold the data
            //   and a property to manage the data content
            get
            {
                //returns data via the property to the outside user
                //   of the property
                return _Manufacturer;
            }
            set
            {
                //the set take incoming data and places that data
                //   into the private data member
                //internal to the property, incoming data will be placed
                //   in a common variable called value
                //a property is associated with a single data member.
                //a property has no parameter list
                if (string.IsNullOrEmpty(value))
                {
                    _Manufacturer = null;
                }
                else
                {
                    _Manufacturer = value;
                }

                //alternate code
                //_Manufacturer = string.IsNullOrEmpty(value) ? null : value;
            }
        }

        //example of an Auto Implemented property
        // auto implemented properties can be used when there is NO NEED
        //     for additional processing against the incoming data
        // NO internal private data member is required for this property
        // the system will internally generate a data area for the data
        // access this the stored data (getting or setting) CAN ONLY be done
        //     via the property
        public decimal Width { get; set; }

        //one can still code an auto implement property as a
        //   fully implemented property
        //private decimal _Width;
        //public decimal Width
        //{
        //    get
        //    {
        //        return _Width;
        //    }
        //    set
        //    {
        //        _Width = value;
        //    }
        //}


        //lets fully implement Height with a criteria of being > 0
        public decimal Height
        {
            get
            {
                return _Height;
            }
            set
            {
                // the m indicates the value is a decimal
                if (value <= 0.0m)
                {
                    throw new Exception("Height can not be 0 or less than 0.");
                }
                else
                {
                    _Height = value;
                }
            }
        }

        //Why do we NOT need to fully implement a nullable numeric?
        //Numerics have a default of zero.
        //Numerics can only store a numeric (unless nullable)
        //Numerics can be null if declared as nullable
        //IF the numeric has additional criteria THEN you can code
        //   the property as a Fully Implemented property
        public int? NumberOfPanes { get; set; }

        //Constructors
        //a constructors is "a method" that guarantees that the newly
        //   created instance of this class will ALWAYS be created in
        //   a known state

        //constructors are optional
        //IF a class DOES NOT have a constructor then the system
        //   will generate the class instance using the datatype defaults
        //   for your private data members and auto implemented properties
        //this situation of no constructor(s) uses what is referred to as
        //   a "System" constructor

        //IF you code a constructor, you MUST code any and all constructors
        //   needed by your class

        //constructors CAN receive a list of parameters
        //two common constructors for classes are the Default and Greedy constructor

        //Default constructor
        //this version of the constructor takes NO parameters
        //this version of the constructor usually similates the System constructor
        //you CAN if you wish assign values to your class data members/properties
        //    that are NOT the system default for that datatype
        // NO RETURN DATATYPE!!!!
        //This "method" is call on your behave when an instance of the class
        //   is requested by the outside user
        //You CAN NOT call this "method" directly
        public Window()
        {
            //default constructor
            //optionally specify your own default values
            NumberOfPanes = 1;
            Height = 0.9m;  //preferred method of touching any data in the class 
        }

        //Greedy Constructor
        //takes in a value for each data member/property in the class
        //each data member/property is assigned the incoming parameter value
        public Window(decimal width, decimal height, int? numberofpanes, string manufacturer)
        {
            Width = width;
            Height = height;
            Manufacturer = manufacturer;
            NumberOfPanes = numberofpanes;
        }

        //Behavours (method)
        //optional

        //Area of a Window
        public decimal WindowArea()
        {
            return Width * Height;
        }
        //Perimeter of a Window
        public decimal WindowPerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
