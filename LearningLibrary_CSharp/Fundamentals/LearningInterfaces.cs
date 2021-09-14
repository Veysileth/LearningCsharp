using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCsharpLibrary.Fundamentals.Classes.Utensils;

namespace LearningCsharpLibrary.Fundamentals
{
    // UNDONE: Placeholder - fill as learn
    public class LearningInterfaces : IDemo, INotable, ITestableInterface, IEquatable<LearningInterfaces>
    {
        public string Note { get; } = "represent additional features of a class. I'd call it an \"is\" relationship, like in \"Foo is disposable\", hence the IDisposable interface in C#.";
        public string Name { get; set; } //ITestableInterface
        public string SubName { get; set; }  //ITestableInterface : ITestableSubInterface

        public void Test() //ITestableInterface
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(LearningInterfaces learningInterfaces1, LearningInterfaces learningInterfaces2)
        {
            return learningInterfaces1.Name == learningInterfaces2.Name;
        }

        public static bool operator !=(LearningInterfaces learningInterfaces1, LearningInterfaces learningInterfaces2)
        {
            return learningInterfaces1.Name != learningInterfaces2.Name;
        }

        public void SubTest() //ITestableInterface : ITestableSubInterface
        {
            throw new NotImplementedException();
        }

        public void Demo()
        {
            throw new NotImplementedException();
        }

        public bool Equals(LearningInterfaces other)
        {
            return (Note, Name, SubName).Equals((other.Note, other.Name, other.SubName));
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as LearningInterfaces);
        }
    }

    internal interface ITestableInterface : ITestableSubInterface
    {
        string Name { get; set; }

        void Test();
    }

    internal interface ITestableSubInterface
    {
        string SubName { get; set; }

        void SubTest();
    }
}