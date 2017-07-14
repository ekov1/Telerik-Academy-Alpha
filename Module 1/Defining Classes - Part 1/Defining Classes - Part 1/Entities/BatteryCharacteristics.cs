using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BatteryCharacteristics
{
    public enum BatteryType
    {
        LiIon,
        NiMh,
        NiCd
    }

    private string model;
    private int? hoursIdle;
    private int? hoursTalk;

    public string Model
    {
        get { return this.model; }
    }

    public int? HoursIdle
    {
        get { return this.hoursIdle; }
    }

    public int? HoursTalk
    {
        get { return this.hoursTalk; }
    }

    public BatteryCharacteristics(string model)
    {
        this.model = model;
    }

    public BatteryCharacteristics(string model, int hoursIdle) : this(model)
    {
        this.hoursIdle = hoursIdle;
    }

    public BatteryCharacteristics(string model, int hoursIdle, int hoursTalk) : this(model, hoursIdle)
    {
        this.hoursTalk = hoursTalk;
    }
}

