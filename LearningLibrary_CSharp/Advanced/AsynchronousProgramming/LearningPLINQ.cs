using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Advanced.AsynchronousProgramming
{
    internal class LearningPLINQ : IDemo
    {
        public void Demo()
        {
            throw new NotImplementedException();
        }

        private void DoAsParallelExample()
        {
            List<string> list = new() { "a", "b"};
            _ = list.AsParallel().Select(prop => prop.Length > 0);
        }
    }
}