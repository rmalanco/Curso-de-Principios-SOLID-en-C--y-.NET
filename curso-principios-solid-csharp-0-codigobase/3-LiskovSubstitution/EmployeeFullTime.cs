namespace Liskov
{
    public class EmployeeFullTime : Employee
    {
        public int ExtraHours { get; set; }
        public EmployeeFullTime(string fullName, int hoursWorked, decimal hourValue, int extraHours) : base(fullName, hoursWorked, hourValue)
        {
            ExtraHours = extraHours;
        }

        public override decimal CalculateSalary(decimal hourValue)
        {
            return hourValue * (HoursWorked + ExtraHours);
        }
    }
}