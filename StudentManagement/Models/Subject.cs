using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Marks = new HashSet<Mark>();
            Students = new HashSet<Student>();
            SubjectStudents = new HashSet<SubjectStudent>();
            TeacherSubjects = new HashSet<TeacherSubject>();
        }

        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<SubjectStudent> SubjectStudents { get; set; }
        public virtual ICollection<TeacherSubject> TeacherSubjects { get; set; }
    }
}
