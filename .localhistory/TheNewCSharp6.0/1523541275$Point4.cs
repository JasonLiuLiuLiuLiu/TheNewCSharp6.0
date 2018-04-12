
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
        public JObject ToJsonNew() => new JObject() { ["x"] = X, ["y"] = Y };


        //before
        public static Point FromJson(JObject json)
        {
            if (json != null &&
                json["x"] != null &&
                json["x"].Type == JTokenType.Integer &&
                json["y"] != null &&
                json["y"].Type == JTokenType.Integer)
            {
                return new Point((int)json["x"],(int)json["y"]);
            }
            return null;

        }
        //After
        public static Point FromJson1(JObject json)
        {
            if (json != null &&
                json["x"]?.Type == JTokenType.Integer &&
                json["y"]?.Type == JTokenType.Integer)
            {
                return new Point((int)json["x"], (int)json["y"]);
            }
            return null;

        }

    }
}
