using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostSharpSample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var obj = new MyClass();
                obj.DoSomething("test AOP");
            }
            catch (Exception)
            {
            }
            Console.ReadKey();
        }

    }
}
