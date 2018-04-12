
using static System.Math;

namespace TheNewCSharp6._0
{
    //使用静态成员
    public class Point1
    {
        public int X { get; }
        public int Y { get; }

        public Point1(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double Dist => Sqrt(X * X + Y * Y);
    }
}
