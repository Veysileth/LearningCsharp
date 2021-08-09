using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Advanced.AsynchronousProgramming.ThreadSynchronization
{
    internal class LearningThreadStaticAttribute : IDemo
    {
        [ThreadStatic]
        private static double _Count = 0.01134;

        public static double Count
        {
            get { return LearningThreadStaticAttribute._Count; }
            set { LearningThreadStaticAttribute._Count = value; }
        }

        public void Demo()
        {
            Thread thread = new Thread(Decrement);
            thread.Start();

            // Increment
            for (int i = 0; i < short.MaxValue; i++)
            {
                Count++;
            }

            thread.Join();
            Console.WriteLine("Main Count = {0}", Count);
        }

        private static void Decrement()
        {
            for (int i = 0; i < short.MaxValue; i++)
            {
                Count--;
            }
            Console.WriteLine("Decrement Count = {0}", Count);
        }
    }
}