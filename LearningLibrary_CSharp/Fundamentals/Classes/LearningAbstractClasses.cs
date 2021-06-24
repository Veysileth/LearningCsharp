using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCsharpLibrary.Fundamentals.Classes.Utensils;

namespace LearningCsharpLibrary.Fundamentals.Classes
{
    public class LearningAbstractClasses : DerivativeAbstractClass
    {
        public LearningAbstractClasses(string name) : base(name)
        {
        }

        public override string GetSummary()
        {
            throw new NotImplementedException();
        }
    }
}