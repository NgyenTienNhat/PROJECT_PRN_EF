using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class Teacher
    {
        public Teacher()
        {
            TeacherAttendences = new HashSet<TeacherAttendence>();
            TeacherSubjects = new HashSet<TeacherSubject>();
        }

        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public DateTime? Dob { get; set; }
        public bool? Male { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }

        public virtual ICollection<TeacherAttendence> TeacherAttendences { get; set; }
        public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; }
    }
}
