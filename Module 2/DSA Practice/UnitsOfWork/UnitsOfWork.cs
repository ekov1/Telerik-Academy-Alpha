using System;
using System.Collections;
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
            var units = new Units();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                var inputTokens = input.Split().ToArray();
                var command = inputTokens[0];

                switch (command)
                {
                    case "add":
                        units.AddUnit(inputTokens[1], inputTokens[2], int.Parse(inputTokens[3]));
                        break;

                    case "find":
                        units.FindUnitType(inputTokens[1]);
                        break;

                    case "remove":
                        units.RemoveUnit(inputTokens[1]);
                        break;

                    case "power":
                        units.FindUnitPower(int.Parse(inputTokens[1]));
                        break;
                }
            }
        }
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
    private SortedSet<Unit> sortedUnitsByAttack = new SortedSet<Unit>();

    public void AddUnit(string unitName, string unitType, int unitAttack)
    {
        var unit = new Unit(unitName, unitType, unitAttack);

        if (units.ContainsKey(unitName))
        {
            Console.WriteLine("FAIL: {0} already exists!", unitName);
        }
        else
        {
            Console.WriteLine("SUCCESS: {0} added!", unitName);
            units.Add(unitName, unit);
        }

        if (!sortedUnitsByType.ContainsKey(unitType))
        {
            sortedUnitsByType.Add(unitType, new SortedSet<Unit>());
        }
        sortedUnitsByType[unitType].Add(unit);

        sortedUnitsByAttack.Add(unit);
    }

    public void FindUnitPower(int number)
    {
        Console.WriteLine("RESULT: {0}", string.Join(", ", sortedUnitsByAttack.Where(x => units.ContainsKey(x.Name)).Take(number)));
    }

    public void RemoveUnit(string unitName)
    {
        if (units.ContainsKey(unitName))
        {
            units.Remove(unitName);
            Console.WriteLine("SUCCESS: {0} removed!", unitName);
        }
        else
        {
            Console.WriteLine("FAIL: {0} could not be found!", unitName);
        }
    }

    public void FindUnitType(string unitType)
    {
        if (sortedUnitsByType.ContainsKey(unitType))
        {
            Console.WriteLine("RESULT: {0}", string.Join(", ", sortedUnitsByType[unitType].Where(x => units.ContainsKey(x.Name)).Take(10)));
        }
        else
        {
            Console.WriteLine("RESULT: ");
        }
    }
}

