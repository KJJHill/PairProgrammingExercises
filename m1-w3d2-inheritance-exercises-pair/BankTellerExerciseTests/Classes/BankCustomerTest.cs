using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankTellerExercise.Classes;

namespace BankTellerExerciseTests.Classes
{
    [TestClass]
    public class BankCustomerTest
    {
        [TestMethod]
        public void BankCustomerAccountTest()
        {
            BankCustomer customerTest = new BankCustomer();
            BankAccount bA1 = new BankAccount();
            BankAccount bA2 = new BankAccount();

            DollarAmount fittyDolla = new DollarAmount(5000);
            DollarAmount fiveHunedDolla = new DollarAmount(50000);
            DollarAmount fiveThaouDolla = new DollarAmount(500000);
            DollarAmount fittyThouDolla = new DollarAmount(5000000);

            bA1.Deposit(fiveHunedDolla);
            bA2.Deposit(fittyDolla);


            customerTest.AddAccount(bA1);
            customerTest.AddAccount(bA2);
            BankAccount[] accountArrayTest = { bA1, bA2 };
            CollectionAssert.AreEqual(accountArrayTest, customerTest.Accounts);
        }
    }
}
