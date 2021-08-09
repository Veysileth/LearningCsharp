using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Advanced.AsynchronousProgramming.ThreadSynchronization
{
    internal class LearningLock : IDemo
    {
        public void Demo()
        {
            object sync = new object();
            int total = int.MaxValue;
            int count = 0;

            Console.WriteLine($"Increment and decrementing {total} times...");

            // Use Task.Factory.StartNew for .NET 4.0
            Task task = Task.Run(() =>
            {
                for (int i = 0; i < total; i++)
                {
                    lock (sync)
                    {
                        count--;
                    }
                }
            });

            // Increment
            for (int i = 0; i < total; i++)
            {
                lock (sync)
                {
                    count++;
                }
            }

            task.Wait();
            Console.WriteLine($"Count = {count}");
        }
    }
}