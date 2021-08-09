using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Advanced.AsynchronousProgramming.ThreadSynchronization
{
    internal class LearningUnsynchronizedThreads : IDemo
    {
        public void Demo()
        {
            int total = int.MaxValue;
            int count = 0;

            Console.WriteLine($"Increment and decrementing {total} times...");

            Task task = Task.Run(() =>
            {
                for(int i = 0; i < total; i++)
                {
                    count--;
                }
            });

            // Increment
            for (int i = 0; (i < total); i++)
            {
                count++;
            }

            task.Wait();
            Console.WriteLine($"Count = {count}");
        }
    }
}