using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

public class DisplayCharacteristics
{
    private decimal size;
    private int numberOfColors;

    public decimal Size
    {
        get { return this.size; }
    }

    public int NumberOfColors
    {
        get { return this.numberOfColors; }
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

