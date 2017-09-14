using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_and_courses.Interfaces
{
    public interface ICourse
    {
        void Add(IStudent student);
        void Remove(IStudent student);

        string ToString();
    }
}
