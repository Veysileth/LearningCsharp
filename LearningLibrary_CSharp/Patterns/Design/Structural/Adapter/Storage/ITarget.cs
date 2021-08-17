using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Patterns.Design.Structural.Adapter.Storage
{
    public interface ITarget
    {
        void ProcessCompanySalary(string[,] employeesArray);
    }
}