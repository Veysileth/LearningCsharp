using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Advanced.AsynchronousProgramming.ThreadSynchronization
{
    internal class LearningThreadLocal : IDemo
    {
        private static ThreadLocal<double> _Count =
            new ThreadLocal<double>(() => 0.01134);

        public static double Count
        {
            get { return _Count.Value; }
            set { _Count.Value = value; }
        }

        public void Demo()
        {
            Thread thread = new Thread(Decrement);
            thread.Start();

            // Increment
            for (double i = 0; i < short.MaxValue; i++)
            {
                Count++;
            }
            thread.Join();
            Console.WriteLine("Main Count = {0}", Count);
        }

        private static void Decrement()
        {
            Count = -Count;
            for (double i = 0; i < short.MaxValue; i++)
            {
                Count--;
            }
            Console.WriteLine(
                "Decrement Count = {0}", Count);
        }
    }
}