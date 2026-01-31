using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using W03RazorDB.Models.CompanyDB;

namespace W03RazorDB.Pages.EmployeePages;

public class CreateModel : DepartmentDropDownList
{
    private readonly CompanyContext _context;

    public CreateModel(CompanyContext context)
    {
        _context = context;
    }

    public IActionResult OnGet()
    {
        PopulateDepartmentsDropDownList(_context);
        return Page();
    }


    [BindProperty]
    public Employee Employee { get; set; } = default!;

    // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD.
    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Employees.Add(Employee);
        await _context.SaveChangesAsync();

        return RedirectToPage("./Index");
    }
}
