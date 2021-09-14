using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Fundamentals
{
    // UNDONE: Placeholder - fill as learn
    public class LearningEvents : IDemo, INotable
    {
        public string Note { get; } = "";

        private event EventHandler OnTest;

        private event EventHandler<CustomEventArgs> OnTestCustomEventArgs;

        private event EventHandler<CustomEventArgs> _OnTestCustomEventArgsWithAddAndRemove;

        public event EventHandler<CustomEventArgs> OnTestCustomEventArgsWithAddAndRemove
        {
            add
            {
                _OnTestCustomEventArgsWithAddAndRemove = (EventHandler<CustomEventArgs>)System.Delegate.Combine(value, _OnTestCustomEventArgsWithAddAndRemove);
            }
            remove
            {
                _OnTestCustomEventArgsWithAddAndRemove = (EventHandler<CustomEventArgs>)System.Delegate.Remove(value, _OnTestCustomEventArgsWithAddAndRemove);
            }
        }

        public class CustomEventArgs : EventArgs
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