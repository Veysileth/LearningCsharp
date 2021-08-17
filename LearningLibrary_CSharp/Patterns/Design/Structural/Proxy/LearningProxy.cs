using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningCsharpLibrary.Patterns.Design.Structural.Proxy.Storage;

namespace LearningCsharpLibrary.Patterns.Design.Structural.Proxy
{
    public class LearningProxy : IDemo
    {
        public void Demo()
        {
            Client client = new Client();

            Console.WriteLine("Client: Executing the client code with a real subject:");
            RealSubject realSubject = new();
            client.ClientCode(realSubject);

            Console.WriteLine();

            Console.WriteLine("Client: Executing the same client code with a proxy:");
            Storage.Proxy proxy = new(realSubject);
            client.ClientCode(proxy);
        }

        public class Client
        {
            // The client code is supposed to work with all objects (both subjects
            // and proxies) via the Subject interface in order to support both real
            // subjects and proxies. In real life, however, clients mostly work with
            // their real subjects directly. In this case, to implement the pattern
            // more easily, you can extend your proxy from the real subject's class.
            public void ClientCode(ISubject subject)
            {
                // ...

                subject.Request();

                // ...
            }
        }
    }
}