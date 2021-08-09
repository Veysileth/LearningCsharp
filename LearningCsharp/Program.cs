namespace LearningCsharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //LearningCsharpLibrary.Advanced.AsynchronousProgramming.LearningTPL learningTPL = new();
            //learningTPL.Demo();

            LearningCsharpLibrary.Advanced.AsynchronousProgramming.LearningThreadSynchronization learningThreadSynchronization = new();
            learningThreadSynchronization.Demo();
        }
    }
}