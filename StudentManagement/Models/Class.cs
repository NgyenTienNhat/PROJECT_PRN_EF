using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class Class
    {
        public Class()
        {
            Students = new HashSet<Student>();
            TeacherSubjects = new HashSet<TeacherSubject>();
        }

        public int ClassId { get; set; }
        public string ClassName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; }
    }
}
