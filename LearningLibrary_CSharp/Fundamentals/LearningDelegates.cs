using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Fundamentals
{
    public class LearningDelegates : IDemo
    {
        public delegate void Delegate();

        private Delegate delegateFunction;

        public void Demo()
        {
            delegateFunction += MyFirstDelegateFunction;
            delegateFunction += MySecondDelegateFunction;

            delegateFunction();
        }

        private void MyFirstDelegateFunction()
        {
        }

        private void MySecondDelegateFunction()
        {
        }
    }
}