using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public abstract class Employee
{
    protected int employeeId;
    protected string employeeName;
    protected string department;
    protected string joiningDate;
    public Employee(int id, string name, string dept, string joinDate)
    {
        employeeId = id;
        employeeName = name;
        department = dept;
        joiningDate = joinDate;
    }
    public abstract double CalculateSalary();
    public virtual string GetEmployeeDetails()
    {
        return "ID: " + employeeId + "\n" +
               "Name: " + employeeName + "\n" +
               "Department: " + department + "\n" +
               "Joining Date: " + joiningDate;
    }
    public virtual void DisplaySalaryInfo()
    {
        Console.WriteLine("Salary Information:");
        Console.WriteLine("Total Salary: " + CalculateSalary());
    }
}
public class FullTimeEmployee : Employee
{
    private double monthlySalary;
    private double bonus;
    public FullTimeEmployee(int id, string name, string dept, string joinDate,
                            double salary, double bonusAmount)
        : base(id, name, dept, joinDate)
    {
        monthlySalary = salary;
        bonus = bonusAmount;
    }
    public override double CalculateSalary()
    {
        return monthlySalary + bonus;
    }
    public override string GetEmployeeDetails()
    {
        return "ID: " + employeeId + "\n" +
               "Name: " + employeeName + "\n" +
               "Department: " + department + "\n" +
               "Joining Date: " + joiningDate + "\n" +
               "Employee Type: Full-Time\n" +
               "Monthly Salary: " + monthlySalary + "\n" +
               "Bonus: " + bonus;
    }
}
public class PartTimeEmployee : Employee
{
    private double hourlyRate;
    private int hoursWorked;
    public PartTimeEmployee(int id, string name, string dept, string joinDate,
                            double rate, int hours)
        : base(id, name, dept, joinDate)
    {
        hourlyRate = rate;
        hoursWorked = hours;
    }
    public override double CalculateSalary()
    {
        return hourlyRate * hoursWorked;
    }
    public override string GetEmployeeDetails()
    {
        return "ID: " + employeeId + "\n" +
               "Name: " + employeeName + "\n" +
               "Department: " + department + "\n" +
               "Joining Date: " + joiningDate + "\n" +
               "Employee Type: Part-Time\n" +
               "Hourly Rate: " + hourlyRate + "\n" +
               "Hours work: " + hoursWorked;
    }
}
class Program
{
    static void Main(string[] args)
    {
        FullTimeEmployee emp1 = new FullTimeEmployee(1, "Rahim", "IT", "2020-01-01", 50000, 10000);
        PartTimeEmployee emp2 = new PartTimeEmployee(2, "Karim", "Sales", "2021-03-10", 500, 80);
        Console.WriteLine(emp1.GetEmployeeDetails());
        emp1.DisplaySalaryInfo();

        Console.WriteLine("\n------------------------\n");

        Console.WriteLine(emp2.GetEmployeeDetails());
        emp2.DisplaySalaryInfo();
    }
}

