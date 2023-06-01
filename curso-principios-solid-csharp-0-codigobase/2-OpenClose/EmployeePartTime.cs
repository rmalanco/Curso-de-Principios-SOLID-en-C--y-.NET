namespace OpenClose
{
    public class EmployeePartTime : Employee
    {
        public decimal EffortCompensation { get; set; }
        public int ExtraDays { get; set; }
        public EmployeePartTime(string fullName, int hoursWorked)
        {
            FullName = fullName;
            HoursWorked = hoursWorked;
        }
        public override decimal CalculateSalaryMonthly()
        {
            HourValue = 20000M;
            Salary = HourValue * HoursWorked;
            if (HoursWorked > 160)
            {
                EffortCompensation = 5000M;
                ExtraDays = HoursWorked - 160;
                Salary += EffortCompensation * ExtraDays;
            }
            return Salary;
        }
    }
}