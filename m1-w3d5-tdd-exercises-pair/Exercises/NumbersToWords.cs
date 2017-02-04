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

            //numberToConvert == Enumerable.Range(0, 99)
            if (numberToConvert >= 0 && numberToConvert <= 19)
            {
                numberWordString = numberedWords[numberToConvert];
            }
            else if (numberToConvert >= 20 && numberToConvert <= 99)
            {
                numberWordString = getTensAndOnes(numberToConvert);
            }
            else if (numberToConvert >= 100 && numberToConvert <= 999)
            {
                numberWordString = getHundreds(numberToConvert);

            }
            else if (numberToConvert >= 1000 && numberToConvert <= 9999)
            {
                numberWordString = getThousands(numberToConvert);

            }


            return numberWordString;
        }

        public string getTensAndOnes(int twoDigitInt)
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

        public string getHundreds(int threeDigitInt)
        {
            string threeDigitString = "";
            int hundredsPlace = threeDigitInt / 100;
            int tensAndOnes = threeDigitInt % 100;

            if (threeDigitInt % 100 == 0)
            {
                threeDigitString = numberedWords[hundredsPlace] + HUNDRED;
            }
            else if (tensAndOnes <= 19)
            {
                threeDigitString = numberedWords[hundredsPlace] + HUNDRED + AND + numberedWords[tensAndOnes];
            }
            else
            {
                threeDigitString = numberedWords[hundredsPlace] + HUNDRED + AND + getTensAndOnes(tensAndOnes);
            }

            return threeDigitString;
        }

        public string getThousands(int fourDigitInt)
        {
            string fourDigitString = "";
            int thousandsPlace = fourDigitInt / 1000;
            int hundreds = fourDigitInt % 1000;        

            if (fourDigitInt % 1000 == 0)
            {
                fourDigitString = numberedWords[thousandsPlace] + THOUSAND;
            }
            else if (hundreds <= 19)
            {
                fourDigitString = numberedWords[thousandsPlace] + THOUSAND + AND + numberedWords[hundreds];
            }
            else if (hundreds <= 99)
            {
                fourDigitString = numberedWords[thousandsPlace] + THOUSAND + AND + getTensAndOnes(hundreds);
            }
            else
            {
                fourDigitString = numberedWords[thousandsPlace] + THOUSAND + AND + getHundreds(hundreds);
            }

            return fourDigitString;
        }
    }


}
