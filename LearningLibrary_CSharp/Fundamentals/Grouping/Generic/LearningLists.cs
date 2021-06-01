using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Fundamentals.Grouping.Generic
{
    internal class LearningLists
    {
        private List<Galaxy> _galaxies = new()
        {
            new Galaxy() { Name = "Tadpole", MegaLightYears = 400 },
            new Galaxy() { Name = "Pinwheel", MegaLightYears = 25 },
            new Galaxy() { Name = "Milky Way", MegaLightYears = 0 },
            new Galaxy() { Name = "Andromeda", MegaLightYears = 3 }
        };

        public void Demo()
        {
            Galaxy galaxy = new () { Name = "Test Galaxy", MegaLightYears = 6969};
            _galaxies.Add(galaxy);
            _galaxies.Remove(galaxy);

            _galaxies.Insert(0, galaxy);
            _galaxies.Add(new Galaxy() { Name = "Test Galaxy 2", MegaLightYears = 1347 });

            _galaxies.RemoveAll(galaxy =>
            {
                return galaxy.Name.StartsWith("Test");
            });

            _galaxies.Sort();
            _galaxies.Sort(delegate (Galaxy x, Galaxy y)
            {
                if (x.Name == null && y.Name == null) return 0;
                else if (x.Name == null) return -1;
                else if (y.Name == null) return 1;
                else return x.Name.CompareTo(y.Name);
            });

            foreach (Galaxy theGalaxy in _galaxies)
            {
                Console.WriteLine($"{theGalaxy.Name} {theGalaxy.MegaLightYears}");
            }
        }

        private class Galaxy
        {
            public string Name { get; set; }
            public int MegaLightYears { get; set; }
        }
    }
}