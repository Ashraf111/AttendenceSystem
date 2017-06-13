using AttendenceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttendenceSystem.Controllers
{
    public class CsteY4T2StudentsController : Controller
    {
        // GET: CsteY4T2Students
        
        public ActionResult Cstey4t2students(string SubjectCode)
        {
            DataRetrive dataretrive = new DataRetrive();
            List<CsteY4_T2_Students> cstey4t2students=dataretrive.Cstey4t2studens.Where(sc => sc.SubjectCode == SubjectCode).ToList();
            return View(cstey4t2students);

        }
        public JsonResult SaveStudent(List<Student> list)
        {
            
           
            return Json(1, JsonRequestBehavior.AllowGet);
        }


    }
}
