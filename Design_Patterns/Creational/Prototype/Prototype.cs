using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Prototype
{
    public class Rectangle
    {
        public Rectangle Clone()
        {
            return (Rectangle)MemberwiseClone();
        }

        public int Length { get; set; }
        public int Breadth { get; set; }

        public Rectangle()
        {
            Length = 1;
            Breadth = 1;
        }

        public void setDimensions(int l, int b)
        {
            Length = l;
            Breadth = b;
        }

        public decimal calculateArea()
        {
            return Length * Breadth;
        }
    }
}
