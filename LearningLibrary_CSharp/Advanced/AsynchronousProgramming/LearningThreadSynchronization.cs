using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Advanced.AsynchronousProgramming
{
    public class LearningThreadSynchronization : IDemo
    {
        public void Demo()
        {
            //Stopwatch stopwatch = new();
            //stopwatch.Start();

            //DoUnsynchronizedExample();
            //Console.WriteLine($@"DoUnsynchronizedExample: {stopwatch.ElapsedMilliseconds}");

            //stopwatch.Reset();
            //stopwatch.Start();

            //DoUnsynchronizedParallelForExample();
            //Console.WriteLine($@"DoUnsynchronizedParallelForExample: {stopwatch.ElapsedMilliseconds}");

            //stopwatch.Reset();
            //stopwatch.Start();

            //DoSynchronizingWithMonitorExample();
            //Console.WriteLine($@"DoSynchronizingWithMonitorExample: {stopwatch.ElapsedMilliseconds}");

            //stopwatch.Reset();
            //stopwatch.Start();

            //DoSynchronizingWithLockExample();
            //Console.WriteLine($@"DoSynchronizingWithLockExample: {stopwatch.ElapsedMilliseconds}");

            DoSynchronizingWithManualResetEventSlimExample();
        }

        private void DoUnsynchronizedExample()
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

        private void DoUnsynchronizedParallelForExample()
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

        private void DoSynchronizingWithMonitorExample()
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

        private void DoSynchronizingWithLockExample()
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

        private void DoSynchronizingWithInterlockedExample()
        {
            object data = new();
            object newValue = new();

            Interlocked.CompareExchange(ref data, newValue, null);
        }

        private void DoSynchronizingWithManualResetEventSlimExample()
        {
            ManualResetEventSlim MainSignaledResetEvent;
            ManualResetEventSlim DoWorkSignaledResetEvent;

            using (MainSignaledResetEvent =
                new ManualResetEventSlim())
            using (DoWorkSignaledResetEvent =
                new ManualResetEventSlim())
            {
                Console.WriteLine("Application started....");
                Console.WriteLine("Starting task....");

                // Use Task.Factory.StartNew for .NET 4.0
                Task task = Task.Run(() =>
                {
                    Console.WriteLine("DoWork() started....");
                    DoWorkSignaledResetEvent.Set();
                    Console.WriteLine("DoWork() waiting....");
                    MainSignaledResetEvent.Wait();
                    Console.WriteLine("DoWork() ending....");
                });

                // Block until DoWork() has started
                DoWorkSignaledResetEvent.Wait();
                Console.WriteLine(" Waiting while thread executes...");
                MainSignaledResetEvent.Set();
                Console.WriteLine(" Set...");
                task.Wait();
                Console.WriteLine("Thread completed");
                Console.WriteLine("Application shutting down....");
            }
        }
    }
}