﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Fundamentals
{
    // UNDONE: Placeholder - fill as learn
    public class LearningTuples : IDemo
    {
        public void Demo()
        {
            Tuple<int, string> typicalTuple = new (1, "a");
            var methodTuple = Tuple.Create(1, "a");
        }
    }
}