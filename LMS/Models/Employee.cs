using System;
using System.Collections.Generic;

namespace LMS.Models;

public partial class Employee
{
    public int Employeeid { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? Password { get; set; }
    public string? Salt { get;set; }
}
