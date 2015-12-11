using Microsoft.AspNet.Builder;
using Microsoft.Extensions.Logging;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace HelloWeb.Controllers
{
    public class MyMvcController : Controller
    {
        public string Index()
        {
            return "ciao";
        }
    }
}