using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostSharpSample
{
    public class MyClass
    {
        //[LoggingAspect]
        public void DoSomething(string param1)
        {
            Console.WriteLine(param1);
        }
    }
}
