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

        private int hoursWorked;

        public int HoursWorked
        {
            get { return hoursWorked; }
            
        }

        public double AnnualSalary
        {
            get { return annualSalary; }
            
        }
        
        public string FirstName
        {
            get { return firstName; }
            
        }
  
        public string LastName
        {
            get { return lastName; }
            
        }

        public SalaryWorker(double annualSalary, string firstName, string lastName)
        {
            if (annualSalary > 0)
            {
                this.annualSalary = Math.Round(annualSalary,2);
            }
            else
            {
                this.annualSalary = 0;
            }

            if (!String.IsNullOrEmpty(firstName))
            {
                this.firstName = firstName;
            }
            else
            {
                this.firstName = "unknown";
            }

            if (!String.IsNullOrEmpty(firstName))
            {
                this.lastName = lastName;
            }
            else
            {
                this.lastName = "unknown";
            }

            
        }
        public double CalculateWeeklyPay(int hoursWorked)
        {
            double weeklyPay = Math.Round((annualSalary/ 52), 2);
            if (hoursWorked > 0)
            {
                this.hoursWorked = hoursWorked;
            }
            else
            {
                this.hoursWorked = 0;
            }
            
            return weeklyPay ;
        }



    }
}
