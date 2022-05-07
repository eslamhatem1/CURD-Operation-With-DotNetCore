using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using taskdayone_Core_.Models;
using System.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace taskdayone_Core_.Controllers
{
    public class HomeController : Controller
    {
        Model context;
        public HomeController(Model _context)
        {
            this.context = _context; 
        }
        public IActionResult Index()
        {
            var element = context.Employees.Include(e => e.Department);
            return View(element);
        }

        [HttpGet]
        public IActionResult create()
        {
            ViewBag.dept = new SelectList(context.Departments, "departmentid", "deptname", 1);
            return View();
        }

        [HttpPost]
        public IActionResult create(employee emp)
        {
            context.Add(emp);
            context.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult edit(int id)
        {
            var element = context.Employees.SingleOrDefault(e => e.id == id);
           ViewBag.dept = new SelectList(context.Departments, "departmentid", "deptname", 1);
            return View(element);
        }


        [HttpPost]
        public IActionResult edit(employee emp)
        {
            context.Update(emp);
            context.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult detalies(int id)
        {
            var element = context.Employees.SingleOrDefault(e => e.id == id);
            ViewBag.dept = new SelectList(context.Departments, "departmentid", "deptname", 1);
            return View(element);
        }


        [HttpGet]
        public IActionResult delete(int id)
        {
            var element = context.Employees.SingleOrDefault(e => e.id == id);
            context.Employees.Remove(element);
            context.SaveChanges();
            return RedirectToAction("index");
        }

     

    }
}
