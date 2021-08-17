using System;

namespace LearningCsharpLibrary.Patterns.Design.Structural.Decorator.Storage
{
    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteComponent.Operation()");
        }
    }
}