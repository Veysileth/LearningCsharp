using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharpLibrary.Fundamentals
{
    // TODO: Get into it
    // INFO: https://stackoverflow.com/questions/3565481/differences-between-expandoobject-dynamicobject-and-dynamic
    public class LearningDynamic : IDemo
    {
        public void Demo() { }

        private class MyOwnCustomDynamicType : DynamicObject
        {
            Dictionary<string, object> properties = new Dictionary<string, object>();

            public override bool TryGetMember(GetMemberBinder binder, out object result)
            {
                if (properties.ContainsKey(binder.Name))
                {
                    result = properties[binder.Name];
                    return true;
                }
                else
                {
                    result = "I'm sorry, there are no cookies in this jar!";
                    return false;
                }
            }

            public override bool TrySetMember(SetMemberBinder binder, object value)
            {
                properties[binder.Name] = value;
                return true;
            }

            public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
            {
                dynamic method = properties[binder.Name];
                result = method(args[0].ToString(), args[1].ToString());
                return true;
            }
        }

        public void DynamicKeyword()
        {
            dynamic runtimeBinding = new object();
            //runtimeBinding.ItWillTriggerRuntimeBinderException();

            dynamic customDynamic = new MyOwnCustomDynamicType();
            customDynamic.FieldThatDoesntExist();
        }
    }
}
