using System;

namespace LearningCsharpLibrary.Patterns.Design.Structural.Bridge.Storage
{
    internal class ConcreteImplementorB : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ConcreteImplementorB Operation");
        }
    }
}