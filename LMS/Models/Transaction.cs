using System;
using System.Collections.Generic;

namespace LMS.Models;

public partial class Transaction
{
    public int Transactionid { get; set; }

    public int? Memberid { get; set; }

    public int? Bookid { get; set; }

    public DateOnly? BorrowDate { get; set; }

    public DateOnly? ReturnDate { get; set; }

    public string? Status { get; set; }
    public string? UserVeiw { set; get; }

    public virtual Book? Book { get; set; }

    public virtual Member? Member { get; set; }
}
