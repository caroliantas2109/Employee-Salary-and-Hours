
// Ignore Spelling: GLA SODV

using System;

//Sorry Michael, you're going to see more comments, they just help me understand my steps and keep track of what I'm doing.
//
namespace GLA1_SODV1202
{
    class Employee
    {
        // TO DO
        // Declare your member variables and initialize values (if required) here.

        //I need to do:
        //store the employee’s name
        //hourly wage
        //how much money they are currently owed.*

        //private because i don't want someone changes it.
        private string _employeeMember;
        private double _hourlyEmployee;
        private double _salaryEmployee;

        public  void EmployeeInformation(string name, int hourlyEmployee, double salaryEmployee)
        {
            //In this part I'm creating a public constructor that uses parameters to assign values to the private variables.
            _employeeMember = name;
            _hourlyEmployee = hourlyEmployee; // wage
            _salaryEmployee = salaryEmployee; // amount owed
        }

        public void SetName(string name)
        {
            // TO DO
            // Set name to a member variable.

            _employeeMember = name;
        }

        public string GetName()
        {
            // TO DO
            // Return the member variable corresponding to the name attribute.

            return _employeeMember; // This part will return names that will be add "store" 
        }

        public void SetWage(double rate) // rate is a parameter
        {// take the value from rate and store in _salaryEmployee
            // TO DO
            // Set wage to a member variable.

            _hourlyEmployee = rate;
        }

        public void Work(double hours)
        {
            // TO DO
            // Update the employee's unpaid hours.
            // Calculate the amount of money owed.

            _salaryEmployee += _hourlyEmployee * hours;
        }

        public double Pay()
        {
            // TO DO
            // Return the amount of money that the employee is owed.
            // Reset the amount owed to 0.

            double totalSalaryEmployee = _salaryEmployee;
            _salaryEmployee = 0; // this part will reset the salary to 0 
            return totalSalaryEmployee;

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            emp1.SetName("David");
            emp1.SetWage(15);
            emp2.SetName("Susan");
            emp2.SetWage(30);

            var amount = emp1.Pay();
            Console.WriteLine("Employee '{0}' is paid {1} before working...", emp1.GetName(), emp1.Pay());
            Console.WriteLine("Employee '{0}' is paid {1} before working...", emp2.GetName(), emp2.Pay());
            emp1.Work(5);
            emp2.Work(8);
            Console.WriteLine("Employee '{0}' is paid {1} after working...", emp1.GetName(), emp1.Pay());

            emp1.Work(5);
            emp2.Work(2);
            Console.WriteLine("Employee '{0}' is paid {1} after working...", emp1.GetName(), emp1.Pay());
            Console.WriteLine("Employee '{0}' is paid {1} after working...", emp2.GetName(), emp2.Pay());
        }
    }
}
