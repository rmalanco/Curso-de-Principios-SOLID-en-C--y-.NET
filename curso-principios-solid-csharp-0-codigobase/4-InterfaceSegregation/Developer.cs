namespace InterfaceSegregation
{
    public class Developer : IWorkActivities, IDevelopActivities
    {
        public Developer()
        {
        }

        public void Comunicate()
        {
            Console.WriteLine("I'm communicating");
        }

        public void Develop()
        {
            Console.WriteLine("I'm developing");
        }

        public void Plan()
        {
            Console.WriteLine("I'm planning");
        }
    }
}