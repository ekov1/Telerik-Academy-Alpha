using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_2.Entities
{
    public class Path
    {
        private List<Point3D> point;

        public List<Point3D> Point
        {
            get
            {
                return this.point;
            }
        }

        public Path()
        {
            point = new List<Point3D>();
        }
    }
}
