using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace ASP_MVC5_CRUD_Employees.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string EmployeeName { get; set; }

        [StringLength(20, MinimumLength = 3)]
        [Required]
        public string Designation { get; set; }

        [Range(1000,5000)]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        public DateTime CreateDate { get; set; }
    }

    public class EmployeeDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}