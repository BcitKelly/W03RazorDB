namespace W03RazorDB.Models.CompanyDB;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public partial class Employee
{
    [Display(Name = "ID")]
    public int EmployeeId { get; set; }

    [Display(Name = "First Name")]
    [Required(ErrorMessage = "First Name is Mandatory.")]
    [MinLength(2)]
    [MaxLength(30)]
    public string FirstName { get; set; } = null!;

    [Display(Name = "Last Name")]
    [Required(ErrorMessage = "Last Name is Mandatory.")]
    [MinLength(2)]
    [MaxLength(30)]
    public string LastName { get; set; } = null!;

    public int? DepartmentId { get; set; }

    public virtual Department? Department { get; set; }
}
