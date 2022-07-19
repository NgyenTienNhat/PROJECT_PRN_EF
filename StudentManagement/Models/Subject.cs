using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class Subject
    {
        public Subject()
        {
            StudentAttendences = new HashSet<StudentAttendence>();
            SubjectStudents = new HashSet<SubjectStudent>();
            TeacherSubjects = new HashSet<TeacherSubject>();
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public virtual ICollection<StudentAttendence> StudentAttendences { get; set; }
        public virtual ICollection<SubjectStudent> SubjectStudents { get; set; }
        public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; }
    }
}
