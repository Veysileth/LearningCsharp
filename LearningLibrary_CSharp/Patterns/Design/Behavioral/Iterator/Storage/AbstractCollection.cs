namespace LearningCsharpLibrary.Patterns.Design.Behavioral.Iterator
{
    internal interface AbstractCollection
    {
        Storage.Iterator CreateIterator();
    }
}