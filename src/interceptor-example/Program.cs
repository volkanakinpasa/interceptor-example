using Autofac;
using Autofac.Extras.DynamicProxy;
using System;

namespace interceptor_example
{
    class Program
    {
        static void Main(string[] args)
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<MyInterceptor>().As<IMyInterceptor>().SingleInstance();
            builder.RegisterType<MyBusiness>().As<IMyBusiness>().SingleInstance().EnableInterfaceInterceptors();
            IContainer container = builder.Build();

            IMyBusiness business = container.Resolve<IMyBusiness>();
            business.MyMethod();
            
        }
    }
}
