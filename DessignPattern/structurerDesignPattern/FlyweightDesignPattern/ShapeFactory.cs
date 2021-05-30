using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightDesignPattern
{
    public class ShapeFactory
    {
        private static Dictionary<string, IShape> shapeMap = new Dictionary<string, IShape>();
        public static IShape GetShape(string shapeType)
        {
            IShape shape = null;
            if (shapeType.Equals("circle", StringComparison.InvariantCultureIgnoreCase))
            {
                if (shapeMap.TryGetValue("circle", out shape))
                {
                }
                else
                {
                    shape = new Circle();
                    shapeMap.Add("circle", shape);
                    Console.WriteLine(" Creating circle object with out any color in shapefactory \n");
                }
            }
            return shape;
        }
    }
}
