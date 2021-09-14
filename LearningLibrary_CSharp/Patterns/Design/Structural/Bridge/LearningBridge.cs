using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCsharpLibrary.Patterns.Design.Structural.Bridge.Storage;

namespace LearningCsharpLibrary.Patterns.Design.Structural.Bridge
{
    public class LearningBridge : IDemo, IDesignPattern
    {
        public LevelScale UsageFrequency { get; } = LevelScale.MediumLow;
        public LevelScale Hardness { get; } = LevelScale.Unknown;

        public void Demo()
        {
            Abstraction ab = new RefinedAbstraction();
            // Set implementation and call
            ab.Implementor = new ConcreteImplementorA();
            ab.Operation();
            // Change implemention and call
            ab.Implementor = new ConcreteImplementorB();
            ab.Operation();
            // Wait for user
            Console.ReadKey();
        }
    }
}