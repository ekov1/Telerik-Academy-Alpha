using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class Mark
    {
        public int MarkId { get; set; }

        public string Description { get; set; }

        public int Score { get; set; }

        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
