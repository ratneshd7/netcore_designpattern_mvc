using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeDessignPattern
{
    class ShapeMaker
    {
        Circle circle;
        Rectangle rect;

        public ShapeMaker()
        {
            circle = new Circle();
            rect = new Rectangle();

        }
        public void DrawCircle()
        {
            circle.Draw();
        }
        public void DrawRectangle()
        {
            rect.Draw();
        }
    }
}
