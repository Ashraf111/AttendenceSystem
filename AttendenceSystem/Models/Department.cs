using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AttendenceSystem.Models
{
    [Table("tbleDepartment")]
    public class Department
    {
        [Key]
        public int DeptId{ get; set; }
        public string DeptName{ get; set; }
        
       
    }
}