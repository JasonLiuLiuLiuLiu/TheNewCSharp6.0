
using static System.Math;

namespace TheNewCSharp6._0
{
    //字符串插值
    public class Point3
    {
        public int X { get; }
        public int Y { get; }

        public Point3(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double Dist => Sqrt(X * X + Y * Y);

        public override string ToString() => $"({X},{Y})";
    }
}
