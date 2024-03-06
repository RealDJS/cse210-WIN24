using Internal;

abstract class Employee
{
    public string name;

    public Employee(string name) { this.name = name; }
    public abstract decimal CalculatePay();

}

class SalaryEmployee : Employee
{
    protected decimal annualSalary;

    public SalaryEmployee(string name, decimal annualSalary) : base(name) { this.annualSalary = annualSalary; }


    public override decimal CalculatePay() { return annualSalary / 26; }// bi-weekly pay
}

class HourlyEmployee : Employee
{
    protected decimal hourlyRate;
    protected int hoursWorked;

    public HourlyEmployee(string name, decimal hourlyRate, int hoursWorked) : base(name) { this.hourlyRate = hourlyRate; this.hoursWorked = hoursWorked; }

    public override decimal CalculatePay() { return (hourlyRate * hoursWorked) * 2; }// bi-weekly pay

}

SalaryEmployee salaryEmployee = new SalaryEmployee("John", (decimal)96000.13);
HourlyEmployee hourlyEmployee = new HourlyEmployee("Jane", (decimal)13.50, 80);

Console.WriteLine($"{salaryEmployee.name} makes ${salaryEmployee.CalculatePay()} bi-weekly");
Console.WriteLine($"{hourlyEmployee.name} makes ${hourlyEmployee.CalculatePay()} bi-weekly");

