namespace LearningCsharpLibrary.Patterns.Design.Behavioral.Iterator.Storage
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Employee(string name, int id)
        {
            Name = name;
            ID = id;
        }
    }
}