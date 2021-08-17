using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCsharpLibrary.Patterns.Design.Behavioral.Observer.Storage;

namespace LearningCsharpLibrary.Patterns.Design.Behavioral.Observer
{
    public class LearningObserver : IDemo
    {
        public void Demo()
        {
            //Create a Product with Out Of Stock Status

            //Stupid example. Should use Event/Delegate.

            Subject RedMI = new Subject("Red MI Mobile", 10000, "Out Of Stock");
            //User Anurag will be created and user1 object will be registered to the subject
            Storage.Observer user1 = new("A", RedMI);
            //User Pranaya will be created and user1 object will be registered to the subject
            Storage.Observer user2 = new("B", RedMI);
            //User Priyanka will be created and user3 object will be registered to the subject
            Storage.Observer user3 = new("C", RedMI);

            Console.WriteLine("Red MI Mobile current state : " + RedMI.getAvailability());
            Console.WriteLine();
            // Now product is available
            RedMI.setAvailability("Available");
        }
    }
}