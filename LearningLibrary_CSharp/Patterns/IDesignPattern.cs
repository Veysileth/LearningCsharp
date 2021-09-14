using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Patterns
{
    public interface IDesignPattern
    {
        public static LevelScale UsageFrequency { get; }
        public static LevelScale Hardness { get; }
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