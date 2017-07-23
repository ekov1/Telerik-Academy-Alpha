using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var triangle = new Triangle(6, 7);
            Console.WriteLine(triangle.CalculateSurface());
            var rectangle = new Rectangle(7, 6);
            Console.WriteLine(rectangle.CalculateSurface());
            var square = new Square(6, 6);
            Console.WriteLine(square.CalculateSurface());
            var squareTwo = new Square(6, 7);
            Console.WriteLine(squareTwo.CalculateSurface());
        }
    }
}
