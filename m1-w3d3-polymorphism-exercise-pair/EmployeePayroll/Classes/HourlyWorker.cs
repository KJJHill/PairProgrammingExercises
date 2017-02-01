using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Classes
{
    public class HourlyWorker : IWorker
    {
        private string lastName;

        private string firstName;

        private double hourlyRate;

        private int hoursWorked;

        public int HoursWorked
        {
            get { return hoursWorked; }
        }

        public double HourlyRate
        {
            get { return hourlyRate; }

        }

        public string FirstName
        {
            get { return firstName; }

        }

        public string LastName
        {
            get { return lastName; }

        }

        public HourlyWorker(double hourlyRate, string firstName, string lastName)
        {
            if (hourlyRate > 0)
            {
                this.hourlyRate = Math.Round(hourlyRate,2);
            }
            else
            {
                this.hourlyRate = 0;
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
            double weeklyPay = 0;
            if (hoursWorked > 0)
            {
                if (hoursWorked <= 40)
                {
                    weeklyPay = hoursWorked * hourlyRate;
                }
                else
                {
                    weeklyPay = hourlyRate* hoursWorked;
                    
                    weeklyPay = weeklyPay + (hourlyRate* (hoursWorked - 40) *.5);
                }
                this.hoursWorked = hoursWorked;
            }

            return Math.Round(weeklyPay, 2);
        }
    }
}

