using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCsharpLibrary.Patterns.Design.Structural.Composite.Storage;

namespace LearningCsharpLibrary.Patterns.Design.Structural.Composite
{
    public class LearningComposite : IDemo, IDesignPattern
    {
        public LevelScale UsageFrequency { get; } = LevelScale.MediumHigh;
        public LevelScale Hardness { get; } = LevelScale.Unknown;

        public void Demo()
        {
            IComponent hardDisk = new Leaf("Hard Disk", 2000);
            IComponent ram = new Leaf("RAM", 3000);
            IComponent cpu = new Leaf("CPU", 2000);
            IComponent mouse = new Leaf("Mouse", 2000);
            IComponent keyboard = new Leaf("Keyboard", 2000);

            Storage.Composite motherBoard = new("Peripherals");
            Storage.Composite cabinet = new("Cabinet");
            Storage.Composite peripherals = new("Peripherals");
            Storage.Composite computer = new("Computer");

            motherBoard.AddComponent(cpu);
            motherBoard.AddComponent(ram);

            cabinet.AddComponent(motherBoard);
            cabinet.AddComponent(hardDisk);

            peripherals.AddComponent(mouse);
            peripherals.AddComponent(keyboard);
            computer.AddComponent(cabinet);

            computer.AddComponent(peripherals);

            computer.DisplayPrice();
            Console.WriteLine();

            keyboard.DisplayPrice();
            Console.WriteLine();

            cabinet.DisplayPrice();
        }
    }
}