using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using W03RazorDB.Models.CompanyDB;


namespace W03RazorDB.Pages.DepartmentPages;

public class DetailsModel : PageModel
{
    private readonly CompanyContext _context;
    public DetailsModel(CompanyContext context)
    {
        _context = context;
    }

    public Department Department { get; set; } = default!;

    public async Task<IActionResult> OnGetAsync(int? id)
    {
        if (id is null)
        {
            return NotFound();
        }

        var department = await _context.Departments.FirstOrDefaultAsync(m => m.DepartmentId == id);
        if (department is null)
        {
            return NotFound();
        }
        else
        {
            Department = department;
        }

        return Page();
    }
}
