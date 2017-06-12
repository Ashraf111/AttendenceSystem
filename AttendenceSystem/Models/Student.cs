using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AttendenceSystem.Models
{
    [Table("tbleMultimediaCommunication")]
    public class Student
    {
        
        public int StudentId { get; set; }
        public Boolean PresentValid { get; set; }
    }
}