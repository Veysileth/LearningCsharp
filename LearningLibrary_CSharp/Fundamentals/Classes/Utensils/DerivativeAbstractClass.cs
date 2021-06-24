using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Fundamentals.Classes.Utensils
{
    public abstract class DerivativeAbstractClass
    {
        public virtual string Name { get; set; }

        public DerivativeAbstractClass(string name)
        {
            Name = name;
        }

        public abstract string GetSummary();
    }
}