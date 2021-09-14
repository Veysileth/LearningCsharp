using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCsharpLibrary.Patterns.Design.Creational.AbstractFactory.Storage;

namespace LearningCsharpLibrary.Patterns.Design.Creational.AbstractFactory
{
    internal class LearningAbstractFactory : IDemo, IDesignPattern
    {
        public LevelScale UsageFrequency { get; } = LevelScale.High;
        public LevelScale Hardness { get; } = LevelScale.Unknown;

        public void Demo()
        {
            BigThingFactory bigThingFactory = new();
            var bigItem1 = bigThingFactory.GetThing("BigItem1");
            var bigItem2 = bigThingFactory.GetThing("BigItem2");

            ThingFactory bThingFactory = ThingFactory.CreateThingFactory(ThingFactoryType.BigThing);
            ThingFactory sThingFactory = ThingFactory.CreateThingFactory(ThingFactoryType.SmallThing);

            var c = bThingFactory.GetThing("BigItem1");
        }
    }
}