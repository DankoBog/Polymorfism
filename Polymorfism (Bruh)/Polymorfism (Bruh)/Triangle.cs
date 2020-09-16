using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism__Bruh_
{
    class Triangle : Shape
    {
        public Triangle(int w, int h) : base(w, h)
        {

        }
        public override double Area()
        {
            double triArea = (width * height) / 2;

            return triArea;
        }
        public override double Circumference()
        {
            double triCircumference = height + width + (Math.Sqrt(width * width + height * height));

            return triCircumference;
        }
    }
}
