using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Class
    {
        public int ClassId { get; set; }

        public int ClassTeacherId { get; set; }

        public virtual Teacher ClassTeacher { get; set; } = null!;

        public virtual ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
