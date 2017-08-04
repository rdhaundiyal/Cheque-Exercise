using System;
using System.Globalization;

namespace Deepend.Services.Model
{
    public class Cheque
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public DateTime ChequeDate { get; set; }
        public string Currency { get; set; }
        public decimal Amount { get; set; }
        public string AmountInWords { get { return ConvertToWords(Amount); } }



        private static string ConvertToWords(decimal amount)
        {
            var amountString = amount.ToString(CultureInfo.InvariantCulture);
            var len = amountString.Length;
            var decimalIndex = amountString.IndexOf('.');
            var numberPart = amountString.Substring(0, decimalIndex);
            var decimalPart = amountString.Substring(decimalIndex + 1, len - decimalIndex - 1);
            return string.Format("{0} & {1} cents", NumberToWords(Convert.ToInt32(numberPart)), NumberToWords(Convert.ToInt32(decimalPart)));
        }
      //Method taken from internet
        private static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

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
