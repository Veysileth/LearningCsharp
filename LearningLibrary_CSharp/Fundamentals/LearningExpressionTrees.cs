using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Fundamentals
{
    // UNDONE: Placeholder - fill as learn
    public class LearningExpressionTrees : INotable, IDemo
    {
        public string Note { get; } =
        @"Represents a strongly typed lambda expression as a data structure in the form of an expression tree.
        https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/expression-trees/";

        public void Demo()
        {
            Func<int, bool> deleg = i => i < 5;
            Console.WriteLine("deleg(4) = {0}", deleg(4));

            Expression<Func<int, bool>> expr = i => i < 5;

            Func<int, bool> deleg2 = expr.Compile();
            Console.WriteLine("deleg2(4) = {0}", deleg2(4));
        }
    }
}