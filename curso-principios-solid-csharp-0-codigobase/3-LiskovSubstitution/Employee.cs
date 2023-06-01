namespace Liskov
{
    public abstract class Employee
    {
        public string FullName { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourValue { get; set; }
        protected Employee(string fullName, int hoursWorked, decimal hourValue)
        {
            FullName = fullName;
            HoursWorked = hoursWorked;
            HourValue = hourValue;
        }
        public abstract decimal CalculateSalary(decimal hourValue);
    }
}