using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_and_workers
{
    public class Worker : Human
    {
        private int weekSalary;
        private int weekHoursPerDay;

        public int WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                this.weekSalary = value;
            }
        }

        public int WeekHoursPerDay
        {
            get
            {
                return this.weekHoursPerDay;
            }
            set
            {
                this.weekHoursPerDay = value;
            }
        }


        public int MoneyPerHour()
        {
            return (this.weekSalary / 7) / this.weekHoursPerDay;
        }

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
        {
            base.FirstName = firstName;
            base.LastName = lastName;
            this.weekSalary = weekSalary;
            this.weekHoursPerDay = workHoursPerDay;
        }
    }
}
