using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCsharpLibrary.Patterns.Design.Behavioral.Interpreter.Storage;

namespace LearningCsharpLibrary.Patterns.Design.Behavioral.Interpreter
{
    public class LearningInterpreter : IDemo, IDesignPattern
    {
        public static LevelScale UsageFrequency { get; } = LevelScale.Low;
        public static LevelScale Hardness { get; } = LevelScale.Unknown;

        public void Demo()
        {
            List<AbstractExpression> objExpressions = new List<AbstractExpression>();
            Context context = new Context(DateTime.Now);
            Console.WriteLine("Please select the Expression  : MM DD YYYY or YYYY MM DD or DD MM YYYY ");
            context.expression = Console.ReadLine();
            string[] strArray = context.expression.Split(' ');
            foreach (var item in strArray)
            {
                if (item == "DD")
                {
                    objExpressions.Add(new DayExpression());
                }
                else if (item == "MM")
                {
                    objExpressions.Add(new MonthExpression());
                }
                else if (item == "YYYY")
                {
                    objExpressions.Add(new YearExpression());
                }
            }
            objExpressions.Add(new SeparatorExpression());
            foreach (var obj in objExpressions)
            {
                obj.Evaluate(context);
            }
            Console.WriteLine(context.expression);
        }
    }
}