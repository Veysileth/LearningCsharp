using System;

namespace LearningCsharpLibrary.Patterns.Design.Structural.Decorator.Storage
{
    public class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("ConcreteDecoratorA.Operation()");
        }
    }
}