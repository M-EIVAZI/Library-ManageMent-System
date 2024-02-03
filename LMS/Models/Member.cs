using System;
using System.Collections.Generic;

namespace LMS.Models;

public partial class Member
{
    public int Memberid { get; set; }

    public string? Name { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public int? Fine { get; set; }

    public string? Password { get; set; }
    public string? Salt { get; set; }
    public List<Reports> Reports { get; set; } = new List<Reports>();
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
