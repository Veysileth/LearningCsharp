using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCsharpLibrary.Patterns.Design.Structural.Facade.Storage;

namespace LearningCsharpLibrary.Patterns.Design.Structural.Facade
{
    public class LearningFacade : IDemo
    {
        public void Demo()
        {
            Order order = new Order();
            order.PlaceOrder();
        }
    }
}