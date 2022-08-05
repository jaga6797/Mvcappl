using Microsoft.AspNetCore.Mvc;

namespace Mvcapp.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Good Morning";
        }
    }
}

