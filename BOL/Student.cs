using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Student
    {
        public int RollNo { get; set; }

        public string? Name { get; set; }

        public int ClassId { get; set; }

        public int? Year { get; set; }

        public string Contact { get; set; } = null!;

        public string? Address { get; set; }

        public int? TotalMarks { get; set; }

        public Class? Class { get; set; }
    }
}
