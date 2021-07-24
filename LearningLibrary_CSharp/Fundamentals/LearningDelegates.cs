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

        private Delegate _delegateFunction;
        private BoolDelegate _boolDelegateFunction;
        private BoolDelegateWithArg _boolDelegateWithArgFunction;

        private Action _action;
        private Action<int, float> _actionIntFloat;

        private Func<bool> _boolFunction;
        private Func<int, float, bool> _boolFunctionIntFloat;

        public void Demo()
        {
            _delegateFunction = MyFirstDelegateFunction;
            _delegateFunction();

            _delegateFunction += MySecondDelegateFunction;
            _delegateFunction();

            _delegateFunction += delegate () { Console.WriteLine("test1"); };
            _delegateFunction();

            _delegateFunction += () => { Console.WriteLine("test2"); };
            _delegateFunction();

            //Bezpieczne z uwagi na wielowątkowość
            var action = _action;

            //W normalnej sytuacji zwrócenie wyjątku przerywa wykonywanie funkcji pozostałych subskrybentów.
            foreach (Action handler in action.GetInvocationList())
            {
                try
                {
                    handler();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            _boolDelegateFunction = MyFirstBoolDelegateFunction;
            _ = _boolDelegateFunction();

            _boolDelegateFunction = MySecondBoolDelegateFunction;
            _ = _boolDelegateFunction();

            _boolDelegateWithArgFunction = MyFirstBoolDelegateWithArgFunction;
            _ = _boolDelegateWithArgFunction(1);

            _boolDelegateWithArgFunction = MySecondBoolDelegateWithArgFunction;
            _ = _boolDelegateWithArgFunction(2);
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