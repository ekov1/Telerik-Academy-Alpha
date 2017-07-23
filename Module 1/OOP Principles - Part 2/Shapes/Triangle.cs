using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(int height, int width) : base(height, width)
        {
        }

        public override int CalculateSurface()
        {
            return (base.Height * base.Width) / 2;
        }
    }
}
