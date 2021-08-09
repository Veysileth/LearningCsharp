using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Advanced.AsynchronousProgramming
{
    public class LearningTPL : IDemo
    {
        /*
         *  Task Parallel Library
         */

        public void Demo()
        {
            DoTaskExample();
        }

        private void DoTaskExample()
        {
            const int repetitions = 1000;

            Task task = Task.Run(() =>
            {
                for (int i = 0; i < repetitions; i++)
                {
                    Console.WriteLine("-");
                }
            });

            for (int i = 0; i < repetitions; i++)
            {
                Console.WriteLine("+");
            }

            task.Wait();
        }

        private void DoTaskWithReturnExample()
        {
            const int repetitions = 1000;

            Task<string> task = Task.Run<string>(() =>
            {
                for (int i = 0; i < repetitions; i++)
                {
                    Console.WriteLine("-");
                }
                return "returned";
            });

            for (int i = 0; i < repetitions; i++)
            {
                Console.WriteLine("+");
            }

            task.Wait();
        }

        private void DoTasksContinueWithExample()
        {
            Console.WriteLine("Start");

            Action actionA = () =>
            {
                Console.WriteLine("Continuing with actionA");
            };

            Action actionB = () =>
            {
                Console.WriteLine("Continuing with actionB");
            };

            Action actionC = () =>
            {
                Console.WriteLine("Continuing with actionC");
            };

            Task taskA = Task.Run(() => { Console.WriteLine("Starting taskA"); })
                .ContinueWith(cont => Console.WriteLine("Continuation"));
        }
    }
}