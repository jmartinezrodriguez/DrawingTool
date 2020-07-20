using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Rectangle: IDraw
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }

        public Canva DrawCanva(string type, int width, int height, int x, int y)
        {
            return new Canva { Width = width, Height = height };
        }

        public Line DrawLine(string type, int width, int height, int x1, int y1, int x2, int y2)
        {
            return new Line { Width = width, Height = height, X1 = x1, Y1 = y1, X2 = x2, Y2 = y2 };
        }

        public Rectangle DrawRectangle(string type, int width, int height, int x1, int y1, int x2, int y2)
        {
            return new Rectangle { Width = width, Height = height, X1 = x1, Y1 = y1, X2 = x2, Y2 = y2 };
        }
    }
}
