using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Model
{
    #region By convension
    //internal class Student
    //{
    //    public int Id { get; set; }
    //    public string? FName { get; set; }
    //    public string? LName { get; set; }
    //    public string? Address { get; set; }
    //    public int Age { get; set; }
    //    public int Dep_Id { get; set; }
    //}
    #endregion

    #region By Annotation
    [Table("Students")]
    internal class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FName { get; set; }
        public string LName { get; set; }
        [Required]
        public string Address { get; set; }
        public int Age { get; set; }
        public int Dep_Id { get; set; }
    }
    #endregion
}
