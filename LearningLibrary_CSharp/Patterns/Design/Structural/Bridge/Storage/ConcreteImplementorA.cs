using System;

namespace LearningCsharpLibrary.Patterns.Design.Structural.Bridge.Storage
{
    internal class ConcreteImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorA Operation");
        }
    }
}