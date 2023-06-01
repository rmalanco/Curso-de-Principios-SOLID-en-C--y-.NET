namespace OpenClose
{
    public class EmployeeFullTime : Employee
    {
        public EmployeeFullTime(string fullName, int hoursWorked)
        {
            FullName = fullName;
            HoursWorked = hoursWorked;
        }

        public override decimal CalculateSalaryMonthly()
        {
            HourValue = 30000M;
            Salary = HourValue * HoursWorked;
            return Salary;
        }
    }
}