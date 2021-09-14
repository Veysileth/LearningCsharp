using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Patterns.Design.Creational.AbstractFactory.Storage
{
    internal class SmallThingFactory : ThingFactory
    {
        public override Thing GetThing(string thingType)
        {
            return thingType switch
            {
                "SmallItem1" => new SmallItem1(),
                "SmallItem2" => new SmallItem2(),
                _ => null
            };
        }
    }
}