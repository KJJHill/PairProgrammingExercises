using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises
{
    public class StringCalculator
    {

        public int Add(string numbers)
        {
            int total = 0;
            if (!String.IsNullOrEmpty(numbers))
            {
                if (numbers.IndexOf("//") == 0 && numbers.IndexOf("\n") == 3)
                {
                    char[] stringDelimiters = { numbers.ElementAt(2) };
                    string trunchatedNumbers = numbers.Substring(4);
                    string[] arrayOfNumbers = trunchatedNumbers.Split(stringDelimiters);
                    foreach (var number in arrayOfNumbers)
                    {
                        total = total + int.Parse(number);
                    }
                }
                else
                {
                    char[] stringDelimiters = { '\n', ',' };
                    string[] arrayOfNumbers = numbers.Split(stringDelimiters);
                    foreach (var number in arrayOfNumbers)
                    {
                        total = total + int.Parse(number);
                    }
                }



            }

            return total;
        }


    }
}
