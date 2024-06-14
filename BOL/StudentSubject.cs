using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class StudentSubject
    {
        public int StudentId { get; set; }

        public int SubjectId { get; set; }

        public virtual Student Student { get; set; } = null!;

        public virtual Subject Subject { get; set; } = null!;
    }   
}
