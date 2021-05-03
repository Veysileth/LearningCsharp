using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Patterns.Design.Creational.FactoryMethod
{
    internal abstract class ItemFactory
    {
        protected abstract IItem MakeItem();

        public IItem CreateItem()
        {
            return this.MakeItem();
        }
    }
}