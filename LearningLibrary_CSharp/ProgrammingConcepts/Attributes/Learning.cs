using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.ProgrammingConcepts.Attributes
{
    internal class Learning
    {
        public void Demo()
        {
            ClassWithCustomAttribute classWithCustomAttribute = new ();
            PrintCustomAttributeInfo(typeof(ClassWithCustomAttribute));
        }

        [System.AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = false)]
        private class CustomAttribute : Attribute
        {
            private string _name;
            public double version;

            public CustomAttribute(string name)
            {
                _name = name;
                version = 1.0;
            }

            public string GetName()
            {
                return _name;
            }
        }

        private void PrintCustomAttributeInfo(Type type)
        {
            System.Attribute[] attrs = System.Attribute.GetCustomAttributes(type);  // Reflection.

            // Displaying output.
            foreach (Attribute attr in attrs)
            {
                if (attr is CustomAttribute)
                {
                    CustomAttribute a = (CustomAttribute)attr;
                    System.Console.WriteLine("   {0}, version {1:f}", a.GetName(), a.version);
                }
            }
        }

        [CustomAttribute("Name", version = 1.0)]
        private class ClassWithCustomAttribute
        {
            private CustomAttribute GetAttribute()
            {
                CustomAttribute MyAttribute = (CustomAttribute)Attribute.GetCustomAttribute(typeof(ClassWithCustomAttribute), typeof(CustomAttribute));

                if (MyAttribute == null)
                {
                    Console.WriteLine("The attribute was not found.");
                    return null;
                }

                return MyAttribute;
            }
        }
    }