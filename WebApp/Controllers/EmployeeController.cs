using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class EmployeeController : Controller
    {
        // action method
        public ViewResult Index()
        {
            List<Employee> myEmployees = new List<Employee>()
            {
               new Employee{ Id=101,Name="Adil",Email="adil@logichubss.com",Salary=50000},
               new Employee{ Id=102,Name="Rizwan",Email="Rizwan@logichubss.com",Salary=50000},
               new Employee{ Id=103,Name="Mehran",Email="Mehran@logichubss.com",Salary=50000},
               new Employee{ Id=104,Name="Aqib",Email="Aqib@logichubss.com",Salary=50000},
               new Employee{ Id=105,Name="Irfan",Email="Irfan@logichubss.com",Salary=50000},
            };

            List<string> players = new List<string>();
            players.Add("hazim");
            players.Add("abid");
            players.Add("aqib");
            players.Add("aqib");
            players.Add("aqib");

            //ViewData["welcome"]="Welcome to logichub";
            //ViewData["players"]=players;
            //ViewData["salary"]=80000;

            ViewBag.Welcome="Welcome to logichub";
            ViewBag.Salary=80000;
            ViewBag.Players=players;
            ViewBag.Employees=myEmployees;

            return View();
        }


        public ViewResult About() 
        {
            var myview = View();
            return myview;
        }
    }
}
