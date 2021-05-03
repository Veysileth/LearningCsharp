using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Patterns.Design.Creational.AbstractFactory
{
    internal abstract class ThingFactory
    {
        public abstract Thing GetThing(string thingType);

        public static ThingFactory CreateThingFactory(ThingFactoryType thingFactoryType)
        {
            return thingFactoryType switch
            {
                ThingFactoryType.BigThing => new BigThingFactory(),
                ThingFactoryType.SmallThing => new SmallThingFactory(),
                _ => null
            };
        }
    }
}