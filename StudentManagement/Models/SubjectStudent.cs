using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class SubjectStudent
    {
        public int Id { get; set; }
        public int? SubjectId { get; set; }
        public int? StudentId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
