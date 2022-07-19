using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class TeacherAttendence
    {
        public int Id { get; set; }
        public int? TeacherId { get; set; }
        public bool? Status { get; set; }
        public DateTime? Date { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
