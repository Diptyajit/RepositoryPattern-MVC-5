using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RepositoryPatternExp.Models
{
    [Table("StudentDetails")]
    public class StudentDetails
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string MobileNo { get; set; }
        public int Salary { get; set; }
    }
}