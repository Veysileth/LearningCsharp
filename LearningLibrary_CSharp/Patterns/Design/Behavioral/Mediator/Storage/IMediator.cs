namespace LearningCsharpLibrary.Patterns.Design.Behavioral.Mediator.Storage
{
    public interface IMediator
    {
        void Notify(object sender, string ev);
    }
}