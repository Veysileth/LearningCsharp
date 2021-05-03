using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Patterns.Design.Creational.FactoryMethod
{
    internal class Item3Factory : ItemFactory
    {
        protected override IItem MakeItem()
        {
            return new Item3();
        }
    }
}