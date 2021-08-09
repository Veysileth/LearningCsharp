using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Advanced.AsynchronousProgramming.ThreadSynchronization
{
    internal class LearningMonitors : IDemo
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
                for(int i = 0; i < total; i++)
                {
                    bool lockTaken = false;
                    try
                    {
                        Monitor.Enter(sync, ref lockTaken);
                        count--;
                    }
                    finally
                    {
                        if(lockTaken)
                        {
                            Monitor.Exit(sync);
                        }
                    }
                }
            });

            // Increment
            for (int i = 0; i < total; i++)
            {
                bool lockTaken = false;
                try
                {
                    Monitor.Enter(sync, ref lockTaken);
                    count++;
                }
                finally
                {
                    if (lockTaken)
                    {
                        Monitor.Exit(sync);
                    }
                }
            }

            task.Wait();
            Console.WriteLine($"Count = {count}");
        }
    }
}