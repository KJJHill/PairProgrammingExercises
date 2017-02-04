using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TDDExercises.Tests
{
    [TestClass]
    public class TDDExercisesTests
    {
        [TestMethod]
        public void StringCalculatorTest()
        {
            StringCalculator stringCalculator = new StringCalculator();
            Assert.AreEqual(0, stringCalculator.Add(""));
            Assert.AreEqual(0, stringCalculator.Add(null));
            Assert.AreEqual(1, stringCalculator.Add("1"));
            Assert.AreEqual(3, stringCalculator.Add("1,2"));
            Assert.AreEqual(-3, stringCalculator.Add("4,-7"));
            Assert.AreEqual(-3, stringCalculator.Add("-3"));
            Assert.AreEqual(-8, stringCalculator.Add("-5,-3"));
            Assert.AreEqual(-4, stringCalculator.Add("-7, 3"));
            Assert.AreEqual(13, stringCalculator.Add("1, 5, 7"));
            Assert.AreEqual(25, stringCalculator.Add("1,10,11,3"));

            Assert.AreEqual(6, stringCalculator.Add("1\n2,3"));
            Assert.AreEqual(14, stringCalculator.Add("3\n5\n2,4"));
            Assert.AreEqual(-3, stringCalculator.Add("-3"));
            Assert.AreEqual(3, stringCalculator.Add("//;\n1;2"));
            Assert.AreEqual(13, stringCalculator.Add("//!\n4!9"));
            
        }

        [TestMethod]
        public void NumbersToWordsTest()
        {
            NumbersToWords numberInputTest = new NumbersToWords();
            string[] numberWordArray = { "zero","one","two","three","four", "five", "six", "seven", "eight", "nine", "ten",
                "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

            for (int i = 0; i < 20; i++)
            {
                Assert.AreEqual(numberWordArray[i], numberInputTest.ConvertToWords(i));
            }

            Assert.AreEqual("twenty", numberInputTest.ConvertToWords(20));
            Assert.AreEqual("twenty-one", numberInputTest.ConvertToWords(21));
            Assert.AreEqual("thirty", numberInputTest.ConvertToWords(30));
            Assert.AreEqual("forty", numberInputTest.ConvertToWords(40));
            Assert.AreEqual("fifty", numberInputTest.ConvertToWords(50));
            Assert.AreEqual("sixty", numberInputTest.ConvertToWords(60));
            Assert.AreEqual("seventy", numberInputTest.ConvertToWords(70));
            Assert.AreEqual("eighty", numberInputTest.ConvertToWords(80));
            Assert.AreEqual("ninety", numberInputTest.ConvertToWords(90));

            Assert.AreEqual("three hundred", numberInputTest.ConvertToWords(300));
            Assert.AreEqual("three hundred and one", numberInputTest.ConvertToWords(301));
            Assert.AreEqual("four hundred and thirteen", numberInputTest.ConvertToWords(413));
            Assert.AreEqual("three hundred and twenty-one", numberInputTest.ConvertToWords(321));

            Assert.AreEqual("four thousand", numberInputTest.ConvertToWords(4000));
            Assert.AreEqual("four thousand and six", numberInputTest.ConvertToWords(4006));
            Assert.AreEqual("four thousand and sixteen", numberInputTest.ConvertToWords(4016));
            Assert.AreEqual("four thousand and twenty-six", numberInputTest.ConvertToWords(4026));
            Assert.AreEqual("four thousand and three hundred", numberInputTest.ConvertToWords(4300));
            Assert.AreEqual("four thousand and three hundred and six", numberInputTest.ConvertToWords(4306));
            Assert.AreEqual("four thousand and three hundred and sixteen", numberInputTest.ConvertToWords(4316));
            Assert.AreEqual("four thousand and two hundred and sixty-six", numberInputTest.ConvertToWords(4266));

        }
    }
}
