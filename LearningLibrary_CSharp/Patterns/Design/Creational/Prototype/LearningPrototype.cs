using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Patterns.Design.Creational.Prototype
{
    public class LearningPrototype : IDemo
    {
        public void Demo()
        {
            ColorManager colormanager = new ColorManager();
            // Initialize with standard colors
            colormanager["red"] = new Color(255, 0, 0, new());
            colormanager["green"] = new Color(0, 255, 0, new());
            colormanager["blue"] = new Color(0, 0, 255, new());
            // User adds personalized colors
            colormanager["angry"] = new Color(255, 54, 0, new());
            colormanager["peace"] = new Color(128, 211, 128, new());
            colormanager["flame"] = new Color(211, 34, 20, new());
            // User clones selected colors
            Color color1 = colormanager["red"].Clone() as Color;
            Color color2 = colormanager["peace"].Clone() as Color;
            Color color3 = colormanager["flame"].Clone() as Color;
        }

        private abstract class ColorPrototype
        {
            public abstract ColorPrototype Clone();
        }

        private class Color : ColorPrototype
        {
            private int _Red;
            private int _Green;
            private int _Blue;
            private WeirdReferenceStuff _WeirdReferenceStuff;

            public Color(int red, int green, int blue, WeirdReferenceStuff weirdReferenceStuff)
            {
                this._Red = red;
                this._Green = green;
                this._Blue = blue;
                this._WeirdReferenceStuff = weirdReferenceStuff;
            }

            public override Color Clone()
            {
                Color color = (Color)this.MemberwiseClone();
                color._WeirdReferenceStuff = _WeirdReferenceStuff.Clone();
                return color;
            }
        }

        private class ColorManager
        {
            private Dictionary<string, ColorPrototype> colors =
            new Dictionary<string, ColorPrototype>();

            public ColorPrototype this[string key]
            {
                get { return colors[key]; }
                set { colors.Add(key, value); }
            }
        }

        private class WeirdReferenceStuff
        {
            private int a;
            private int b;
            private int c;

            public WeirdReferenceStuff Clone()
            {
                return this.MemberwiseClone() as WeirdReferenceStuff;
            }
        }
    }
}