using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(100, 100);
            Point point2 = new Point(100, 100);
            Point point3 = new Point(100, 100);
            ShapeDescriptor shapeDescriptor = new ShapeDescriptor(point1, point2, point3);
        }
    }
}
