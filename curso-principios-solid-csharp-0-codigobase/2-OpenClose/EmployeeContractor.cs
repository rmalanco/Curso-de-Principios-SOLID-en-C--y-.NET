namespace OpenClose
{
    public class EmployeeContractor : Employee
    {
        public EmployeeContractor(string fullName, int hoursWorked)
        {
            FullName = fullName;
            HoursWorked = hoursWorked;
        }
        public override decimal CalculateSalaryMonthly()
        {
            HourValue = 10000M;
            Salary = HourValue * HoursWorked;
            return Salary;
        }
    }
}