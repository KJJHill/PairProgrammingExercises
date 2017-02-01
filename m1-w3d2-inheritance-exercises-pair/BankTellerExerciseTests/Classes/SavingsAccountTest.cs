using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class SavingsAccountTest
    {
        [TestMethod]
        public void SavingsAccountWithdrawTest()
        {
            SavingsAccount s1 = new SavingsAccount();
            DollarAmount fortyEightDollars = new DollarAmount(4800);
            DollarAmount fiftyDollars = new DollarAmount(5000);
            DollarAmount oneHundredDollars = new DollarAmount(10000);
            DollarAmount oneHundredFiftyDollars = new DollarAmount(15000);
            DollarAmount twoHundredDollars = new DollarAmount(20000);

            s1.Deposit(twoHundredDollars);
            Assert.AreEqual(twoHundredDollars.totalAmountInCents, s1.Balance.totalAmountInCents);
            
            s1.Withdraw(fiftyDollars);
            Assert.AreEqual(oneHundredFiftyDollars.totalAmountInCents, s1.Balance.totalAmountInCents);

            s1.Withdraw(fiftyDollars);
            Assert.AreEqual(oneHundredDollars.totalAmountInCents, s1.Balance.totalAmountInCents);

            s1.Withdraw(fiftyDollars);
            Assert.AreEqual(fortyEightDollars.totalAmountInCents, s1.Balance.totalAmountInCents);

            s1.Withdraw(oneHundredDollars);
            Assert.AreEqual(fortyEightDollars.totalAmountInCents, s1.Balance.totalAmountInCents);
        }
    }
}
