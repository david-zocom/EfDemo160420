using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts.Model
{
    public class Course
    {
        [Key]
        public int CourseCode { get; set; }
        public string Name { get; set; }

        [NotMapped]
        public string TeacherName { get; set; }

        public virtual IList<Student> EnrolledStudents { get; set; }
    }
}
