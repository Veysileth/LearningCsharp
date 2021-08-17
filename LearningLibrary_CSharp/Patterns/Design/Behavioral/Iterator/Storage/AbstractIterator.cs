namespace LearningCsharpLibrary.Patterns.Design.Behavioral.Iterator.Storage
{
    internal interface AbstractIterator
    {
        Employee First();

        Employee Next();

        bool IsCompleted { get; }
    }
}