using PostSharp.Aspects;
using PostSharp.Extensibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostSharpSample
{
    [Serializable]
    [MulticastAttributeUsage(MulticastTargets.Method, TargetExternalMemberAttributes = MulticastAttributes.Instance)]
    public class LoggingAspect : OnMethodBoundaryAspect
    {

        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine("On Entry");
        }


        public override void OnExit(MethodExecutionArgs args)
        {
            Console.WriteLine("On Exit");
        }

        public override void OnException(MethodExecutionArgs args)
        {
            Console.WriteLine("On Exception");
        }

        public override void OnSuccess(MethodExecutionArgs args)
        {
            Console.WriteLine("On Success");
        }
    }
}
