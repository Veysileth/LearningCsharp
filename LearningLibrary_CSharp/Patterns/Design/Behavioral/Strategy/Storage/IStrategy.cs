using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Patterns.Design.Behavioral.Strategy.Storage
{
    public interface IStrategy
    {
        object DoAlgorithm(object data);
    }
}