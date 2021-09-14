using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Patterns
{
    public class DesignPattern
    {
        public LevelScale UsageFrequency { get; }
        public LevelScale Hardness { get; }

        public void Demo()
        {
        }

        public enum LevelScale
        {
            Unknown = 0,
            Low = 1,
            MediumLow = 2,
            Medium = 3,
            MediumHigh = 4,
            High = 5
        }
    }
}