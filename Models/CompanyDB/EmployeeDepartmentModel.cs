namespace W03RazorDB.Models.CompanyDB;

public partial class EmployeeDepartmentModel
{
    public int EmployeeId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public int? DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;
}