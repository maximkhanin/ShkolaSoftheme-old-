﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Point
    {
        private int _x;
        private int _y;
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public Point(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

    }
}
