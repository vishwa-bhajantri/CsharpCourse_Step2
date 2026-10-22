using System;

namespace EmployeeSalarySystem_RunTimePolymorphism
{
    abstract class Employee
    {
        public string Name { get; set; }
        public int HoursWorked { get; set; }
        public double HourlyRate { get; set; }

        public abstract double CalculateSalary();
        public void DisplayDetails()
        {
            Console.WriteLine($"Employee Name : {Name}");
            Console.WriteLine($"Hourly Worked : {HoursWorked}");
            Console.WriteLine($"Hourly Rate : {HourlyRate}");
        }
    }

    class PermanantEmplyee : Employee
    {
        public override double CalculateSalary()
        {
            double baseSalary = HoursWorked * HourlyRate;
            double bonus = baseSalary * 0.10;
            return baseSalary + bonus;
        }
    }

    class ContractEmloyee : Employee
    {
        public override double CalculateSalary()
        {
            double baseSalary = HoursWorked * HourlyRate;
            double deduction = baseSalary * 0.10;
            return baseSalary - deduction;
        }
    }

    class FreeLancer : Employee
    {
        public override double CalculateSalary()
        {
            return 9999.9;
        }
    }

    class Program
    {
        static void Main()
        {
            Employee emp1 = new PermanantEmplyee();
            emp1.Name = "Alice";
            emp1.HoursWorked = 160;
            emp1.HourlyRate = 50;

            emp1.DisplayDetails();
            Console.WriteLine(emp1.CalculateSalary());


            Employee emp2 = new ContractEmloyee();
            emp2.Name = "Joe";
            emp2.HoursWorked = 140;
            emp2.HourlyRate = 40;

            emp2.DisplayDetails();
            Console.WriteLine(emp2.CalculateSalary());


            Employee emp3 = new FreeLancer();
            emp3.Name = "Shaun";
            emp3.HoursWorked = 180;
            emp3.HourlyRate = 90;

            emp3.DisplayDetails();
            Console.WriteLine(emp3.CalculateSalary());
        }
    }
}