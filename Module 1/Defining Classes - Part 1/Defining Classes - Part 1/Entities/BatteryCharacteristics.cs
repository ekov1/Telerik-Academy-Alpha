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
        NiCd,
        Unknown
    }

    private string model;
    private int? hoursIdle;
    private int? hoursTalk;
    private BatteryType currentBatteryType;

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public int? HoursIdle
    {
        get { return this.hoursIdle; }
        set { this.hoursIdle = value; }
    }

    public int? HoursTalk
    {
        get { return this.hoursTalk; }
        set { this.hoursTalk = value; }
    }

    public BatteryType CurrentBatteryType
    {
        get { return this.currentBatteryType; }
        set { this.currentBatteryType = value; }
    }

    public BatteryCharacteristics(BatteryType CurrentBatteryType)
    {
        this.currentBatteryType = CurrentBatteryType;
    }
}

