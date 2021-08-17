namespace LearningCsharpLibrary.Patterns.Design.Structural.Bridge.Storage
{
    internal class Abstraction
    {
        protected Implementor implementor;

        public Implementor Implementor
        {
            set { implementor = value; }
        }

        public virtual void Operation()
        {
            implementor.Operation();
        }
    }
}