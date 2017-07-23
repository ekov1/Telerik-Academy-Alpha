using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_classes
{
    public class Teacher : Person
    {
        private List<Discipline> disciplines;

        public Teacher()
        {
            this.disciplines = new List<Discipline>();
        }
    }
}