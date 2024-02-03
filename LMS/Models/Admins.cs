using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Models
{
    public class Admins
    {   public int AdminId {  get; set; }
        public string? Name { get; set; }
        public string? password {  get; set; }
        public string salt { get; set; }
        public string? Email { get; set; }

    }
}
