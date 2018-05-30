using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class ShapeDescriptor
    {
        public string ShapeType { get; set; }

        public Point[] Points { get; }
       
        public ShapeDescriptor(Point point1, Point point2, Point point3)
        {
            Points = new Point[] { point1, point2, point3 };
        }
        public ShapeDescriptor(Point point1, Point point2, Point point3, Point point4)
        {
            Points = new Point[] { point1, point2, point3, point4 };
        }
        public ShapeDescriptor(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            Points = new Point[] { point1, point2, point3, point4, point5 };
        }
    }
}
