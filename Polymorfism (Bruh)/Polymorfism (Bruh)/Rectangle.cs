using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism__Bruh_
{
    class Rectangle : Shape
    {
        public Rectangle(int w, int h) : base(w, h)
        {

        }
        public override double Area()
        {
            double area = width * height;

            return area;
        }
        public override double Circumference()
        {
            double recCircumference = width * 2 + height * 2;

            return recCircumference;
        }
    }

}
