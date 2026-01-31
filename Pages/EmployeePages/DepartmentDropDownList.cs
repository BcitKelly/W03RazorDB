using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using W03RazorDB.Models.CompanyDB;
using System.Linq;


namespace W03RazorDB.Pages.EmployeePages
{
    public class DepartmentDropDownList :  PageModel
    {
        public SelectList? DepartmentNames { get; set; }

        public void PopulateDepartmentsDropDownList(CompanyContext context,
            object selectedDepartment = null)
        {

            var DepartmentQry = context.Departments.ToList();
            DepartmentNames = new SelectList(DepartmentQry,
                nameof(Department.DepartmentId),
                nameof(Department.DepartmentName),
                selectedDepartment);
        }
    }
}
