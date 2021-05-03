using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Patterns.Design.Creational.Factory
{
    internal class ItemFactory
    {
        public static IItem GetItem(ItemType type)
        {
            return type switch
            {
                ItemType.ItemType1 => new Item1(),
                ItemType.ItemType2 => new Item2(),
                ItemType.ItemType3 => new Item3(),
                _ => null,
            };
        }
    }
}