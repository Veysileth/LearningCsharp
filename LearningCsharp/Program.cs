using System;

namespace LearningCsharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (2 > 1)
            {
                LearningCsharpLibrary.Fundamentals.Classes.LearningClasses learningClasses = new("", 0);
                LearningCsharpLibrary.Fundamentals.Classes.LearningClasses learningClasses2 = new("a", 1);

                Console.WriteLine(learningClasses.ToString());
                Console.WriteLine(learningClasses2.ToString());

                Console.WriteLine(GC.GetTotalMemory(true));
            }

            while (true) { }
        }
    }
}