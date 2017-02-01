using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;



namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class DollarAmountTest
    {
        [TestMethod]
        public new void ToString()
        {
            DollarAmount jimmyDollar = new DollarAmount(3210);
            Assert.AreEqual("$32.10", jimmyDollar.ToString());

            DollarAmount bobbyDollar = new DollarAmount(1000);
            Assert.AreEqual("$10.00", bobbyDollar.ToString());

            DollarAmount dollyDollar = new DollarAmount(1);
            Assert.AreEqual("$0.01", dollyDollar.ToString());

            DollarAmount ellaDollar = new DollarAmount(-1000);
            Assert.AreEqual("$-10.00", ellaDollar.ToString());

        }
    }
}
