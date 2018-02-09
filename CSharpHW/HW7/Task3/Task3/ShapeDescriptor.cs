using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class ShapeDescriptor
    {
        private string _shapeType;
        private Point[] _Points;
        public string ShapeType
        {
            get { return _shapeType; }
            set { _shapeType = value; }
        }
        public Point[] Points
        {
            get { return _Points; }
            set { _Points = value; }
        }

        public ShapeDescriptor()
        {

        }
        public ShapeDescriptor(Point point1, Point point2, Point point3)
        {
            this._Points = new Point[] { point1, point2, point3 };
        }
        public ShapeDescriptor(Point point1, Point point2, Point point3, Point point4)
        {
            this._Points = new Point[] { point1, point2, point3, point4 };
        }
        public ShapeDescriptor(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            this._Points = new Point[] { point1, point2, point3, point4, point5 };
        }
    }
}
