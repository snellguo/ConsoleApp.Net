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
        public int MyProperty { get; set; }
        public string MyValue;
        public int MyInt;

        public MyClass()
        {
            var type = Type.GetType($"{this.GetType().Namespace}.MyClass") ;

            //var someClass = Activator.CreateInstance(type) as OtherClass;
            //someClass.MyMethod();

            //type = type;

            //Console.WriteLine(type);    //ConsoleApp.Net.MyClass
            //Console.WriteLine(type.GetType());   //System.RuntimeType

            //Delegate.CreateDelegate(typeof(MyDelegate)
            //     , type.GetMethod("MyMethod"))
            //     .DynamicInvoke();

            /* 根据字符串名称获取MyDelegate
             * 看看Delegate
             */
            Delegate.CreateDelegate(
                typeof(MyDelegate)
               , type.GetMethod("MyMethod"))
               .DynamicInvoke();


        }
        public static void MyMethod()
        {

        }

    }
    public class OtherClass
    {
        public delegate void MyDelegate();
        
        public  void MyMethod() { }

    }
}
