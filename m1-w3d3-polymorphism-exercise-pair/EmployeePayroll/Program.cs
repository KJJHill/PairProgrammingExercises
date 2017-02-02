using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeePayroll.Classes;


namespace EmployeePayroll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IWorker> myOverhead = new List<IWorker>();
            Random intRandomNum = new Random();
            double doubleRandomNum = (double)intRandomNum.Next();
            int totalOverheadHours = 0;
            double totalOverheadPay = 0;

            myOverhead.Add(new SalaryWorker((double)intRandomNum.Next(0, 200000), "Mickey", "Mouse"));
            myOverhead.Add(new HourlyWorker((double)intRandomNum.Next(0, 60), "Minnie", "Mouse"));
            myOverhead.Add(new VolunteerWorker("George(Goofy)", "Geef"));
            myOverhead.Add(new SalaryWorker((double)intRandomNum.Next(0, 200000), "Daisy", "Duck"));

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.WriteLine("{0, -28} {1,-15} {2,15}\n", "Employee", "Hours Worked", "Pay");

            foreach (IWorker worker in myOverhead)
            {
                string workerName = (worker.LastName + ", " + worker.FirstName);
                worker.CalculateWeeklyPay(intRandomNum.Next(0, 50));

                Console.WriteLine("{0, -28} {1,5} {2,25:c}\n", workerName, worker.HoursWorked, worker.CalculateWeeklyPay(worker.HoursWorked));

                totalOverheadHours += worker.HoursWorked;
                totalOverheadPay += worker.CalculateWeeklyPay(worker.HoursWorked);

            }

            Console.WriteLine();
            Console.WriteLine("Total Hours: " + totalOverheadHours);
            Console.WriteLine("Total Pay: {0:C} ", totalOverheadPay);

            
        }
    }
}
