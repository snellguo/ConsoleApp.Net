using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp.Net
{
    public class MyClass
    {
        public delegate void MyDelegate();

        public MyClass()
        {
            var type = Type.GetType($"{this.GetType().Namespace}.OtherClass");



            //Delegate.CreateDelegate(typeof(MyDelegate)
            //     , type.GetMethod("Show"))
            //     .DynamicInvoke();

            var someClass = Activator.CreateInstance(type);
            var otherClass = someClass as OtherClass;
            otherClass.MyMethod();


        }
        public void Show()
        {

        }

    }
    public class OtherClass
    {
        public delegate void MyDelegate();
        
        public void MyMethod() { }

    }
}
