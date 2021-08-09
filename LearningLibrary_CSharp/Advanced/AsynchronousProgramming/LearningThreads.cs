using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Advanced.AsynchronousProgramming
{
    public class LearningThreads : IDemo
    {
        private const int repetitions = 1000;

        public void Demo()
        {
            DoExampleThreadPool();
        }

        private void DoExampleThread()
        {
            ThreadStart threadStart = DoExampleThread;
            Thread thread = new Thread(threadStart);
            thread.Start();
            thread.Priority = ThreadPriority.Lowest;

            for (int i = 0; i < repetitions; i++)
            {
                Console.WriteLine("-");
            }

            thread.Join();
            Console.WriteLine($"+ thread state: {thread.ThreadState}");
        }

        private void DoExampleThreadPool()
        {
            /*
             *  ThreadPool > Thread on fast ms/s methods.
             */
            ThreadPool.QueueUserWorkItem(DoWork, "+");

            for (int i = 0; i < repetitions; i++)
            {
                Console.WriteLine("-");
            }

            /*
             *  Retarded. Never do that on prod.
             */
            Thread.Sleep(1000);
        }

        private void DoWork(object state)
        {
            for (int i = 0; i < repetitions; i++)
            {
                Console.WriteLine(state);
            }
        }
    }
}