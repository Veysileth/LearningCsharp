using System.Collections.Generic;

namespace LearningCsharpLibrary.Patterns.Design.Structural.Flyweight
{
    public class FlyweightFactory
    {
        private Dictionary<string, Storage.Flyweight> flyweights { get; set; } = new();

        // Constructor
        public FlyweightFactory()
        {
            flyweights.Add("X", new Storage.ConcreteFlyweight());
            flyweights.Add("Y", new Storage.ConcreteFlyweight());
            flyweights.Add("Z", new Storage.ConcreteFlyweight());
        }

        public Storage.Flyweight GetFlyweight(string key)
        {
            Storage.Flyweight flyweight;

            if (!flyweights.TryGetValue(key, out flyweight))
            {
                flyweight = new Storage.ConcreteFlyweight();
                flyweights.Add(key, flyweight);
            }

            return flyweight;
        }
    }
}