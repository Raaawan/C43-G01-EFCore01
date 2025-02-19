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
    //internal class Department
    //{
    //    public int Id { get; set; }
    //    public string? Name { get; set; }
    //    public int Ins_ID { get; set; }
    //    public DateTime HiringDate { get; set; }
    //}
    #endregion

    #region By Annotation
    [Table("Departments")]
    internal class Department
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Ins_ID { get; set; }
        public DateTime HiringDate { get; set; }
    }
    #endregion
}
