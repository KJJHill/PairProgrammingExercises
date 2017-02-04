using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises
{
    public class NumbersToWords
    {
        private const string THOUSAND = " thousand";
        private const string HUNDRED = " hundred";
        private const string AND = " and ";

        Dictionary<int, string> numberedWords = new Dictionary<int, string>
            {
                {0, "zero" }, {1,"one" }, {2,"two" }, {3 ,"three" }, {4, "four" }, {5, "five" }, {6, "six" }, {7, "seven" }, {8, "eight" }, {9, "nine" }, {10, "ten" },
                {11, "eleven" }, {12, "twelve" }, {13, "thirteen" }, {14, "fourteen" }, {15, "fifteen" }, {16, "sixteen" }, {17, "seventeen" }, {18, "eighteen" }, {19, "nineteen" },
                {20, "twenty" }, {30, "thirty" }, {40, "forty" }, {50, "fifty" }, {60, "sixty" }, {70, "seventy" }, {80, "eighty" }, {90, "ninety" }
            };

        public string ConvertToWords(int numberToConvert)
        {
            string numberWordString = "";
            int remainder;

            if (NumberIsInRange(numberToConvert, 0, 19))
            {
                numberWordString = numberedWords[numberToConvert];
            }
            else if (NumberIsInRange(numberToConvert, 20, 99))
            {
                numberWordString = GetTwoDigitWords(numberToConvert);
            }
            else if (NumberIsInRange(numberToConvert, 100, 999))
            {
                numberWordString = GetThreeDigitWords(numberToConvert);
            }
            else if (NumberIsInRange(numberToConvert, 1000, 19999))
            {
                int thousandsPlace = (Math.DivRem(numberToConvert, 1000, out remainder));
                numberWordString = numberedWords[thousandsPlace] + THOUSAND; ;

                if (remainder != 0)
                {
                    numberWordString += GetRestOfWordString(remainder);
                }
            }
            else if (NumberIsInRange(numberToConvert, 20000, 99999))
            {
                int tenThousandsPlace = (Math.DivRem(numberToConvert, 1000, out remainder));
                numberWordString = GetTwoDigitWords(tenThousandsPlace) + THOUSAND;

                if (remainder != 0)
                {
                    numberWordString += GetRestOfWordString(remainder);
                }
            }
            else if (NumberIsInRange(numberToConvert, 100000, 999999))
            {
                int hundredThousandPlace = (Math.DivRem(numberToConvert, 1000, out remainder));
                numberWordString = GetThreeDigitWords(hundredThousandPlace) + THOUSAND;

                if (remainder != 0)
                {
                    numberWordString += GetRestOfWordString(remainder);
                }
            }

            return numberWordString;
        }

        private string GetTwoDigitWords(int twoDigitInt)
        {
            string twoDigitString = "";

            if (twoDigitInt % 10 == 0)
            {
                twoDigitString = numberedWords[twoDigitInt];
            }
            else
            {
                int tensRemainder;
                int tensPlace = (Math.DivRem(twoDigitInt, 10, out tensRemainder)) * 10;
                twoDigitString += numberedWords[tensPlace] + "-" + numberedWords[tensRemainder];
            }

            return twoDigitString;
        }

        private string GetThreeDigitWords(int threeDigitInt)
        {
            int hundredsRemainder;
            int hundredsPlace = (Math.DivRem(threeDigitInt, 100, out hundredsRemainder));
            string threeDigitString = numberedWords[hundredsPlace] + HUNDRED;

            if (hundredsRemainder != 0)
            {
                threeDigitString += GetRestOfWordString(hundredsRemainder);
            }
            return threeDigitString;
        }

        private string GetRestOfWordString(int remainderValue)
        {
            string restOfWordString = "";
            if (remainderValue <= 19)
            {
                restOfWordString += AND + numberedWords[remainderValue];
            }
            else if (remainderValue <= 99)
            {
                restOfWordString += AND + GetTwoDigitWords(remainderValue);
            }
            else
            {
                restOfWordString += AND + GetThreeDigitWords(remainderValue);
            }
            return restOfWordString;
        }

        private bool NumberIsInRange(int numberToCheck, int mininum, int maximum)
        {
            bool results = (numberToCheck >= mininum && numberToCheck <= maximum) ? true : false;
            return results;
        }
    }
}
