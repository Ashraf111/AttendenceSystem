using AttendenceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttendenceSystem.Controllers
{
    public class SubjectListController : Controller
    {
        // GET: SubjectList
        public ActionResult Subjectlist( int Yid)
        {
            DataRetrive dataretrive = new DataRetrive();
            List<SubjectList> subjectlists=dataretrive.Subjectlist.Where(sl => sl.YearTermId == Yid).ToList();
            return View(subjectlists);
        }
    }
}