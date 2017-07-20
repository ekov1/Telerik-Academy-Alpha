using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Defining_Classes___Part_2.Entities;

namespace Defining_Classes___Part_2.Core
{
    public static class DistanceCalculator
    {
        public static int CalculateDistance(Point3D a, Point3D b)
        {
            return Math.Abs(a.X - b.X) + Math.Abs(a.Y - b.Y) + Math.Abs(a.Z - b.Z);
        }
    }
}
