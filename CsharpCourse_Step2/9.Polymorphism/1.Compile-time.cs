using System;

namespace EmployeeSalarySystem_CompileTimePolymorphism
{
    public class EmployeeSalaryCalculation
    {
        public double CalculateSalary(double monthlysalary)
        {
            return monthlysalary;
        }

        public double CalculateSalary(int hoursWorked, int hourlyRate)
        {
            return hoursWorked*hourlyRate;
        }

        public double CalculateSalary(double salesAmmount, double commissionRate, bool isSales)
        {
            return salesAmmount*commissionRate;
        }

        public double CalculateSalary(int hoursWorked, int hourlyRate, double bonus)
        {
            return (hoursWorked*hourlyRate)+bonus;
        }
    }

    class Program
    {
        static void Main()
        {
            EmployeeSalaryCalculation employeeSalaryCalculation = new EmployeeSalaryCalculation();
            double employee1 = employeeSalaryCalculation.CalculateSalary(30000);
            double employee2 = employeeSalaryCalculation.CalculateSalary(40, 20);
            double employee3 = employeeSalaryCalculation.CalculateSalary(5000000, 0.1, true);
            double employee4 = employeeSalaryCalculation.CalculateSalary(40,20,5000);

            Console.WriteLine(employee1);
            Console.WriteLine(employee2);
            Console.WriteLine(employee3);
            Console.WriteLine(employee4);
        }
    }
}