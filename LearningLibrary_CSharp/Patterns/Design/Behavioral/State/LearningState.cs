﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCsharpLibrary.Patterns.Design.Behavioral.State.Storage;

namespace LearningCsharpLibrary.Patterns.Design.Behavioral.State
{
    public class LearningState : IDemo
    {
        public void Demo()
        {
            var context = new Context(new ConcreteStateA());
            // Issue requests, which toggles state
            context.Request();
            context.Request();
            context.Request();
            context.Request();
        }
    }
}