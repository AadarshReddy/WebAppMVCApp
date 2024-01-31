using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        static List<Employee> employees = new List<Employee>()
        {
            new Employee{Id=1,Name="Sam",Designation="Manager",Salary=96000,DOJ = new DateTime(day:23,month:12,year:2012)},
            new Employee{Id=1,Name="Arsh",Designation="HR",Salary=85000,DOJ = new DateTime(day:12,month:11,year:2011)},
            new Employee{Id=1,Name="Vini",Designation="Tester",Salary=50000,DOJ = new DateTime(day:30,month:06,year:2022)},
            new Employee{Id=1,Name="Ritu",Designation="Developer",Salary=120000,DOJ = new DateTime(day:22,month:11,year:2012)},
            new Employee{Id=1,Name="Dini",Designation="Tester",Salary=50000,DOJ = new DateTime(day:01,month:05,year:2018)},
            new Employee{Id=1,Name="Sai",Designation="Manager",Salary=96000,DOJ = new DateTime(day:10,month:08,year:2019)},

        };
        public ActionResult Index()
        {
            return View(employees);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Employee());
        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if(ModelState.IsValid)
            {
                employees.Add(emp);
                return RedirectToAction("Index");

            }
            return View(emp);
        }
    }
}