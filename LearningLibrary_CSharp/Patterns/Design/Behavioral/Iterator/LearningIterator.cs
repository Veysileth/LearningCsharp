using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Patterns.Design.Behavioral.Iterator
{
    public class LearningIterator : IDemo, IDesignPattern
    {
        public static LevelScale UsageFrequency { get; } = LevelScale.High;
        public static LevelScale Hardness { get; } = LevelScale.Unknown;

        public void Demo()
        {
            ConcreteCollection collection = new ConcreteCollection();
            collection.AddEmployee(new Storage.Employee("A", 100));
            collection.AddEmployee(new Storage.Employee("B", 101));
            collection.AddEmployee(new Storage.Employee("C", 102));
            collection.AddEmployee(new Storage.Employee("D", 103));
            collection.AddEmployee(new Storage.Employee("E", 104));
            collection.AddEmployee(new Storage.Employee("F", 105));

            // Create iterator
            Storage.Iterator iterator = collection.CreateIterator();
            //looping iterator
            Console.WriteLine("Iterating over collection:");

            for (Storage.Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                Console.WriteLine($"ID : {emp.ID} & Name : {emp.Name}");
            }
        }
    }
}