using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Patterns.Design.Creational.FactoryMethod
{
    public class LearningFactoryMethod : IDemo, IDesignPattern
    {
        public LevelScale UsageFrequency { get; } = LevelScale.High;
        public LevelScale Hardness { get; } = LevelScale.Unknown;

        public void Demo()
        {
            Item1Factory item1Factory = new();
            Item3Factory item3Factory = new ();
            Item2Factory item2Factory = new ();

            IItem item1 = item1Factory.CreateItem();
            IItem item2 = item2Factory.CreateItem();
            IItem item3 = item3Factory.CreateItem();
        }
    }
}