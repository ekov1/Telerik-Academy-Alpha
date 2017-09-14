using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_and_courses.Interfaces
{
    public interface IStudent
    {
        string Name { get; }
        int Id { get; }

        string ToString();
    }
}
