using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using W03RazorDB.Models.CompanyDB;

namespace W03RazorDB.Pages.EmployeePages;

public class DeleteModel : DepartmentDropDownList
{
    private readonly CompanyContext _context;

    public DeleteModel(CompanyContext context)
    {
        _context = context;
    }

    [BindProperty]
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
            PopulateDepartmentsDropDownList(_context, employee.DepartmentId!);
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var employee = await _context.Employees.FindAsync(id);
        if (employee != null)
        {
            Employee = employee;
            _context.Employees.Remove(Employee);
            await _context.SaveChangesAsync();
        }

        return RedirectToPage("./Index");
    }
}
