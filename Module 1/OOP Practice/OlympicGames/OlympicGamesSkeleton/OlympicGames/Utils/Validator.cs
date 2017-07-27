using System;

namespace OlympicGames.Utils
{
    public static class Validator
    {
        public static void ValidateIfNull(this object value, string msg = null)
        {
            if (msg == null)
            {
                msg = "Value cannot be null!";
            }
        
            if (value == null)
            {
                throw new ArgumentNullException(msg);
            }
        }


        public static void ValidateIfNullFirstName(this object value, string msg = null)
        {
            if (msg == null)
            {
                msg = "First name cannot be null!";
            }

            if (value == null)
            {
                throw new ArgumentNullException(msg);
            }
        }

        public static void ValidateIfNullLastName(this object value, string msg = null)
        {
            if (msg == null)
            {
                msg = "Last name cannot be null!";
            }

            if (value == null)
            {
                throw new ArgumentNullException(msg);
            }
        }

        public static void ValidateIfNullCountry(this object value, string msg = null)
        {
            if (msg == null)
            {
                msg = "Country cannot be null!";
            }

            if (value == null)
            {
                throw new ArgumentNullException(msg);
            }
        }

        //     public static void ValidateMinAndMaxNumber(this int value, int min, int max = int.MaxValue - 1, string msg = null)
        //     {
        //         if (msg == null)
        //         {
        //             msg = string.Format("Value must be between {0} and {1}!", min, max);
        //         }
        //
        //         if (value < min || value > max)
        //         {
        //             throw new ArgumentException(msg);
        //         }
        //     }

        public static void ValidateWins(this int value, string msg = null)
        {
            if (msg == null)
            {
                msg = string.Format("Wins must be between {0} and {1}!", 0, 100);
            }

            if (value < 0 || value > 100)
            {
                throw new ArgumentException(msg);
            }
        }

        public static void ValidateLosses(this int value, string msg = null)
        {
            if (msg == null)
            {
                msg = string.Format("Losses must be between {0} and {1}!", 0, 100);
            }

            if (value < 0 || value > 100)
            {
                throw new ArgumentException(msg);
            }
        }

     //
     //  public static void ValidateMinAndMaxLength(this string value, int min, int max = int.MaxValue - 1, string msg = null)
     //  {
     //      if (msg == null)
     //      {
     //          msg = string.Format("Value must be between {0} and {1} characters long!", min, max);
     //      }
     //
     //      if (value.Length < min || value.Length > max)
     //      {
     //          throw new ArgumentException(msg);
     //      }
     //  }

        public static void ValidateFirstName(this string value, string msg = null)
        {
            if (msg == null)
            {
                msg = string.Format("First name must be between {0} and {1} characters long!", 2, 20);
            }

            if (value.Length < 2 || value.Length > 20)
            {
                throw new ArgumentException(msg);
            }
        }

        public static void ValidatLastName(this string value, string msg = null)
        {
            if (msg == null)
            {
                msg = string.Format("Last name must be between {0} and {1} characters long!", 2, 20);
            }

            if (value.Length < 2 || value.Length > 20)
            {
                throw new ArgumentException(msg);
            }
        }

        public static void ValidatCountry(this string value, string msg = null)
        {
            if (msg == null)
            {
                msg = string.Format("Country must be between {0} and {1} characters long!", 3, 25);
            }

            if (value.Length < 3 || value.Length > 25)
            {
                throw new ArgumentException(msg);
            }
        }
    }
}
