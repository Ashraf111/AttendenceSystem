using AttendenceSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AttendenceSystem.Controllers
{
    public class DeptListController : Controller
    {
        // GET: DeptList
        public ActionResult DeptList()
        {
            DataRetrive dataretrive = new DataRetrive();
            List<Department> departments = dataretrive.Departments.ToList();
            return View(departments);
        }
    }
}