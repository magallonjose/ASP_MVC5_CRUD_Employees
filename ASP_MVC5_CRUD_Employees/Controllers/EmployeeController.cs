using ASP_MVC5_CRUD_Employees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;

namespace ASP_MVC5_CRUD_Employees.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeDBContext db = new EmployeeDBContext();

        // GET: Employee
        public ActionResult Index()
        {
            Employee emp = new Employee();
            emp.EmployeeID = 1;
            emp.EmployeeName = "José Magallón";
            emp.Designation = "Developer";
            emp.Salary = 1000;
            emp.CreateDate = DateTime.Now;

            List<Employee> lstEmployee = new List<Employee>();
            lstEmployee.Add(emp);
            return View(lstEmployee);
        }

        public string HelloAdmin (int Id, string name)
        {
            return HttpUtility.HtmlEncode("Roll No. " + Id + ", Employee Name: " + name);
        }

        public string Hello()
        {
            return "Hola Mundo";
        }
    }
}