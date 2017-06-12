using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AttendenceSystem.Models
{
    [Table("tbleMultiCommuStudents")]
    public class CsteY4_T2_Students
    {
        [Key]
        public int ID { get; set; }
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string SubjectCode { get; set; }


    }
}
