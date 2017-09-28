using System;
using System.Collections.Generic;
using System.Text;

namespace NumberToWordConverter.Services
{
    /***** Returns Currency representation in Words for any given value with 2 decimal places *****/
    public class MoneyToWords
    {
        public static string Convert(double value)
        {
            decimal money = Math.Round((decimal)value, 2);
            string dollarPH = "";
            int number = (int)money;
            int decimalValue = 0;
            string dollar = string.Empty;
            string cents = string.Empty;
            dollar = NumberToWords(number).Trim();
            dollarPH = (number < 2 ? "DOLLAR" : "DOLLARS");
            if (money.ToString().Contains("."))
            {
                decimalValue = int.Parse((money.ToString() + "0").Split('.')[1].Substring(0, 2));
                cents = NumberToWords(decimalValue);
            }
            string result = !string.IsNullOrEmpty(cents) ? (decimalValue == 1 ? string.Format("{0} " + dollarPH + " AND {1} CENT", dollar, cents) : string.Format("{0} " + dollarPH + " AND {1} CENTS", dollar, cents)) : string.Format("{0} " + dollarPH, dollar);
            return result.Trim();
        }


        /***** Private method called by the main function *****/
        private static string NumberToWords(int number)
        {
            bool moreThanTen = false;

            if (number == 0)
                return "ZERO";

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " MILLION ";
                number %= 1000000;
                moreThanTen = true;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " THOUSAND ";
                number %= 1000;
                moreThanTen = true;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " HUNDRED ";
                number %= 100;
                moreThanTen = true;
            }

            if (number > 0)
            {
                var unitsMap = new[] { "ZERO", "ONE", "TWO", "THREE", "FOUR", "FIVE", "SIX", "SEVEN", "EIGHT", "NINE", "TEN", "ELEVEN", "TWELVE", "THIRTEEN", "FOURTEEN", "FIFTEEN", "SIXTEEN", "SEVENTEEN", "EIGHTEEN", "NINETEEN" };
                var tensMap = new[] { "ZERO", "TEN", "TWENTY", "THIRTY", "FORTY", "FIFTY", "SIXTY", "SEVENTY", "EIGHTY", "NINETY" };

                if (moreThanTen)
                    words += "AND ";

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[(number) / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[(number) % 10];
                }
            }
            return words;
        }
    }
}