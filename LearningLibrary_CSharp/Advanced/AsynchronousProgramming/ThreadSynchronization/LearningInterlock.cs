using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Advanced.AsynchronousProgramming.ThreadSynchronization
{
    internal class LearningInterlock : IDemo
    {
        public void Demo()
        {
            object data = new();
            object newValue = new();

            Interlocked.CompareExchange(ref data, newValue, null);
        }
    }
}