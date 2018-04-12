using System;

namespace TheNewCSharp6._0
{
    //Getter专属自动新特性
   public class Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double Dist()
        {
            return Math.Sqrt(X * X + Y * Y);
        }

       
    }
}
