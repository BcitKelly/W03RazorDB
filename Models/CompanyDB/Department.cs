namespace W03RazorDB.Models.CompanyDB;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public partial class Department
{
    [Display(Name = "ID")]
    public int DepartmentId { get; set; }

    [Display(Name = "Department")]
    [Required]
    [MinLength(3)]
    [MaxLength(30)]
    public string DepartmentName { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
