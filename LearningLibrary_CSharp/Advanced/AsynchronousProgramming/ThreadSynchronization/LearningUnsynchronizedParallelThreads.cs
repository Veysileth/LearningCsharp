using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Advanced.AsynchronousProgramming.ThreadSynchronization
{
    internal class LearningUnsynchronizedParallelThreads : IDemo
    {
        public void Demo()
        {
            int total = int.MaxValue;
            int count = 0;

            Console.WriteLine($"Increment and decrementing {total} times...");

            Parallel.For(0, total,
                new ParallelOptions() { CancellationToken = new System.Threading.CancellationToken() }
                , i =>
                {
                    count++;
                    count--;
                }); ;
            Console.WriteLine("Count = {0}", count);
        }
    }
}