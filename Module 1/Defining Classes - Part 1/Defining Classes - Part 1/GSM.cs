using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

public class GSM
{
    private string model;
    private string manufacturer;
    private decimal price;
    private string owner;
    private BatteryCharacteristics batteryCharacteristics;
    private DisplayCharacteristics displayCharacteristics;

    public string Model
    {
        get { return this.model; }
    }

    public string Manufacturer
    {
        get { return this.manufacturer; }
    }

    public decimal Price
    {
        get { return this.price; }
    }

    public string Owner
    {
        get { return this.owner; }
    }

    public BatteryCharacteristics BatteryCharacteristics
    {
        get { return this.batteryCharacteristics; }
    }

    public DisplayCharacteristics DisplayCharacteristics
    {
        get { return this.displayCharacteristics; }
    }

    public GSM(string model, string manufacturer)
    {
        this.model = model;
        this.manufacturer = manufacturer;
    }

    public GSM(string model, string manufacturer, decimal price)
        : this(model, manufacturer)
    {
        this.price = price;
    }

    public GSM(string model, string manufacturer, decimal price, string owner)
        : this(model, manufacturer, price)
    {
        this.owner = owner;
    }

    public override string ToString()
    {
        StringBuilder allCharacteristics = new StringBuilder();
        allCharacteristics.AppendLine("--GSM--");
        allCharacteristics.AppendLine("Model:");
        allCharacteristics.AppendLine($"{model}");
        allCharacteristics.AppendLine("Manufacturer:");
        allCharacteristics.AppendLine($"{manufacturer}");
        allCharacteristics.AppendLine("Price:");
        allCharacteristics.AppendLine($"{price}");
        allCharacteristics.AppendLine("-Battery Characteristics-");
        allCharacteristics.AppendLine("Battery Model:");
        allCharacteristics.AppendLine($"{batteryCharacteristics.Model}");
        allCharacteristics.AppendLine("Hours Idle:");
        allCharacteristics.AppendLine($"{batteryCharacteristics.HoursIdle}");
        allCharacteristics.AppendLine("Hours Talk:");
        allCharacteristics.AppendLine($"{batteryCharacteristics.HoursTalk}");
        allCharacteristics.AppendLine("-Display-");
        allCharacteristics.AppendLine("Display Size:");
        allCharacteristics.AppendLine($"{displayCharacteristics.Size}");
        allCharacteristics.AppendLine("Numbers of Colors:");
        allCharacteristics.AppendLine($"{displayCharacteristics.NumberOfColors}");
        allCharacteristics.AppendLine("-------");

        return allCharacteristics.ToString();
    }
}

