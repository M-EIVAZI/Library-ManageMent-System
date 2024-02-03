using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Models
{
    public class Reports
    {   public int ReportId { set; get; }
        public string Description { set; get; }
        public int BookId { get; set; }
        public int MemberId { get; set; }

        // Navigation properties for relationships (if applicable)
        public Book Book { get; set; }
        public Member Member { get; set; }
    }
}
