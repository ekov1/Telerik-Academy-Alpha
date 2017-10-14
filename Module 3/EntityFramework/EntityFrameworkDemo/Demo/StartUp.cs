using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class StartUp
    {
        public static void Main()
        {
            var db = new TelerikAcademyEntities();
            db.Towns.Add(
                new Town
                {
                    Name = "Melnik"
                });

            db.SaveChanges();
        }
    }
}