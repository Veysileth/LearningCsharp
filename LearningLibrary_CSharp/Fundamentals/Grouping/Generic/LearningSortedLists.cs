using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Fundamentals.Grouping.Generic
{
    public class LearningSortedLists : IDemo
    {
        public void Demo()
        {
            SortedList<string, User> sortedList = new();
            sortedList.Add("a", new User() { Age = 1, Name = "Name1" });
            sortedList.Add("b", new User() { Age = 2, Name = "Name2" });
            sortedList.Add("c", new User() { Age = 3, Name = "Name3" });
        }

        public class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}