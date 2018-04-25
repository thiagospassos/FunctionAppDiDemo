using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using AzureFunctions.Autofac;
using FunctionAppDiDemo.Services;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace FunctionAppDiDemo
{
    [DependencyInjectionConfig(typeof(AutofacConfig))]
    public static class Function1
    {
        [FunctionName("Function1")]
        public static HttpResponseMessage Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req,
            TraceWriter log,
            [Inject] IServiceOne serviceOne)
        {
            return req.CreateResponse(HttpStatusCode.OK, serviceOne.Execute());
        }
    }
}
