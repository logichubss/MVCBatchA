using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class EmployeeController : Controller
    {
        // action method
        public IActionResult Index()
        {
            TempData["Id"]=1001;
            //int id = (int)TempData["Id"];
            return View();
        }


        public ViewResult About() 
        {
           int id=(int)TempData["Id"];
            TempData.Keep();
            return View();
        }

        public IActionResult Contact()
        {
            int id = (int)TempData["Id"];
            return View();
        }

        public IActionResult Services()
        {
            int id = (int)TempData["Id"];
            return View();
        }
    }
}
