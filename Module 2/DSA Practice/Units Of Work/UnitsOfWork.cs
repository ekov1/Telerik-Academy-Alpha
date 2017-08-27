using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Units_Of_Work
{
    public class UnitsOfWork
    {
        public static void Main(string[] args)
        {

        }
    }

    public class Unit : IComparable<Unit>
    {
        private string name;
        private string type;
        private int attack;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public int Attack
        {
            get { return this.attack; }
            set { this.attack = value; }
        }

        public Unit(string name, string type, int attack)
        {
            this.name = name;
            this.type = type;
            this.attack = attack;
        }

        public int CompareTo(Unit other)
        {
            var result = this.Attack.CompareTo(other.Attack) * -1;

            if (result == 0)
            {
                result = this.Name.CompareTo(other.Name);
            }

            return result;
        }
    }

    public class Units
    {
        private new Dictionary<string, SortedSet<Unit>> sortedUnits = new Dictionary<string, SortedSet<Unit>>();
        private BigList<Unit> unitsList = new BigList<Unit>();

        public void AddUnit(string unitName, string unitType, int unitAttack)
        {
            var unit = new Unit(unitName, unitType, unitAttack);


        }
    }
}
