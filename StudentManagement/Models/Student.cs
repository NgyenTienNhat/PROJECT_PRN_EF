using System;
using System.Collections.Generic;

#nullable disable

namespace StudentManagement.Models
{
    public partial class Student
    {
        public Student()
        {
            Marks = new HashSet<Mark>();
            SubjectStudents = new HashSet<SubjectStudent>();
        }

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Dob { get; set; }
        public bool? Male { get; set; }
        public string Mobile { get; set; }
        public string RollNo { get; set; }
        public string Address { get; set; }
        public int? ClassId { get; set; }
        public int? SubjectId { get; set; }

        public virtual Class Class { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<SubjectStudent> SubjectStudents { get; set; }
    }
}
