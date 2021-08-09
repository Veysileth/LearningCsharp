using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Advanced.AsynchronousProgramming.ThreadSynchronization
{
    internal class LearningManualResetEventSlim : IDemo
    {
        public void Demo()
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