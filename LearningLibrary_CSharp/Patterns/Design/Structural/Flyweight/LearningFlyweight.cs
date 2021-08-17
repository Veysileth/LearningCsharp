using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCsharpLibrary.Patterns.Design.Structural.Flyweight.Storage;

namespace LearningCsharpLibrary.Patterns.Design.Structural.Flyweight
{
    public class LearningFlyweight : IDemo
    {
        public void Demo()
        {
            int extrinsicstate = 22;

            FlyweightFactory factory = new FlyweightFactory();

            Storage.Flyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Storage.Flyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            Storage.Flyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight fu = new();
            fu.Operation(--extrinsicstate);
        }
    }
}