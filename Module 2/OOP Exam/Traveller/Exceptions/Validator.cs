using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveller.Exceptions
{
    public static class Validator
    {
        public static void ValidateCapacity(string vehicleType, int capacity, int minRange, int maxRange)
        {
            if (capacity < minRange || capacity > maxRange)
            {
                throw new ArgumentOutOfRangeException($"A {vehicleType} cannot have less than {minRange} passengers or more than {maxRange} passengers.");
            }
        }

        public static void ValidateVehicaleCapacity(int capacity)
        {
            if (capacity < 1 || capacity > 800)
            {
                throw new ArgumentOutOfRangeException("A vehicle with less than 1 passengers or more than 800 passengers cannot exist!");
            }
        }

        public static void ValidateCarts(int cartsNumber)
        {
            if (cartsNumber < 1 || cartsNumber > 15)
            {
                throw new ArgumentOutOfRangeException("A train cannot have less than 1 cart or more than 15 carts.");
            }
        }

        public static void DistanceValidator(int distance)
        {
            if (distance < 5 || distance > 5000)
            {
                throw new ArgumentOutOfRangeException("The Distance cannot be less than 5 or more than 5000 kilometers.");
            }
        }

        public static void LengthValidator(string lengthType, string stringToValidate, int minRange, int maxRange)
        {
            if (stringToValidate.Length < minRange || stringToValidate.Length > maxRange)
            {
                throw new ArgumentOutOfRangeException($"The {lengthType}'s length cannot be less than {minRange} or more than {maxRange} symbols long.");
            }
        }

        public static void PricePerKilometerValidator(decimal pricePerKilometer)
        {
            if (pricePerKilometer < 0.10m || pricePerKilometer > 2.50m)
            {
                throw new ArgumentOutOfRangeException("A vehicle with a price per kilometer lower than $0.10 or higher than $2.50 cannot exist!");
            }
        }
    }
}
