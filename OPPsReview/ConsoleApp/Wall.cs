using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleData
{
    public class Wall
    {
        private decimal _Height;
        private decimal _Width;

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

        public decimal Width
        {
            get
            {
                return _Width;
            }
            set
            {
                if (value <= 0.0m)
                {
                    throw new Exception("Width can not be 0 or less than 0.");
                }
                else
                {
                    _Width = value;
                }
            }
        }

        public Wall()
        {
            Width = 4.25m;
            Height = 2.5m;
        }

        public Wall(decimal width, decimal height)
        {
            Width = width;
            Height = height;
        }

        public decimal WallArea()
        {
            return Width * Height;
        }
    }
}
