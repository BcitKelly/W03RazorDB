using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using W03RazorDB.Models.CompanyDB;

namespace W03RazorDB.Pages.EmployeePages;

public class DetailsModel : DepartmentDropDownList
{
    private readonly CompanyContext _context;
    public DetailsModel(CompanyContext context)
    {
        _context = context;
    }

    public Employee Employee { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var employee = await _context.Employees.FirstOrDefaultAsync(m => m.EmployeeId == id);
        if (employee is null)
        {
            return NotFound();
        }
        else
        {
            Employee = employee;
        }

        PopulateDepartmentsDropDownList(_context, employee.DepartmentId!);
        return Page();
    }
}
