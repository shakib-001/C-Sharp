using System;
using System.Collections.Generic;

// *********************************************
// ABSTRACT BASE CLASS: Employee
// *********************************************
public abstract class Employee
{
    protected int employeeId;
    protected string employeeName;
    protected string department;
    protected string joiningDate;

    // Constructor
    public Employee(int id, string name, string dept, string joinDate)
    {
        employeeId = id;
        employeeName = name;
        department = dept;
        joiningDate = joinDate;
    }

    // Abstract Method (must be overridden)
    public abstract double CalculateSalary();

    // Virtual Method: Returns employee basic details
    public virtual string GetEmployeeDetails()
    {
        return $"ID: {employeeId}\nName: {employeeName}\nDepartment: {department}\nJoined: {joiningDate}";
    }

    // Virtual Method: Salary info display
    public virtual void DisplaySalaryInfo()
    {
        Console.WriteLine("Salary Information:");
        Console.WriteLine($"Total Salary: {CalculateSalary()}");
    }
}



// *********************************************
// Derived Class 1: Full-Time Employee
// *********************************************
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
        return base.GetEmployeeDetails() +
               $"\nEmployee Type: Full-Time\nMonthly Salary: {monthlySalary}\nBonus: {bonus}";
    }
}



// *********************************************
// Derived Class 2: Part-Time Employee
// *********************************************
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
        return base.GetEmployeeDetails() +
               $"\nEmployee Type: Part-Time\nHourly Rate: {hourlyRate}\nHours Worked: {hoursWorked}";
    }
}



// *********************************************
// Derived Class 3: Contract Employee
// *********************************************
public class ContractEmployee : Employee
{
    private double projectPayment;
    private int numberOfProjects;
    private string contractDuration;

    public ContractEmployee(int id, string name, string dept, string joinDate,
                            double payment, int projects, string duration)
        : base(id, name, dept, joinDate)
    {
        projectPayment = payment;
        numberOfProjects = projects;
        contractDuration = duration;
    }

    public override double CalculateSalary()
    {
        return projectPayment * numberOfProjects;
    }

    public override string GetEmployeeDetails()
    {
        return base.GetEmployeeDetails() +
               $"\nEmployee Type: Contract\nProject Payment: {projectPayment}\nProjects: {numberOfProjects}\nDuration: {contractDuration}";
    }
}



// *********************************************
// Derived Class 4: Intern Employee
// *********************************************
public class InternEmployee : Employee
{
    private double monthlyStipend;
    private string internshipDuration;
    private string mentor;

    public InternEmployee(int id, string name, string dept, string joinDate,
                          double stipend, string duration, string mentorName)
        : base(id, name, dept, joinDate)
    {
        monthlyStipend = stipend;
        internshipDuration = duration;
        mentor = mentorName;
    }

    public override double CalculateSalary()
    {
        return monthlyStipend;
    }

    public override string GetEmployeeDetails()
    {
        return base.GetEmployeeDetails() +
               $"\nEmployee Type: Intern\nStipend: {monthlyStipend}\nDuration: {internshipDuration}\nMentor: {mentor}";
    }
}



// *********************************************
// PAYROLL SYSTEM CLASS
// *********************************************
public class PayrollSystem
{
    private List<Employee> employees = new List<Employee>();

    public void AddEmployee(Employee emp)
    {
        employees.Add(emp);
        Console.WriteLine($"Employee {emp.GetType().Name} added successfully.\n");
    }

    public void RemoveEmployee(int id)
    {
        employees.RemoveAll(e => e.GetEmployeeDetails().Contains($"ID: {id}"));
        Console.WriteLine($"Employee with ID {id} removed.\n");
    }

    public void DisplayAllEmployees()
    {
        Console.WriteLine("\n----- ALL EMPLOYEES -----");
        foreach (var emp in employees)
        {
            Console.WriteLine(emp.GetEmployeeDetails());
            Console.WriteLine("--------------------------");
        }
    }

    public void ProcessPayroll()
    {
        Console.WriteLine("\n----- PAYROLL PROCESSING -----");
        foreach (var emp in employees)
        {
            Console.WriteLine(emp.GetEmployeeDetails());
            emp.DisplaySalaryInfo();
            Console.WriteLine("-------------------------------");
        }
    }

    public Employee FindEmployeeById(int id)
    {
        foreach (var emp in employees)
        {
            if (emp.GetEmployeeDetails().Contains($"ID: {id}"))
                return emp;
        }
        return null;
    }

    public double CalculateTotalPayroll()
    {
        double total = 0;

        foreach (var emp in employees)
            total += emp.CalculateSalary();

        return total;
    }

    public int GetEmployeeCount()
    {
        return employees.Count;
    }
}



// *********************************************
// MAIN() METHOD (DEMONSTRATION PART)
// *********************************************
public class Program
{
    public static void Main(string[] args)
    {
        PayrollSystem payroll = new PayrollSystem();

        // Adding 5 Employees
        payroll.AddEmployee(new FullTimeEmployee(1, "Rahim", "IT", "2020-01-01", 50000, 10000));
        payroll.AddEmployee(new PartTimeEmployee(2, "Karim", "Sales", "2021-03-10", 500, 80));
        payroll.AddEmployee(new ContractEmployee(3, "Jasim", "HR", "2022-05-20", 20000, 3, "6 Months"));
        payroll.AddEmployee(new InternEmployee(4, "Nadim", "IT", "2023-06-01", 12000, "3 Months", "Rahim"));
        payroll.AddEmployee(new FullTimeEmployee(5, "Sakib", "Finance", "2019-02-12", 45000, 8000));

        // Display all employees
        payroll.DisplayAllEmployees();

        // Payroll processing (polymorphism demonstration)
        payroll.ProcessPayroll();

        // Search for an employee
        Console.WriteLine("\nSearching for Employee with ID 3...");
        var empFound = payroll.FindEmployeeById(3);
        if (empFound != null)
            Console.WriteLine(empFound.GetEmployeeDetails());
        else
            Console.WriteLine("Employee not found!");

        // Add a new employee dynamically
        payroll.AddEmployee(new InternEmployee(6, "Abrar", "Marketing", "2024-01-10", 10000, "2 Months", "Karim"));

        // Re-process payroll
        payroll.ProcessPayroll();
    }
}
