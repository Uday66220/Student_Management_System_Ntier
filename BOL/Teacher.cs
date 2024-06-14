using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        public string Name { get; set; } = null!;

        public string? Contact { get; set; }

        public string? Address { get; set; }

        public virtual ICollection<Class> Classes { get; set; } = new List<Class>();
    }
}
