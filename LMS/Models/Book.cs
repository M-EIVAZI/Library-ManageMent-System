using System;
using System.Collections.Generic;

namespace LMS.Models;

public partial class Book
{
    public int Bookid { get; set; }

    public string? Title { get; set; }

    public string? AuthorName { get; set; }

    public string? Isbn { get; set; }

    public string? Genre { get; set; }

    public DateOnly? PublishedDate { get; set; }

    public string? Format { get; set; }

    public string? FilePath { get; set; }
    public string? IsValid { set; get; }

    public virtual Author? AuthorNameNavigation { get; set; }

    public List<Reports> Reports { get; set; } = new List<Reports>();
    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
