using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameOfLifeNET
{
    public class PointComparer : IEqualityComparer<Point>
    {
        public bool Equals(Point p1, Point p2) => p1.X == p2.X && p1.Y == p2.Y;

        public int GetHashCode(Point point) => point.X.GetHashCode() * 17 + point.Y.GetHashCode();
    }
}
