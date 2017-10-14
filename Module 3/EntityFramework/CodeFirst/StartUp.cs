using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.Models;

namespace CodeFirst
{
    public class StartUp
    {
        public static void Main()
        {
            var db = new StudentSystemContext();
            db.Database.CreateIfNotExists();
        }
    }
}
