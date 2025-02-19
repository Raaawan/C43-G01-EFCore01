using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Model
{
    #region By convension
    //internal class Instructor
    //{
    //    public int Id { get; set; }
    //    public string? Name { get; set; }
    //    public decimal Salary { get; set; }
    //    public string? Address { get; set; }
    //    public decimal HourRate { get; set; }
    //    public int Dept_ID { get; set; }
    //}
    #endregion

    #region By Annotation
    [Table("Instructors")]
    internal class Instructor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }
        public int Dept_ID { get; set; }
    }
    #endregion
}
