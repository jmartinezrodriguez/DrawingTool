using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public interface IDraw
    {
        Canva DrawCanva(string type, int width, int height, int x, int y);
        Line DrawLine(string type, int width, int height, int x1, int y1, int x2, int y2);
        Rectangle DrawRectangle(string type, int width, int height, int x1, int y1, int x2, int y2);
    }
}
    