using System;

namespace LearningCsharpLibrary.Patterns.Design.Structural.Proxy.Storage
{
    internal class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}