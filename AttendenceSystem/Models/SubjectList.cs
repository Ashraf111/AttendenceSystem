using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AttendenceSystem.Models
{
    [Table("tbleSubjectTable")]
    public class SubjectList
    {
        [Key]
       
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public int YearTermId { get; set; }
    }
}