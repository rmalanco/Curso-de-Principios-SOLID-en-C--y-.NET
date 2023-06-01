namespace InterfaceSegregation
{
    public class Tester : IWorkActivities, ITestActivities
    {
        public Tester()
        {
        }

        public void Plan()
        {
           Console.WriteLine("I'm planning");
        }

        public void Comunicate()
        {
            Console.WriteLine("I'm communicating");
        }

        public void Test()
        {
            Console.WriteLine("I'm testing");
        }
    }
}