using Castle.DynamicProxy;
using System.Diagnostics;

namespace interceptor_example
{
    public class MyInterceptor : IMyInterceptor, IInterceptor
    {
        public MyInterceptor()
        {
        }

        public void Intercept(IInvocation invocation)
        {
            //todo: before
            Debug.WriteLine("Intercept started");
            invocation.Proceed();
            Debug.WriteLine("Intercept ended");
            //todo: after
        }
    }
}