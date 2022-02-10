using System;
using System.Collections.Generic;
using System.Text;

namespace NUnitRectangle
{
    public class Rectangle
    {
        public int length;
        public int width;

        public Rectangle()
        {
            this.width = 1;
            this.length = 1;
        }

        public Rectangle(int length1, int width1)
        {
            this.length = length1;
            this.width = width1;
        }

        public int GetLength()
        {
            return length;
        }

        public int SetLength(int length)
        {
            this.length = length;
            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int width)
        {
            this.width = width;
            return width;
        }

        public int GetPerimeter()
        {
            return 2 * (length + width);
        }

        public int GetArea()
        {
            return length * width;
        }
    }
}
