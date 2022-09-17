using Microsoft.AspNetCore.Mvc;

namespace Mvcapp.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        //public ViewResult Index()
        //{
        //    //return View("TempView/Tempview.cshtml");
        //    //return View("~/TempView/Tempview.cshtml");
        //    return View("../../TempView/Tempview");

        //}
        //public ViewResult Index()

        //{
        //    var obj =new { id = 1 , Name = "jaga"};
        //    return View( "AboutUS",obj);
        //}
        //public ViewResult Index()
        //{

        //    return View("AboutUS");
        //}
        public ViewResult AboutUS()
        {
            return View();
        }
        public ViewResult contactUS()
        {
            return View();
        }
    }
}

