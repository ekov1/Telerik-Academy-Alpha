using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

public class Engine
{
    private GSMTest test = new GSMTest();

    public void AddInput()
    {
        while (true)
        {
            Console.WriteLine(@"Enter general phone specs [model manufacturer price owner] seperated by space or ""end"" to stop:");
            var input = Console.ReadLine();

            if (input.ToLower() == "end")
            {
                break;
            }
            var inputsArgs = input.Split(' ');

            try
            {
                var model = string.Empty;
                var manufacturer = string.Empty;
                decimal? price = null;
                var owner = string.Empty;

                GSM phone = new GSM(model, manufacturer, price, owner);

                if (inputsArgs.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Model and manufacturer are required!");
                }
                else if (inputsArgs.Length == 2)
                {
                    model = inputsArgs[0];
                    manufacturer = inputsArgs[1];
                    phone = new GSM(model, manufacturer);
                }
                else if (inputsArgs.Length == 3)
                {
                    model = inputsArgs[0];
                    manufacturer = inputsArgs[1];
                    price = decimal.Parse(inputsArgs[2]);
                    phone = new GSM(model, manufacturer, price);
                }
                else if (inputsArgs.Length == 4)
                {
                    model = inputsArgs[0];
                    manufacturer = inputsArgs[1];
                    price = decimal.Parse(inputsArgs[2]);
                    owner = inputsArgs[3];
                    phone = new GSM(model, manufacturer, price, owner);
                }



                Console.WriteLine("Enter battery type[Li-Ion, NiMH, NiCd, Unknown]");
                var batteryTypeInput = Console.ReadLine();
                BatteryCharacteristics batteryCharacteristics = new BatteryCharacteristics(BatteryCharacteristics.BatteryType.Unknown);

                if (batteryTypeInput == "Li-Ion")
                {
                    batteryCharacteristics.CurrentBatteryType = BatteryCharacteristics.BatteryType.LiIon;
                }
                else if (batteryTypeInput == "NiMH")
                {
                    batteryCharacteristics.CurrentBatteryType = BatteryCharacteristics.BatteryType.NiMh;
                }
                else if (batteryTypeInput == "NiCd")
                {
                    batteryCharacteristics.CurrentBatteryType = BatteryCharacteristics.BatteryType.NiCd;
                }

                Console.WriteLine("Enter battery specs [model hoursIdle hoursTalk] seperated space:");
                var batteryModel = string.Empty;
                int? hoursIdle = null;
                int? hoursTalk = null;

                var batterySpecsInput = Console.ReadLine().Split(' ');

                if (batterySpecsInput.Length >= 1)
                {
                    batteryModel = batterySpecsInput[0];
                    batteryCharacteristics.Model = batteryModel;
                }

                if (batterySpecsInput.Length >= 2)
                {
                    hoursIdle = int.Parse(batterySpecsInput[1]);
                    batteryCharacteristics.HoursIdle = hoursIdle;
                }

                if (batterySpecsInput.Length >= 3)
                {
                    hoursTalk = int.Parse(batterySpecsInput[2]);
                    batteryCharacteristics.HoursTalk = hoursTalk;
                }

                Console.WriteLine("Enter display Characteristics [size numberOfColors] seperated by space:");

                var displayCharacteristics = new DisplayCharacteristics();
                var displayCharacteristicsInput = Console.ReadLine().Split();

                if (displayCharacteristicsInput.Length >= 1)
                {
                    displayCharacteristics.Size = decimal.Parse(displayCharacteristicsInput[0]);
                }

                if (displayCharacteristicsInput.Length >= 2)
                {
                    displayCharacteristics.NumberOfColors = int.Parse(displayCharacteristicsInput[1]);
                }

                phone.BatteryCharacteristics = batteryCharacteristics;
                phone.DisplayCharacteristics = displayCharacteristics;
                test.AddPhone(phone);
            }
            catch (Exception)
            {
                throw new IndexOutOfRangeException("Invalid Input!");
            }
        } 
    }

    public void PrintPhones()
    {
        foreach (var phone in test.Phones)
        {
            Console.WriteLine(phone.ToString());
        }
    }
}