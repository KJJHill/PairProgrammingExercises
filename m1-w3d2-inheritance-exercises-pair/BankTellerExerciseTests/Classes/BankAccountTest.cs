using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void AllMethodsTest()
        {

            BankAccount b1 = new BankAccount();
            DollarAmount d1 = new DollarAmount(0);
            Assert.AreEqual(d1.totalAmountInCents, b1.Balance.totalAmountInCents);

            DollarAmount d2 = new DollarAmount(500000);
            b1.Deposit(d2);
            Assert.AreEqual(d2.totalAmountInCents, b1.Balance.totalAmountInCents);

            DollarAmount withdrawDollar = new DollarAmount(100000);
            DollarAmount correctBalance = new DollarAmount(400000);
            b1.Withdraw(withdrawDollar);
            Assert.AreEqual(correctBalance.totalAmountInCents, b1.Balance.totalAmountInCents);

            BankAccount b2 = new BankAccount();
            DollarAmount transferInAmount = new DollarAmount(200000);
            b1.Transfer(b2, transferInAmount);
            Assert.AreEqual(transferInAmount.totalAmountInCents, b2.Balance.totalAmountInCents);

        }
    }
}