using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class Mark
    {
        public int Id { get; set; }
        public int? StudentId { get; set; }
        public int? SubjectId { get; set; }
        public double? ProgessTest { get; set; }
        public double? MidtermTest { get; set; }
        public double? FinalTest { get; set; }
        public double? FinalTestAgain { get; set; }
        public string Note { get; set; }

        public virtual Student Student { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
