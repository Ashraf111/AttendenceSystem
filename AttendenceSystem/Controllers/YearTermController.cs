using AttendenceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttendenceSystem.Controllers
{
    public class YearTermController : Controller
    {
        // GET: YearTerm
        public ActionResult YearTermList(int id)
        {
            DataRetrive dataretrive = new DataRetrive();
            List<YearTerm> yearterms = dataretrive.YearTerms.Where(yt=> yt.DeptId== id).ToList();
            return View(yearterms);
        }
    }
}