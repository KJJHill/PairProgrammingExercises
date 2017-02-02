using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll.Classes
{
    public class VolunteerWorker: IWorker
    {
        private string lastName;

        private string firstName;


        private int hoursWorked;

        public int HoursWorked
        {
            get { return hoursWorked; }

        }

        public string FirstName
        {
            get { return firstName; }

        }

        public string LastName
        {
            get { return lastName; }

        }

        public VolunteerWorker(string firstName, string lastName)
        {
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
                this.hoursWorked = hoursWorked;
                
            }
            return weeklyPay;
        }
    }
}
