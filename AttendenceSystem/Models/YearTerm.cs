using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AttendenceSystem.Models
{
    [Table("tbleYear_Term")]
    public class YearTerm
    {
        [Key]
        public int YearTermId { get; set; }
        public string YearTermName { get; set; }
        public int DeptId { get; set; }
        
        
       
    }
}