namespace OpenClose
{
    public abstract class Employee : IEmployee
    {
        public string? FullName { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourValue { get; set; }
        public decimal Salary { get; set; }
        public virtual decimal CalculateSalaryMonthly() => 0;
    }
}