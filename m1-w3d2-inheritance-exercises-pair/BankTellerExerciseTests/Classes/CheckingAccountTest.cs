using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class CheckingAccountTest
    {
        [TestMethod]
        public void CheckingAccountWithdraw()
        {
            CheckingAccount c1 = new CheckingAccount();
            DollarAmount depositDollars = new DollarAmount(10000);
            c1.Deposit(depositDollars);
            Assert.AreEqual(depositDollars.totalAmountInCents, c1.Balance.totalAmountInCents);

            DollarAmount withdrawAmount = new DollarAmount(5000);
            c1.Withdraw(withdrawAmount);
            Assert.AreEqual(withdrawAmount.totalAmountInCents, c1.Balance.totalAmountInCents);

            DollarAmount negativeWithdraw = new DollarAmount(6000);
            DollarAmount negativeBalance = new DollarAmount(-2000);
            c1.Withdraw(negativeWithdraw);
            Assert.AreEqual(negativeBalance.totalAmountInCents, c1.Balance.totalAmountInCents);

            DollarAmount doubleNegativeBalance = new DollarAmount(-9000);
            c1.Withdraw(negativeWithdraw);
            Assert.AreEqual(doubleNegativeBalance.totalAmountInCents, c1.Balance.totalAmountInCents);

            c1.Withdraw(negativeWithdraw);
            Assert.AreEqual(doubleNegativeBalance.totalAmountInCents, c1.Balance.totalAmountInCents);

        }
    }
}
