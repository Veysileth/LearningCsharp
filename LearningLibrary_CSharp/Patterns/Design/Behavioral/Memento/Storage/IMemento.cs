using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Patterns.Design.Behavioral.Memento.Storage
{
    public interface IMemento
    {
        string GetName();

        string GetState();

        DateTime GetDate();
    }
}