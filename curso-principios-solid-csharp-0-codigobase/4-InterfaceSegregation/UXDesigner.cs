using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public class UXDesigner : IWorkActivities, IUXActivities
    {
        public void Comunicate()
        {
            Console.WriteLine("I'm communicating");
        }

        public void Plan()
        {
            Console.WriteLine("I'm planning");
        }

        public void PrepareUX()
        {
            Console.WriteLine("I'm preparing UX");
        }
    }
}