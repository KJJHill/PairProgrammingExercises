using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Classes
{
    public class SalaryWorker : IWorker
    {

        private string lastName;

        private string firstName;

        private double annualSalary;

        public double AnnualSalary
        {
            get { return annualSalary; }
            set { annualSalary = value; }
        }
        
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
  
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public SalaryWorker(double annualSalary, string firstName, string lastName)
        {
            
        }
        public double CalculateWeeklyPay(int hoursWorked)
        {
            double result = 0.0;

            return result;
        }



    }
}
