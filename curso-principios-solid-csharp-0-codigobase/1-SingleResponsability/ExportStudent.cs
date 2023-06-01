namespace SingleResponsability
{
    public static class ExportStudent
    {
        public static void Export(IEnumerable<Student> students)
        {
            ExportHelper.ExportData(students, "Students.csv", student => $"{student.Id};{student.FullName};{string.Join("|", student.Grades)}");
        }
    }
}