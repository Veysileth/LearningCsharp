using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCsharpLibrary.Patterns.Design.Behavioral.Template.Storage;

namespace LearningCsharpLibrary.Patterns.Design.Behavioral.Template
{
    public class LearningTemplate : IDemo, IDesignPattern
    {
        public LevelScale UsageFrequency { get; } = LevelScale.Medium;
        public LevelScale Hardness { get; } = LevelScale.Unknown;

        public void Demo()
        {
            AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();
            AbstractClass aB = new ConcreteClassB();
            aB.TemplateMethod();
        }
    }
}