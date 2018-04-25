using Autofac;
using AzureFunctions.Autofac.Configuration;
using FunctionAppDiDemo.Services;

namespace FunctionAppDiDemo
{
    public class AutofacConfig
    {
        public AutofacConfig()
        {
            DependencyInjection.Initialize(builder =>
            {
                builder.RegisterType<ServiceOne>().As<IServiceOne>();
            });

        }
    }
}