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

            if (numberToConvert >= 0 && numberToConvert <= 19)
            {
                numberWordString = numberedWords[numberToConvert];
            }
            else if (numberToConvert >= 20 && numberToConvert <= 99)
            {
                numberWordString = getTwoDigitWords(numberToConvert);
            }
            else if (numberToConvert >= 100 && numberToConvert <= 999)
            {
                numberWordString = getThreeDigitWords(numberToConvert);
            }
            else if (numberToConvert >= 1000 && numberToConvert <= 19999)
            {
                numberWordString = getThousands(numberToConvert);
            }
            else if (numberToConvert >= 20000 && numberToConvert <= 99999)
            {
                numberWordString = getTenThousands(numberToConvert);
            }
            else if (numberToConvert >= 100000 && numberToConvert <= 999999)
            {
                numberWordString = getHundredThousand(numberToConvert);
            }

            return numberWordString;
        }

        private string getTwoDigitWords(int twoDigitInt)
        {
            string twoDigitString = "";

            if (twoDigitInt % 10 == 0)
            {
                twoDigitString = numberedWords[twoDigitInt];
            }
            else
            {
                int onesPlace = twoDigitInt % 10;
                int tensPlace = twoDigitInt - onesPlace;

                twoDigitString = numberedWords[tensPlace] + "-" + numberedWords[onesPlace];
            }

            return twoDigitString;
        }

        private string getThreeDigitWords(int threeDigitInt)
        {
            string threeDigitString = "";
            int hundredsPlace = threeDigitInt / 100;
            int hundredsRemainder = threeDigitInt % 100;

            if (hundredsRemainder == 0)
            {
                threeDigitString = numberedWords[hundredsPlace] + HUNDRED;
            }
            else if (hundredsRemainder <= 19)
            {
                threeDigitString = numberedWords[hundredsPlace] + HUNDRED + AND + numberedWords[hundredsRemainder];
            }
            else
            {
                threeDigitString = numberedWords[hundredsPlace] + HUNDRED + AND + getTwoDigitWords(hundredsRemainder);
            }

            return threeDigitString;
        }

        private string getThousands(int fourDigitInt)
        {
            string fourDigitString = "";
            int thousandsPlace = fourDigitInt / 1000;
            int thousandsRemainder = fourDigitInt % 1000;

            if (thousandsRemainder == 0)
            {
                fourDigitString = numberedWords[thousandsPlace] + THOUSAND;
            }
            else if (thousandsRemainder <= 19)
            {
                fourDigitString = numberedWords[thousandsPlace] + THOUSAND + AND + numberedWords[thousandsRemainder];
            }
            else if (thousandsRemainder <= 99)
            {
                fourDigitString = numberedWords[thousandsPlace] + THOUSAND + AND + getTwoDigitWords(thousandsRemainder);
            }
            else
            {
                fourDigitString = numberedWords[thousandsPlace] + THOUSAND + AND + getThreeDigitWords(thousandsRemainder);
            }

            return fourDigitString;
        }

        private string getTenThousands(int fiveDigitInt)
        {
            string fiveDigitString = "";
            int tenThousandsPlace = fiveDigitInt / 1000;
            int tenThousandRemainder = fiveDigitInt % 1000;

            if (tenThousandRemainder == 0)
            {
                fiveDigitString = getTwoDigitWords(tenThousandsPlace) + THOUSAND;
            }
            else if (tenThousandRemainder <= 19)
            {
                fiveDigitString = getTwoDigitWords(tenThousandsPlace) + THOUSAND + AND + numberedWords[tenThousandRemainder];
            }
            else if (tenThousandRemainder <= 99)
            {
                fiveDigitString = getTwoDigitWords(tenThousandsPlace) + THOUSAND + AND + getTwoDigitWords(tenThousandRemainder);
            }
            else
            {
                fiveDigitString = getTwoDigitWords(tenThousandsPlace) + THOUSAND + AND + getThreeDigitWords(tenThousandRemainder);
            }
            return fiveDigitString;
        }

        private string getHundredThousand(int sixDigitInt)
        {
            string sixDigitString = "";
            int hundredThousandPlace = sixDigitInt / 1000;
            int hundredThousandRemainder = sixDigitInt % 1000;

            if (hundredThousandRemainder == 0)
            {
                sixDigitString = getThreeDigitWords(hundredThousandPlace) + THOUSAND;
            }
            else if (hundredThousandRemainder <= 19)
            {
                sixDigitString = getThreeDigitWords(hundredThousandPlace) + THOUSAND + AND + numberedWords[hundredThousandRemainder];
            }
            else if (hundredThousandRemainder <= 99)
            {
                sixDigitString = getThreeDigitWords(hundredThousandPlace) + THOUSAND + AND + getTwoDigitWords(hundredThousandRemainder);
            }
            else
            {
                sixDigitString = getThreeDigitWords(hundredThousandPlace) + THOUSAND + AND + getThreeDigitWords(hundredThousandRemainder);
            }
            return sixDigitString;
        }
    }


}
