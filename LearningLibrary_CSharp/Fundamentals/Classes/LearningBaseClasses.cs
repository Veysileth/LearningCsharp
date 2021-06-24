using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCsharpLibrary.Fundamentals.Classes.Utensils;

namespace LearningCsharpLibrary.Fundamentals.Classes
{
    public class LearningBaseClasses : DerivativeClass, IDemo, INotable
    {
        public string Note { get; } = "represent an \"is -a\" relationship. E.g. a dog or a cat \"is-a\" pet. This relationship always represents the (single) purpose of the class (in conjunction with the \"single responsibility principle\").";

        public LearningBaseClasses(int id, string name) : base(id, name)
        {
        }

        private void LearningAs()
        {
            var asValue = this as DerivativeClass;
        }

        private void LearningIs()
        {
            if (this is IDemo) { }
        }

        private void LearningIsWithPattern()
        {
            if (this is IDemo demo && demo.ToString() == "test") { }

            string test = "";
            if (test is string)

                switch (this)
                {
                    case DerivativeClass derivativeClass when derivativeClass.Id == 1:

                        break;
                }
        }

        public void Demo()
        {
            throw new NotImplementedException();
        }
    }
}