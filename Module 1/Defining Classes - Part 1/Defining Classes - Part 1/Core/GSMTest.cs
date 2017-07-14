using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class GSMTest
{
    private List<GSM> phones;

    public List<GSM> Phones
    {
        get { return this.phones; }
    }

    public GSMTest()
    {
        phones = new List<GSM>();
    }

    public void AddPhone(GSM phone)
    {
        phones.Add(phone);
    }

}

