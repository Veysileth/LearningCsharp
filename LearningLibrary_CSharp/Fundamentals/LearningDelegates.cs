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

        public delegate bool BoolDelegate();

        public delegate bool BoolDelegateWithArg(int i);

        private Delegate delegateFunction;
        private BoolDelegate boolDelegateFunction;
        private BoolDelegateWithArg boolDelegateWithArgFunction;

        public void Demo()
        {
            delegateFunction = MyFirstDelegateFunction;

            delegateFunction();

            delegateFunction = MySecondDelegateFunction;

            delegateFunction();

            boolDelegateFunction = MyFirstBoolDelegateFunction;

            _ = boolDelegateFunction();

            boolDelegateFunction = MySecondBoolDelegateFunction;

            _ = boolDelegateFunction();

            boolDelegateWithArgFunction = MyFirstBoolDelegateWithArgFunction;

            _ = boolDelegateWithArgFunction(1);

            boolDelegateWithArgFunction = MySecondBoolDelegateWithArgFunction;

            _ = boolDelegateWithArgFunction(2);
        }

        private void MyFirstDelegateFunction()
        {
        }

        private void MySecondDelegateFunction()
        {
        }

        private bool MyFirstBoolDelegateFunction()
        {
            return true;
        }

        private bool MySecondBoolDelegateFunction()
        {
            return true;
        }

        private bool MyFirstBoolDelegateWithArgFunction(int i)
        {
            return true;
        }

        private bool MySecondBoolDelegateWithArgFunction(int i)
        {
            return true;
        }
    }
}