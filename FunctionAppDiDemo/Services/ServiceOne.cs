using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionAppDiDemo.Services
{
    public class ServiceOne : IServiceOne
    {
        public string Execute()
        {
            return "This is a result of an injection";
        }
    }

    public interface IServiceOne
    {
        string Execute();
    }
}
