namespace Liskov
{
    public class EmployeeContractor : Employee
    {
        public EmployeeContractor(string fullName, int hoursWorked, decimal hourValue) : base(fullName, hoursWorked, hourValue)
        {
        }

        public override decimal CalculateSalary(decimal hourValue)
        {
            return hourValue * HoursWorked;
        }
    }
}