using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCsharpLibrary.Patterns.Design.Behavioral.Strategy.Storage;

namespace LearningCsharpLibrary.Patterns.Design.Behavioral.Strategy
{
    public class LearningStrategy : IDemo, IDesignPattern
    {
        public LevelScale UsageFrequency { get; } = LevelScale.High;
        public LevelScale Hardness { get; } = LevelScale.Unknown;

        public void Demo()
        {
            // The client code picks a concrete strategy and passes it to the
            // context. The client should be aware of the differences between
            // strategies in order to make the right choice.
            var context = new Context();

            Console.WriteLine("Client: Strategy is set to normal sorting.");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine();

            Console.WriteLine("Client: Strategy is set to reverse sorting.");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();
        }
    }
}