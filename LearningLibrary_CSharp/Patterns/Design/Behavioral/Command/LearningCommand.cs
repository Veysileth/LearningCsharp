using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCsharpLibrary.Patterns.Design.Behavioral.Command.Storage;

namespace LearningCsharpLibrary.Patterns.Design.Behavioral.Command
{
    public class LearningCommand : IDemo, IDesignPattern
    {
        public static LevelScale UsageFrequency { get; } = LevelScale.MediumHigh;
        public static LevelScale Hardness { get; } = LevelScale.Unknown;

        public void Demo()
        {
            // The client code can parameterize an invoker with any commands.
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new ComplexCommand(receiver, "Send email", "Save report"));

            invoker.DoSomethingImportant();
        }
    }
}