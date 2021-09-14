using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Patterns.Design.Creational.AbstractFactory.Storage
{
    internal class BigThingFactory : ThingFactory
    {
        public override Thing GetThing(string thingType)
        {
            return thingType switch
            {
                "BigItem1" => new BigItem1(),
                "BigItem2" => new BigItem2(),
                _ => null
            };
        }
    }
}