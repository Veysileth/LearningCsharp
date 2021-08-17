using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Patterns.Design.Behavioral.Observer.Storage
{
    public interface IObserver
    {
        void update(string availability);
    }
}