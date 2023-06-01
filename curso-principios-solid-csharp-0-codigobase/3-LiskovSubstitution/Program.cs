using Liskov;

CalculateSalaryMonthly(new List<Employee>() {
    new EmployeeFullTime("Pepito Pérez",160,50,10),
    new EmployeeContractor("Manuel Lopera",180,40)
});

static void CalculateSalaryMonthly(List<Employee> employees)
{
    foreach (var item in employees)
    {
        decimal salary = item.CalculateSalary(item.HourValue);
        Console.WriteLine($"The {item.FullName}'s salary is {salary}");
    }
}