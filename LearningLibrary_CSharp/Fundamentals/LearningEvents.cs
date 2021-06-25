using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Fundamentals
{
    public class LearningEvents : IDemo, INotable
    {
        public string Note { get; } = "";

        private event EventHandler OnTest;

        private event EventHandler<CustomEventArgs> OnTestCustomEventArgs;

        private class CustomEventArgs : EventArgs
        {
            public string Name { get; set; }
        }

        private void Start()
        {
            OnTest += LearningEvents_OnTest1;
            OnTest += LearningEvents_OnTest2;
            OnTestCustomEventArgs += LearningEvents_OnTestCustomEventArgs;
        }

        private void LearningEvents_OnTestCustomEventArgs(object sender, CustomEventArgs e)
        {
        }

        private void LearningEvents_OnTest1(object sender, EventArgs e)
        {
        }

        private void LearningEvents_OnTest2(object sender, EventArgs e)
        {
        }

        private void Update()
        {
            if (true == true)
            {
                OnTest?.Invoke(this, EventArgs.Empty);
                OnTestCustomEventArgs?.Invoke(this, new CustomEventArgs { Name = "test" });
            }
        }

        public void Demo()
        {
            Start();
            Update();
        }
    }
}