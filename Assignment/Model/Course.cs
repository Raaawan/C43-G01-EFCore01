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
    //internal class Course
    //{
    //    public int Id { get; set; }
    //    public string? Name { get; set; }
    //    public int Duration { get; set; }
    //    public string? Description { get; set; }
    //    public int Top_ID { get; set; }
    //}
    #endregion

    #region By Annotation
    [Table("Courses")]
    internal class Course
    {
        [Key]
        public int Id { get; set; }
        public int Duration { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Top_ID { get; set; }
    }
    #endregion
}
