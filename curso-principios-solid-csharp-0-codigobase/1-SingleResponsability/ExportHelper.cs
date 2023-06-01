using System.Text;

namespace SingleResponsability
{
    public static class ExportHelper
    {
        public static void ExportData<T>(IEnumerable<T> data, string fileName, Func<T, string> dataToString)
        {
            StringBuilder sb = new();
            sb.AppendLine("Id;FullName;Grades");
            foreach (var item in data)
            {
                sb.AppendLine(dataToString(item));
            }
            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName), sb.ToString(), Encoding.Unicode);
        }
    }
}