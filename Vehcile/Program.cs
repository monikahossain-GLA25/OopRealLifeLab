public abstract class Employee
{
    public string Name { get; set; }
    public int EmployeeId { get; set; }

    public Employee(string name, int employeeId)
    {
        Name = name;
        EmployeeId = employeeId;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Employee: {Name}");
    }

    public abstract decimal CalculateSalary();
}


interface IBonusEligible
{
    decimal CalculateBonus();
}

public class PermanentEmployee : Employee, IBonusEligible
{
    public decimal MonthlySalary { get; set; }
    public PermanentEmployee(string name, int employeeId, decimal monthlySalary)
        : base(name, employeeId)
    {
        MonthlySalary = monthlySalary;
    }
    public override decimal CalculateSalary()
    {
        return MonthlySalary;
    }
    public decimal CalculateBonus()
    {
        return MonthlySalary * 0.1m;
    }
}
public class ContractEmployee : Employee
{
    public decimal HourlyRate { get; set; }
    public int HoursWorked { get; set; }
    public ContractEmployee(string name, int employeeId, decimal hourlyRate, int hoursWorked)
        : base(name, employeeId)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }
    public override decimal CalculateSalary()
    {
        return HourlyRate * HoursWorked;
    }
}