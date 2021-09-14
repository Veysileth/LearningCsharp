using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Fundamentals
{
    // UNDONE: Placeholder - fill as learn
    public class LearningGenericTypes : IDemo
    {
        private T[] CreateArray<T>(T first, T second)
        {
            return new T[] { first, second };
        }

        private void MultipleGenerics<T1, T2>(T1 first, T2 second)
        {
        }

        public void Demo()
        {
            throw new NotImplementedException();
        }

        private class MyClass<T> where T : ITestableInterface
        {
            public T value;
        }

        private class MyClass2<T> where T : class
        {
            public T value;
        }

        private class MyClass3<T> where T : new()
        {
            public T value;
        }

        private class MyClass4<T> where T : class, ITestableInterface, new()
        {
            public T value;
        }
    }
}