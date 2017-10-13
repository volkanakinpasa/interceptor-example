using Autofac.Extras.DynamicProxy;
using System;
using System.Diagnostics;

namespace interceptor_example
{
    [Intercept(typeof(IMyInterceptor))]
    public class MyBusiness : IMyBusiness
    {
        public void MyMethod()
        {
            Debug.WriteLine("MyMethod has been called");
        }
    }
}
