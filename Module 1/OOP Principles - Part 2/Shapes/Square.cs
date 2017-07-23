using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Shape
    {
        public Square(int height, int width) : base(height, width)
        {
            if(this.Height != this.Width)
            {
                throw new ArgumentException("Invalid width or height!");
            }
        }

        public override int CalculateSurface()
        {
            return base.Height * base.Width;
        }
    }
}
