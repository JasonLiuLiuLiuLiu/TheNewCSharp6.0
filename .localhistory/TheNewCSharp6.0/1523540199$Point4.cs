
using Newtonsoft.Json.Linq;
using static System.Math;

namespace TheNewCSharp6._0
{
    //表达式体属性
    public class Point4
    {
        public int X { get; }
        public int Y { get; }

        public Point4(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double Dist => Sqrt(X * X + Y * Y);

        public override string ToString() => $"({X},{Y})";

        //before
        public JObject ToJsonOld()
        {
            var result = new JObject();
            result["x"] = X;
            result["y"] = Y;
            return result;
        }
        //After
        public JObject ToJsonNew()=> new JObject() { ["x"] = X, ["y"] = Y };




    }
}
