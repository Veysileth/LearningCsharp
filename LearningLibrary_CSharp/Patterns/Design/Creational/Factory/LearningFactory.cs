using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Patterns.Design.Creational.Factory
{
    public class LearningFactory : IDemo, IDesignPattern
    {
        public LevelScale UsageFrequency { get; } = LevelScale.High;
        public LevelScale Hardness { get; } = LevelScale.Unknown;

        public void Demo()
        {
            var item1 = ItemFactory.GetItem(ItemType.ItemType1);
            var item2 = ItemFactory.GetItem(ItemType.ItemType2);
            var item3 = ItemFactory.GetItem(ItemType.ItemType3);
        }
    }
}