using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Fundamentals
{
    public class LearningWeakReferences
    {
        private LearningWeakReferences _LearningWeakReferences = new();
        private WeakReference<LearningWeakReferences> data1;

        private WeakReference data2;

        private void GetData()
        {
            data1.SetTarget(_LearningWeakReferences);
            if (data1.TryGetTarget(out _LearningWeakReferences)) { } else { _LearningWeakReferences = new(); }

            _LearningWeakReferences = (LearningWeakReferences)data2.Target;
        }
    }
}