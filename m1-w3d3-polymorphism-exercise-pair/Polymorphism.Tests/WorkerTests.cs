using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll.Classes;

namespace Polymorphism.Tests
{
    [TestClass]
    public class WorkerTests
    {
        [TestMethod]
        public void SalaryWorkerTest()
        {
            SalaryWorker mySalariedWorker = new SalaryWorker(150000, "Johnny", "Doe");
            Assert.AreEqual("Johnny", mySalariedWorker.FirstName);
            Assert.AreEqual("Doe", mySalariedWorker.LastName);
            Assert.AreEqual(150000.0, mySalariedWorker.AnnualSalary);
            Assert.AreEqual(2884.62, mySalariedWorker.CalculateWeeklyPay(52));
            Assert.AreEqual(52, mySalariedWorker.HoursWorked);

            mySalariedWorker = new SalaryWorker(-150000, null, null);
            Assert.AreEqual("unknown", mySalariedWorker.FirstName);
            Assert.AreEqual("unknown", mySalariedWorker.LastName);
            Assert.AreEqual(0, mySalariedWorker.AnnualSalary);

            mySalariedWorker = new SalaryWorker(0, "", "");
            Assert.AreEqual("unknown", mySalariedWorker.FirstName);
            Assert.AreEqual("unknown", mySalariedWorker.LastName);
            Assert.AreEqual(0, mySalariedWorker.AnnualSalary);

            mySalariedWorker = new SalaryWorker(150000.009999, "Johnny", "Doe");
            Assert.AreEqual(150000.01, mySalariedWorker.AnnualSalary);

            Assert.AreEqual(2884.62, mySalariedWorker.CalculateWeeklyPay(-52));
            Assert.AreEqual(0, mySalariedWorker.HoursWorked);

        }

        [TestMethod]
        public void HourlyWorkerTest()
        {
            HourlyWorker myHourlyWorker = new HourlyWorker(25.25, "Johnny", "Doe");
            Assert.AreEqual("Johnny", myHourlyWorker.FirstName);
            Assert.AreEqual("Doe", myHourlyWorker.LastName);
            Assert.AreEqual(25.25, myHourlyWorker.HourlyRate);
            Assert.AreEqual(1010, myHourlyWorker.CalculateWeeklyPay(40));
            Assert.AreEqual(40, myHourlyWorker.HoursWorked);

            myHourlyWorker = new HourlyWorker(-25.00, "", "");
            Assert.AreEqual("unknown", myHourlyWorker.FirstName);
            Assert.AreEqual("unknown", myHourlyWorker.LastName);
            Assert.AreEqual(0, myHourlyWorker.HourlyRate);
            Assert.AreEqual(0, myHourlyWorker.CalculateWeeklyPay(-40));
            Assert.AreEqual(0, myHourlyWorker.HoursWorked);

            myHourlyWorker = new HourlyWorker(0, null, null);
            Assert.AreEqual("unknown", myHourlyWorker.FirstName);
            Assert.AreEqual("unknown", myHourlyWorker.LastName);
            Assert.AreEqual(0, myHourlyWorker.HourlyRate);

            myHourlyWorker = new HourlyWorker(25, "Johnny", "Doe");
            Assert.AreEqual(25, myHourlyWorker.HourlyRate);

            myHourlyWorker = new HourlyWorker(25.009993, "Johnny", "Doe");
            Assert.AreEqual(25.01, myHourlyWorker.HourlyRate);

            myHourlyWorker = new HourlyWorker(25.004443, "Johnny", "Doe");
            Assert.AreEqual(25, myHourlyWorker.HourlyRate);

            Assert.AreEqual(0, myHourlyWorker.CalculateWeeklyPay(-40));

            Assert.AreEqual(0, myHourlyWorker.CalculateWeeklyPay(0));

            Assert.AreEqual(1750, myHourlyWorker.CalculateWeeklyPay(60));
        }

        [TestMethod]
        public void VolunteerWorkerTest()
        {
            VolunteerWorker myVolunteerWorker = new VolunteerWorker("Johnny", "Doe");
            Assert.AreEqual("Johnny", myVolunteerWorker.FirstName);
            Assert.AreEqual("Doe", myVolunteerWorker.LastName);

            Assert.AreEqual(0, myVolunteerWorker.CalculateWeeklyPay(40));
            Assert.AreEqual(40, myVolunteerWorker.HoursWorked);

            myVolunteerWorker = new VolunteerWorker("", "");
            Assert.AreEqual("unknown", myVolunteerWorker.FirstName);
            Assert.AreEqual("unknown", myVolunteerWorker.LastName);
            Assert.AreEqual(0, myVolunteerWorker.CalculateWeeklyPay(-40));
            Assert.AreEqual(0, myVolunteerWorker.HoursWorked);

            myVolunteerWorker = new VolunteerWorker(null, null);
            Assert.AreEqual("unknown", myVolunteerWorker.FirstName);
            Assert.AreEqual("unknown", myVolunteerWorker.LastName);


        }
    }
}
