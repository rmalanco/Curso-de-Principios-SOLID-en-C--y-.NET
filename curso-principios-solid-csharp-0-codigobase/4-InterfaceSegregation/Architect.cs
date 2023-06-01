namespace InterfaceSegregation
{
    public class Architect : IActivities
    {
        public void Comunicate()
        {
            Console.WriteLine("I'm communicating");
        }

        public void Design()
        {
            Console.WriteLine("I'm designing");
        }

        public void Develop()
        {
            Console.WriteLine("I'm developing");
        }

        public void Plan()
        {
            Console.WriteLine("I'm planning");
        }

        public void Test()
        {
            Console.WriteLine("I'm testing");
        }
    }

    // new rol add : UX Designer "Class UXDesigner"
}