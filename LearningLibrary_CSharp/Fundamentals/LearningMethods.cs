using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Fundamentals
{
    public class LearningMethods : IDemo
    {
        public LearningMethods()
        {
            //ctor
            SimpleMethod("stringarg");
            int returnedInteger = SimpleMethodWithReturnIntegerValue();
        }

        public void Demo()
        {
            throw new NotImplementedException();
        }

        private void SimpleMethod(string stringArg)
        {
        }

        private int SimpleMethodWithReturnIntegerValue()
        {
            return 0;
        }
    }
}