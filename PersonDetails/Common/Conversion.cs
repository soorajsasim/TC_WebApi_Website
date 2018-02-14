using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersonDetails.Common
{
    public static class Conversion
    {

        /// <summary>
        /// Method for finding out whole value - Conerts double to Int
        /// </summary>
        /// <param name="value"></param>
        /// <returns>int : whole number used as Dollar value</returns>
        public static int DoubleToDollar(Double value)
        {
            return (int)value;
        }

        /// <summary>
        ///   Method for finding out decimal values 
        ///  Finds the difference between whole number and decimal and mutiply by 100
        /// </summary>
        /// <param name="value"></param>
        /// <returns>int : whole number used as Cents value </returns>
        public static int DoubleToCents(Double value)
        {
            int dollars = (int)value;
            int cents = (int)((value - dollars) * 100);
            return cents;
        }

        /// <summary>
        ///  Method for converting a whole number to words 
        ///  This methods is consumed by both whole number to words and decimal to words calculation.
        ///  
        ///  Billion , Trillion are not considered now
        /// </summary>
        /// <param name="number"></param>
        /// <returns>string : Values that are converted to words</returns>

        public static string NumberToWords(int number)
        {

            string words = "";

            if (number == 0)
            {
                words = "zero";
                return words;
            }
            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }


            return words;
        }
    }
}