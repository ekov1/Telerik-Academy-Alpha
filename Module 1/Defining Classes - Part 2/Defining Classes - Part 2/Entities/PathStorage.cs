using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes___Part_2.Entities
{
    public class PathStorage
    {
        public void Save(List<Point3D> points)
        { 
            using (StreamWriter writer = new StreamWriter("..//..//sample.txt"))
            {
                foreach (var point in points)
                {
                    writer.WriteLine($"({point.X}, {point.Y}, {point.Z})");
                }
            }
        }

        public string Load()
        {
            var result = new StringBuilder();
            using (StreamReader reader = new StreamReader("..//..//sample.txt"))
            {
                result.AppendLine(reader.ReadToEnd());
            }

            return result.ToString();
        }
    }
}
