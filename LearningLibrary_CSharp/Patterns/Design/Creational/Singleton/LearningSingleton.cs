using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Patterns.Design.Creational.Singleton
{
    public class LearningSingleton : IDemo, IDesignPattern
    {
        public LevelScale UsageFrequency { get; } = LevelScale.MediumHigh;
        public LevelScale Hardness { get; } = LevelScale.Unknown;

        public void Demo()
        {
            Singleton s1 = Singleton.GetInstance;
            Singleton s2 = Singleton.GetInstance;
            // Test for same instance
            if (s1 == s2)
            {
                Console.WriteLine("Objects are the same instance");
            }
        }

        public class Singleton
        {
            private static readonly Lazy<Singleton> _Instance = new(() => new Singleton());

            public static Singleton GetInstance
            {
                get
                {
                    return _Instance.Value;
                }
            }

            protected Singleton()
            {
            }
        }
    }
}