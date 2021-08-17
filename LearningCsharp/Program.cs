namespace LearningCsharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //LearningCsharpLibrary.Advanced.AsynchronousProgramming.LearningTPL learningTPL = new();
            //learningTPL.Demo();

            LearningCsharpLibrary.Patterns.Design.Structural.Adapter.LearningAdapter adapter = new();
            adapter.Demo();
        }
    }
}