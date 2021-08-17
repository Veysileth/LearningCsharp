namespace LearningCsharpLibrary.Patterns.Design.Structural.Bridge.Storage
{
    internal class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            implementor.Operation();
        }
    }
}