using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorfism__Bruh_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange en höjd");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Ange en bredd");
            int width = int.Parse(Console.ReadLine());

            Rectangle rectangle = new Rectangle(height, width);
            Triangle triangle = new Triangle(height, width);

            Console.WriteLine("Rektangelns area är: " + rectangle.recArea());
            Console.WriteLine("Rektangelns omkrets är: " + rectangle.recCircumference());
            Console.WriteLine("");

            Console.WriteLine("Triangelns area är: " + triangle.triArea());
            Console.WriteLine("Triangelns omkrets är: " + triangle.triCircumference());
            Console.ReadLine();
        }
    }
}
