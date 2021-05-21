    using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using udemy_deneme1.Entities;
//using udemy_deneme1.Models;

namespace udemy_deneme1.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "hello from app1..";
        }

        public ViewResult Index2()
        {
            return View();
        }

        public ViewResult Index3()
        {
            List<Employee> emp = new List<Employee>
            {
                new Employee{ Id=1, Name="serhat", Surname="bastas", Number=123456 },
                new Employee{ Id=2, Name="serhat2", Surname="bastas2", Number=1234561233 },
                new Employee{ Id=3, Name="serhat3", Surname="bastas3", Number=1234561233 }
            };
            List<string> cities = new List<string> { "Istanbul", "Ankara" };

            var model = new EmployeeListViewModel
            {
                Employee = emp,
                Cities = cities
            };
            return View(model);
        }

        public IActionResult Index4()
        {
            return Ok();
        }

        public IActionResult Index5()
        {
            return NotFound() ;
        }

        public RedirectResult Index6()
        {
            return Redirect("/Home/index2");
        }

        public IActionResult Index7()
        {
            return RedirectToAction("Index3");
        }

        public IActionResult Index8()
        {
            return RedirectToRoute("default");
        }
        public JsonResult Index9()
        {
            List<Employee> emp = new List<Employee>
            {
                new Employee{ Id=1, Name="serhat", Surname="bastas", Number=123456 },
                new Employee{ Id=2, Name="ali", Surname="asda", Number=1234561233 },
                new Employee{ Id=3, Name="mehmet", Surname="gfsfw", Number=1234561233 }
            };
            return Json(emp);    
        }

        public IActionResult RazorDemo()
        {
            List<Employee> emp = new List<Employee>
            {
                new Employee{ Id=1, Name="serhat", Surname="bastas", Number=123456 },
                new Employee{ Id=2, Name="serhat2", Surname="bastas2", Number=1234561233 },
                new Employee{ Id=3, Name="serhat3", Surname="bastas3", Number=1234561233 }
            };
            List<string> cities = new List<string> { "Istanbul", "Ankara" };

            var model = new EmployeeListViewModel
            {
                Employee = emp,
                Cities = cities
            };
            return View(model);
        }
        public JsonResult Index10(string key)
        {
            List<Employee> emp = new List<Employee>
            {
                new Employee{ Id=1, Name="serhat", Surname="bastas", Number=123456 },
                new Employee{ Id=2, Name="ali", Surname="asda", Number=1234561233 },
                new Employee{ Id=3, Name="mehmet", Surname="gfsfw", Number=1234561233 }
            };

            if (String.IsNullOrEmpty(key))
            {
                return Json(emp);
            }
            var result = emp.Where(e=>e.Name.ToLower().Contains(key));
            return Json(result);
        }

        
        public ViewResult EmployeeForm(String key)
        {
            return View();
        }

        public string RouteData(int id)
        {
            return id.ToString();
        }
       
    }
}
