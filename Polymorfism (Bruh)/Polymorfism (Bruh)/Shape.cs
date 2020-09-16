using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism__Bruh_
{
    class Shape
    {
        protected int width
        {
            get;
            set;
        }
        protected int height
        {
            get;
            set;
        }

        public Shape(int w, int h)
        {
            width = w;
            height = h;
        }
        public virtual double Area()
        {
            return 0;
        }
        public virtual double Circumference()
        {
            return 0;
        }
    }
}
