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
        private string _Name = "";
        public string Name { get { return _Name; } set { _Name = value; } }

        private int _Number;

        public int Number
        {
            get { return _Number; }
            set { _Number = value; }
        }

        public LearningClasses(string name, int number)
        {
            _Name = name;
            _Number = number;
        }

        ~LearningClasses()
        {
            //finalizator
            Console.WriteLine("Learning Class Finalized");
        }

        public override int GetHashCode()
        {
            int hashCode = _Name.GetHashCode();
            hashCode ^= _Number.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            return $"Class with name: \"{_Name}\" and assigned number: \"{_Number}\"";
        }

        public static implicit operator LearningMethods(LearningClasses learningClass)
        {
            return new LearningMethods();
        }

        public static explicit operator LearningArrays(LearningClasses learningClass)
        {
            return (LearningArrays)new LearningClasses("", 0);
        }
    }
}