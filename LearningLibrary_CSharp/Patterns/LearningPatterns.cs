using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Patterns
{
    public static class LearningPatterns
    {
        public static void PrintAllPatterns()
        {
            var designPatternInterfaceType = typeof(IDesignPattern);

            var assembly = AppDomain.CurrentDomain.GetAssemblies().FirstOrDefault(ass => ass.FullName.Contains(nameof(LearningCsharpLibrary)));
            if (assembly is null) { Console.WriteLine("Error getting assembly"); return; }
            Console.WriteLine($"Current assembly: {assembly}");

            var classesWithDesignPatternInterface = assembly.GetTypes()
                    .Where(prop => prop.IsClass)
                    .Where(prop => prop.GetInterfaces().Contains(designPatternInterfaceType));

            foreach (var item in classesWithDesignPatternInterface)
            {
                Type designPatternInterface = item.GetInterface(nameof(IDesignPattern));
                if (designPatternInterface is null) { Console.WriteLine("No interface"); continue; }

                var interfaceProperties = designPatternInterface.GetProperties();
                foreach (var property in interfaceProperties)
                {
                    var a = property.GetValue(designPatternInterface);

                    var b = LearningCsharpLibrary.Patterns.Design.Behavioral.Command.LearningCommand.UsageFrequency;
                    Console.WriteLine(b);

                    Console.WriteLine($"{item.Name}: {property.Name} {a}");
                }
            }
        }
    }
}