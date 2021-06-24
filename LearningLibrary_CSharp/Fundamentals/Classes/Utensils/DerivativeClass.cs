using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Fundamentals.Classes.Utensils
{
    public class DerivativeClass : DerivativeCtorClass
    {
        public DerivativeClass(int id, string name) : base(id, name)
        {
        }

        public override string VirtualValue { get => base.VirtualValue; set => base.VirtualValue = value; }
    }
}