using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Fundamentals.Grouping.Generic
{
    public class LearningQueues : IDemo
    {
        private readonly Queue<string> numbers = new();

        public void Demo()
        {
            numbers.Enqueue("one");
            numbers.Enqueue("two");
            numbers.Enqueue("three");
            numbers.Enqueue("four");
            numbers.Enqueue("five");

            foreach (string number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine($"Dequeuing '{numbers.Dequeue()}'");
            Console.WriteLine($"Peek at next item to dequeue: {numbers.Peek()}");
            Console.WriteLine($"Dequeuing '{numbers.Dequeue()}'");

            Queue<string> queueCopy = new(numbers.ToArray());

            Console.WriteLine("Contents of the first copy:");
            foreach (string number in queueCopy)
            {
                Console.WriteLine(number);
            }
        }
    }
}