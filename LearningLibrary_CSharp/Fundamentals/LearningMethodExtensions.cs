using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Fundamentals
{
    // UNDONE: Placeholder - fill as learn
    public class LearningMethodExtensions : IDemo
    {
        public void Demo()
        {
            LearningMethodExtensions learningMethodExtensions = new();
            int test = learningMethodExtensions.Test();
        }
    }

    public static class LearningMethodExtensionsExtension
    {
        public static int Test(this LearningMethodExtensions learningMethodExtensions)
        {
            return 1;
        }
    }
}