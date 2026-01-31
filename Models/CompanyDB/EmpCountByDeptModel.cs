namespace W03RazorDB.Models.CompanyDB;

public partial class EmpCountByDeptModel
{
    public int DepartmentId { get; set; }

    public string DepartmentName { get; set; } = null!;

    public int EmployeeCount { get; set; }
}
