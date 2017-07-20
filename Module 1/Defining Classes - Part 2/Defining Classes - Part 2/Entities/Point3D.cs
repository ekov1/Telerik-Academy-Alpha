using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_2.Entities
{
    public struct Point3D
    {
        private int x;
        private int y;
        private int z;

        public int X
        {
           get { return this.x; }
        }

        public int Y
        {
            get { return this.y; }
        }

        public int Z
        {
            get { return this.z; }
        }
        

        private readonly static Point3D O = new Point3D(0, 0, 0);

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
