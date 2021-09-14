using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Fundamentals
{
    // TODO: Get into it
    public class LearningLambda : IDemo
    {
        public void Demo()
        {
            Action<int> action = (msg) => Console.WriteLine(msg);
            Action<int> action1 = msg => Console.WriteLine(msg);
        }
    }
}