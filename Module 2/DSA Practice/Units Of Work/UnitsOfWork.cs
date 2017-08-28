using System;
using System.Collections.Generic;
using System.Globalization;
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

        public override string ToString()
        {
            return string.Format("{0}[{1}]({2})", name, type, attack);
        }
    }

    public class Units
    {
        private Dictionary<string, SortedSet<Unit>> sortedUnitsByType = new Dictionary<string, SortedSet<Unit>>();
        private Dictionary<string, Unit> units = new Dictionary<string, Unit>();
        private Dictionary<int, SortedSet<Unit>> sortedUnitsByPower = new Dictionary<int, SortedSet<Unit>>();

        public void AddUnit(string unitName, string unitType, int unitAttack)
        {
            var unit = new Unit(unitName, unitType, unitAttack);

            if (sortedUnitsByType.ContainsKey(unitName))
            {
                throw new ArgumentException("FAIL: {0} already exists!", unitName);
            }
            Console.WriteLine("SUCCESS: {0} added!", unitName);
            units.Add(unitName, unit);

            if (!sortedUnitsByType.ContainsKey(unitType))
            {
                sortedUnitsByType.Add(unitType, new SortedSet<Unit>());
            }
            sortedUnitsByType[unitType].Add(unit);

            if (!sortedUnitsByPower.ContainsKey(unitAttack))
            {
                sortedUnitsByPower.Add(unitAttack, new SortedSet<Unit>());
            }
            sortedUnitsByPower[unitAttack].Add(unit);
        }

        public void FindUnitPower(int unitAttack)
        {
            
        }

        public void FindUnitType(string unitType)
        {
            if (sortedUnitsByType.ContainsKey(unitType))
            {
                Console.WriteLine("RESULT: {0}", string.Join(", ", sortedUnitsByType[unitType]));
            }
            else
            {
                Console.WriteLine("RESULT: ");
            }
        }
    }
}
