using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Defining_Classes___Part_2.Entities;

namespace Defining_Classes___Part_2
{
    public class StartUp
    {
        public static void Main()
        {
            var path = new Path();

            path.Point.Add(new Point3D(1, 2, 3));
            path.Point.Add(new Point3D(3, 2, 1));

            var pathStorage = new PathStorage();

            pathStorage.Save(path.Point);
            Console.WriteLine(pathStorage.Load());
        }
    }
}
