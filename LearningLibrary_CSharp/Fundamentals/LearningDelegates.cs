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

        private Action action;
        private Action<int, float> actionIntFloat;

        private Func<bool> boolFunction;
        private Func<int, float, bool> boolFunctionIntFloat;

        public void Demo()
        {
            delegateFunction = MyFirstDelegateFunction;
            delegateFunction();

            delegateFunction = MySecondDelegateFunction;
            delegateFunction();

            delegateFunction = delegate () { Console.WriteLine("test1"); };
            delegateFunction();

            delegateFunction = () => { Console.WriteLine("test2"); };
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