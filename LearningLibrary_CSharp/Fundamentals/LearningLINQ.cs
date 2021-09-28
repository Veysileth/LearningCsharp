using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Fundamentals
{
    // UNDONE: Placeholder - fill as learn
    internal class LearningLINQ : IDemo, INotable
    {
        public string Note { get; }

        private List<string> _List = new() {"a", "b", "c"};

        public void Demo()
        {
        }

        public void Example1()
        {
            string[] words = { "a", "b" };
            var vs = from word in words
                                     let length = word.Length
                                     where length > 2
                                     orderby word
                                     //select word.ToUpper();
                                     select new { word, word.Length };
        }

        public void Example2()
        {
            Dictionary<string, ConsoleColor> colorMap = new()
            {
                ["Error"] = ConsoleColor.Red,
                ["Warning"] = ConsoleColor.Yellow,
                ["Information"] = ConsoleColor.Green,
                ["Verbose"] = ConsoleColor.White,
            };

            var val = colorMap.FirstOrDefault(prop => prop.Value == ConsoleColor.Green);
        }


        private void Print<T>(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}