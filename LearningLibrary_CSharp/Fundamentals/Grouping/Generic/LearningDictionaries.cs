using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Fundamentals.Grouping.Generic
{
    public class LearningDictionaries : IDemo
    {
        private Dictionary<string, string> dictionary = new();

        public void Demo()
        {
            dictionary.Add("key", "value");
            try
            {
                dictionary.Add("key", "value");
            }
            catch (ArgumentException)
            {
                Console.WriteLine($"An element with Key = 'key' already exists");
            }
        }
    }
}