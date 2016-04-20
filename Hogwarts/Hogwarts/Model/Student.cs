using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hogwarts.Model
{
    [Table("StudentTable")]
    public class Student
    {
        [Key]
        public int StudentNumber { get; set; }

        [Required]
        [Column("StudentName")]
        [StringLength(40), MinLength(2)]
        public string Name { get; set; }

        [ForeignKey("CurrentCourse")]
        public int CurrentCourseCode { get; set; }

        public virtual Course CurrentCourse { get; set; }
    }
}
