using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr
{
    public struct Coord
    {
        private int x;
        private int y;

        public int X
        {
            get { return x; }
            
        }
        public int Y
        { get { return y; }}

        public Coord(int x , int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Coord operator +(Coord a, Coord b)
        {
            return new Coord(a.X + b.X, a.Y + b.Y);
        }
        public static Coord operator -(Coord a, Coord b)
        {
            return new Coord(a.X - b.X, a.Y - b.Y);

        }
        public static Coord operator *(Coord a, int scalar)
        {
            return new Coord(a.X * scalar, a.Y * scalar);
        }
        public static bool operator ==(Coord a, Coord b)
        {
            return  a.X == b.X && a.Y == b.Y;
        }
        public static bool operator !=(Coord a, Coord b)
        {
            return !(a == b);

        }

        public override bool Equals(object obj)
        {
            if (obj is Coord other)
            {
                return this == other;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(this.x, this.y);
        }

        public override string ToString()
        {
            return "(" + x + ", " + y + ")";
        }

    }
}
