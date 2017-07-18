using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

public class DisplayCharacteristics
{
    private decimal? size;
    private int? numberOfColors;

    public decimal? Size
    {
        get { return this.size; }
        set { this.size = value; }
    }

    public int? NumberOfColors
    {
        get { return this.numberOfColors; }
        set { this.numberOfColors = value; }
    }

    public DisplayCharacteristics()
    {
        this.size = null;
        this.numberOfColors = null;
    }

    public DisplayCharacteristics(decimal size)
    {
        this.size = size;
    }

    public DisplayCharacteristics(decimal size, int numberOfColors) : this(size)
    {
        this.numberOfColors = numberOfColors;
    }
}