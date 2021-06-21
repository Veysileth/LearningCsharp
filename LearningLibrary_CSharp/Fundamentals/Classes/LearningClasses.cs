using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCsharpLibrary.Fundamentals.Grouping;

namespace LearningCsharpLibrary.Fundamentals.Classes
{
    public class LearningClasses
    {
        private string _Name;
        public string Name { get { return _Name; } set { _Name = value; } }

        private int _Test;

        public int Test
        {
            get { return _Test; }
            set { _Test = value; }
        }

        public static implicit operator LearningMethods(LearningClasses learningClass)
        {
            return new LearningMethods();
        }

        public static explicit operator LearningArrays(LearningClasses learningClass)
        {
            return (LearningArrays)new LearningClasses();
        }
    }
}