using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class Class
    {
        public Class()
        {
            StudentAttendences = new HashSet<StudentAttendence>();
            Students = new HashSet<Student>();
            SubjectStudents = new HashSet<SubjectStudent>();
            TeacherSubjects = new HashSet<TeacherSubject>();
        }

        public int ClassId { get; set; }
        public string ClassName { get; set; }

        public virtual ICollection<StudentAttendence> StudentAttendences { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<SubjectStudent> SubjectStudents { get; set; }
        public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; }
    }
}
