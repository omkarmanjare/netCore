using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeManagement.Models;
using EmployeeManagement.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace EmployeeManagement.Controllers
{
    [Route("Home")]
    //[Route("[controller]/[action]")]  << this can be uvsed by removing [Route("{action}")] 
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        //[Route("")]   //this is incase we request url dont have controller and action
        //[Route("/Home")]  //this is incase if request url has controller , then execute this action
        //[Route("/Home/Index")] //this is incase if request url  have controller and action
        //After adding route attribute, there is no need to have Controller class name name same as mentioned in attribute. e.g. here if we change class name to HomeController123 and action name to Index123,
        //it will still execute  this method if request url matches with route
        //If we want to skip adding "/Home" to every action method we can add it to the controller class name like at no.12 and remove it from attribute at action method level

        [Route("")]   //this is incase we request url dont have controller and action
        [Route("~/")] //this is incase we request url dont have controller and action . e.g.  localhost:500 and no other  controller and action method
        [Route("Index")]  //this is incase if request url has controller , then execute this action
        //[Route("/Home/Index")] //this is incase if request url  have controller and action

        //[Route("{action}")] << this way we can remove [Route("Index")] attribute 
        public ViewResult Index()
        {
            return View(_employeeRepository.GetAllEmployees());
        }

        [Route("/Home/Details/{id?}")]
        public ViewResult Details(int? id)
        {
           
            Employee employee = _employeeRepository.GetEmployee( id??1);
            ViewData["Employee"] = employee;
            ViewData["PageTitle"] = "Emmployee Details";

            ViewBag.Employee = employee;
            ViewBag.PageTitle = "Emmployee Details";

            return View(employee); // we can also pass explicit view name here to call.
        }
        public ViewResult HomeDetails()
        {
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(2),
                PageTitle = "Emmployee Details"
            };           

            return View(homeDetailsViewModel); // we can also pass explicit view name here to call.
        }
        public ViewResult Create()
        {
            return View();
        }
    }
}