namespace OpenClose
{
    public interface IEmployee
    {
        string? FullName { get; set; }
        int HoursWorked { get; set; }
        decimal HourValue { get; set; }
        decimal Salary { get; set; }
        decimal CalculateSalaryMonthly();
    }
}